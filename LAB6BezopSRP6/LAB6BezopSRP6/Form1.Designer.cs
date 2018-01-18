namespace LAB6BezopSRP6
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.identificatorTextBox = new System.Windows.Forms.TextBox();
            this.verificatorTextBox = new System.Windows.Forms.TextBox();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.secretATextBox = new System.Windows.Forms.TextBox();
            this.secretALabel = new System.Windows.Forms.Label();
            this.openBTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saltTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openATextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.secretBTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.KeyOfSessionClientTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.KeyOfSessionServerTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ClientKTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ServerKTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.serverScramberTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.clientScramberTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(12, 12);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(118, 20);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(136, 19);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(136, 45);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 38);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(118, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verificator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Identivicator:";
            // 
            // identificatorTextBox
            // 
            this.identificatorTextBox.Location = new System.Drawing.Point(293, 209);
            this.identificatorTextBox.Name = "identificatorTextBox";
            this.identificatorTextBox.Size = new System.Drawing.Size(234, 20);
            this.identificatorTextBox.TabIndex = 11;
            // 
            // verificatorTextBox
            // 
            this.verificatorTextBox.Location = new System.Drawing.Point(293, 170);
            this.verificatorTextBox.Name = "verificatorTextBox";
            this.verificatorTextBox.Size = new System.Drawing.Size(234, 20);
            this.verificatorTextBox.TabIndex = 12;
            // 
            // saltTextBox
            // 
            this.saltTextBox.Location = new System.Drawing.Point(293, 126);
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(234, 20);
            this.saltTextBox.TabIndex = 13;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(14, 206);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(177, 23);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(14, 180);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(118, 20);
            this.LoginPasswordTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Username";
            // 
            // LoginUsernameTextBox
            // 
            this.LoginUsernameTextBox.Location = new System.Drawing.Point(14, 154);
            this.LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            this.LoginUsernameTextBox.Size = new System.Drawing.Size(118, 20);
            this.LoginUsernameTextBox.TabIndex = 14;
            // 
            // secretATextBox
            // 
            this.secretATextBox.Location = new System.Drawing.Point(14, 264);
            this.secretATextBox.Name = "secretATextBox";
            this.secretATextBox.Size = new System.Drawing.Size(234, 20);
            this.secretATextBox.TabIndex = 20;
            // 
            // secretALabel
            // 
            this.secretALabel.AutoSize = true;
            this.secretALabel.Location = new System.Drawing.Point(11, 248);
            this.secretALabel.Name = "secretALabel";
            this.secretALabel.Size = new System.Drawing.Size(48, 13);
            this.secretALabel.TabIndex = 19;
            this.secretALabel.Text = "SecretA:";
            // 
            // openBTextBox
            // 
            this.openBTextBox.Location = new System.Drawing.Point(14, 307);
            this.openBTextBox.Name = "openBTextBox";
            this.openBTextBox.Size = new System.Drawing.Size(234, 20);
            this.openBTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "OpenB:";
            // 
            // saltTextBox2
            // 
            this.saltTextBox2.Location = new System.Drawing.Point(14, 349);
            this.saltTextBox2.Name = "saltTextBox2";
            this.saltTextBox2.Size = new System.Drawing.Size(234, 20);
            this.saltTextBox2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Salt:";
            // 
            // openATextBox
            // 
            this.openATextBox.Location = new System.Drawing.Point(293, 307);
            this.openATextBox.Name = "openATextBox";
            this.openATextBox.Size = new System.Drawing.Size(234, 20);
            this.openATextBox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "OpenA:";
            // 
            // secretBTextBox
            // 
            this.secretBTextBox.Location = new System.Drawing.Point(293, 264);
            this.secretBTextBox.Name = "secretBTextBox";
            this.secretBTextBox.Size = new System.Drawing.Size(234, 20);
            this.secretBTextBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "SecretB:";
            // 
            // KeyOfSessionClientTextBox
            // 
            this.KeyOfSessionClientTextBox.Location = new System.Drawing.Point(12, 446);
            this.KeyOfSessionClientTextBox.Name = "KeyOfSessionClientTextBox";
            this.KeyOfSessionClientTextBox.Size = new System.Drawing.Size(234, 20);
            this.KeyOfSessionClientTextBox.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "KeyOfSession:";
            // 
            // KeyOfSessionServerTextBox
            // 
            this.KeyOfSessionServerTextBox.Location = new System.Drawing.Point(293, 446);
            this.KeyOfSessionServerTextBox.Name = "KeyOfSessionServerTextBox";
            this.KeyOfSessionServerTextBox.Size = new System.Drawing.Size(234, 20);
            this.KeyOfSessionServerTextBox.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "KeyOfSession:";
            // 
            // ClientKTextBox
            // 
            this.ClientKTextBox.Location = new System.Drawing.Point(14, 490);
            this.ClientKTextBox.Name = "ClientKTextBox";
            this.ClientKTextBox.Size = new System.Drawing.Size(234, 20);
            this.ClientKTextBox.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "ClientK:";
            // 
            // ServerKTextBox
            // 
            this.ServerKTextBox.Location = new System.Drawing.Point(295, 490);
            this.ServerKTextBox.Name = "ServerKTextBox";
            this.ServerKTextBox.Size = new System.Drawing.Size(234, 20);
            this.ServerKTextBox.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "ServerK:";
            // 
            // serverScramberTextBox
            // 
            this.serverScramberTextBox.Location = new System.Drawing.Point(293, 396);
            this.serverScramberTextBox.Name = "serverScramberTextBox";
            this.serverScramberTextBox.Size = new System.Drawing.Size(234, 20);
            this.serverScramberTextBox.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Scramber(u):";
            // 
            // clientScramberTextBox
            // 
            this.clientScramberTextBox.Location = new System.Drawing.Point(12, 396);
            this.clientScramberTextBox.Name = "clientScramberTextBox";
            this.clientScramberTextBox.Size = new System.Drawing.Size(234, 20);
            this.clientScramberTextBox.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Scramber(u):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 562);
            this.Controls.Add(this.serverScramberTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.clientScramberTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ServerKTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ClientKTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.KeyOfSessionServerTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.KeyOfSessionClientTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.openATextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.secretBTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saltTextBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.openBTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.secretATextBox);
            this.Controls.Add(this.secretALabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginUsernameTextBox);
            this.Controls.Add(this.saltTextBox);
            this.Controls.Add(this.verificatorTextBox);
            this.Controls.Add(this.identificatorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox identificatorTextBox;
        private System.Windows.Forms.TextBox verificatorTextBox;
        private System.Windows.Forms.TextBox saltTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginUsernameTextBox;
        private System.Windows.Forms.TextBox secretATextBox;
        private System.Windows.Forms.Label secretALabel;
        private System.Windows.Forms.TextBox openBTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox saltTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox openATextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox secretBTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox KeyOfSessionClientTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox KeyOfSessionServerTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ClientKTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ServerKTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox serverScramberTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox clientScramberTextBox;
        private System.Windows.Forms.Label label16;
    }
}

