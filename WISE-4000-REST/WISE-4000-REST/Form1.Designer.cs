namespace WISE_4000_REST
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatchData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJSON = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(109, 20);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(148, 26);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.Text = "192.168.1.1";
            this.txtIPAddress.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(294, 20);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(481, 26);
            this.txtTarget.TabIndex = 3;
            this.txtTarget.Text = "di_value/slot_0";
            this.txtTarget.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "/";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(109, 66);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(666, 26);
            this.txtURL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patch Data:";
            // 
            // txtPatchData
            // 
            this.txtPatchData.Location = new System.Drawing.Point(110, 191);
            this.txtPatchData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPatchData.Multiline = true;
            this.txtPatchData.Name = "txtPatchData";
            this.txtPatchData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatchData.Size = new System.Drawing.Size(666, 83);
            this.txtPatchData.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Account:";
            // 
            // txtAcount
            // 
            this.txtAcount.Location = new System.Drawing.Point(197, 109);
            this.txtAcount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcount.Name = "txtAcount";
            this.txtAcount.Size = new System.Drawing.Size(148, 26);
            this.txtAcount.TabIndex = 9;
            this.txtAcount.Text = "root";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(196, 142);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 26);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "00000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // txtJSON
            // 
            this.txtJSON.AcceptsReturn = true;
            this.txtJSON.Enabled = false;
            this.txtJSON.Location = new System.Drawing.Point(108, 333);
            this.txtJSON.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJSON.Multiline = true;
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJSON.Size = new System.Drawing.Size(666, 262);
            this.txtJSON.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(108, 284);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(667, 39);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send HTTP reqeust";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "JSON data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GET",
            "PATCH"});
            this.comboBox1.Location = new System.Drawing.Point(517, 106);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 668);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtJSON);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatchData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "WISE-4000 REST sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatchData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJSON;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

