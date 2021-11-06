
namespace Uplay_Bruter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblThread = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMul = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.lbltfa = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(962, 433);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(942, 413);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblThread);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.btnProxy);
            this.groupBox2.Controls.Add(this.btnCombo);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(11, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Http/Https",
            "Socks5",
            "Socks4",
            "Socks4A"});
            this.comboBox1.Location = new System.Drawing.Point(67, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Http/Https";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblThread
            // 
            this.lblThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblThread.Location = new System.Drawing.Point(20, 266);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(202, 23);
            this.lblThread.TabIndex = 5;
            this.lblThread.Text = "Thread: 200";
            this.lblThread.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Proxy API:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(20, 233);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(202, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnProxy
            // 
            this.btnProxy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProxy.ForeColor = System.Drawing.Color.White;
            this.btnProxy.Location = new System.Drawing.Point(20, 163);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(202, 48);
            this.btnProxy.TabIndex = 2;
            this.btnProxy.Text = "Load Proxy";
            this.btnProxy.UseVisualStyleBackColor = false;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCombo.ForeColor = System.Drawing.Color.White;
            this.btnCombo.Location = new System.Drawing.Point(20, 97);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(202, 48);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.Text = "Load Combo";
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(20, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblMul);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.lblBad);
            this.groupBox1.Controls.Add(this.lbltfa);
            this.groupBox1.Controls.Add(this.lblGood);
            this.groupBox1.Controls.Add(this.lblCheck);
            this.groupBox1.Controls.Add(this.lblRemain);
            this.groupBox1.Location = new System.Drawing.Point(667, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // lblMul
            // 
            this.lblMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMul.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMul.Location = new System.Drawing.Point(6, 330);
            this.lblMul.Name = "lblMul";
            this.lblMul.Size = new System.Drawing.Size(253, 23);
            this.lblMul.TabIndex = 12;
            this.lblMul.Text = "00:00:00 / CPM: 0";
            this.lblMul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Gold;
            this.lblError.Location = new System.Drawing.Point(6, 276);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(253, 23);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error: 0";
            // 
            // lblBad
            // 
            this.lblBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBad.ForeColor = System.Drawing.Color.Red;
            this.lblBad.Location = new System.Drawing.Point(6, 223);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(253, 23);
            this.lblBad.TabIndex = 10;
            this.lblBad.Text = "Bad: 0";
            // 
            // lbltfa
            // 
            this.lbltfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbltfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltfa.Location = new System.Drawing.Point(6, 172);
            this.lbltfa.Name = "lbltfa";
            this.lbltfa.Size = new System.Drawing.Size(253, 23);
            this.lbltfa.TabIndex = 9;
            this.lbltfa.Text = "Custom: 0";
            // 
            // lblGood
            // 
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblGood.ForeColor = System.Drawing.Color.Lime;
            this.lblGood.Location = new System.Drawing.Point(6, 122);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(253, 23);
            this.lblGood.TabIndex = 8;
            this.lblGood.Text = "Good: 0";
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCheck.ForeColor = System.Drawing.Color.Maroon;
            this.lblCheck.Location = new System.Drawing.Point(6, 70);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(253, 23);
            this.lblCheck.TabIndex = 7;
            this.lblCheck.Text = "Checked: 0";
            // 
            // lblRemain
            // 
            this.lblRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRemain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRemain.Location = new System.Drawing.Point(6, 32);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(253, 23);
            this.lblRemain.TabIndex = 6;
            this.lblRemain.Text = "Remaining: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            this.dataGridView1.Location = new System.Drawing.Point(273, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Uplay Bruter by Ariaei";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label lbltfa;
        private System.Windows.Forms.Label lblMul;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Timer timer1;
    }
}

