namespace mainForm
{
    partial class newUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logIn1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.passwd1 = new System.Windows.Forms.TextBox();
            this.email1 = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.TextBox();
            this.NIC1 = new System.Windows.Forms.MaskedTextBox();
            this.age1 = new System.Windows.Forms.NumericUpDown();
            this.DOB1 = new System.Windows.Forms.DateTimePicker();
            this.gender1 = new System.Windows.Forms.ComboBox();
            this.football1 = new System.Windows.Forms.CheckBox();
            this.cricket1 = new System.Windows.Forms.CheckBox();
            this.hockey1 = new System.Windows.Forms.CheckBox();
            this.submit1 = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upload1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.age1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(90, 28);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 20);
            this.name1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log In";
            // 
            // logIn1
            // 
            this.logIn1.Location = new System.Drawing.Point(90, 54);
            this.logIn1.Name = "logIn1";
            this.logIn1.Size = new System.Drawing.Size(100, 20);
            this.logIn1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "NIC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "DOB";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sports";
            // 
            // passwd1
            // 
            this.passwd1.Location = new System.Drawing.Point(90, 81);
            this.passwd1.Name = "passwd1";
            this.passwd1.PasswordChar = '*';
            this.passwd1.Size = new System.Drawing.Size(100, 20);
            this.passwd1.TabIndex = 12;
            // 
            // email1
            // 
            this.email1.Location = new System.Drawing.Point(90, 112);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(100, 20);
            this.email1.TabIndex = 13;
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(90, 187);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(100, 20);
            this.address1.TabIndex = 14;
            // 
            // NIC1
            // 
            this.NIC1.Location = new System.Drawing.Point(90, 283);
            this.NIC1.Mask = "00000-0000000-0";
            this.NIC1.Name = "NIC1";
            this.NIC1.Size = new System.Drawing.Size(100, 20);
            this.NIC1.TabIndex = 15;
            // 
            // age1
            // 
            this.age1.Location = new System.Drawing.Point(90, 257);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(120, 20);
            this.age1.TabIndex = 16;
            // 
            // DOB1
            // 
            this.DOB1.Location = new System.Drawing.Point(90, 312);
            this.DOB1.Name = "DOB1";
            this.DOB1.Size = new System.Drawing.Size(200, 20);
            this.DOB1.TabIndex = 17;
            // 
            // gender1
            // 
            this.gender1.FormattingEnabled = true;
            this.gender1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender1.Location = new System.Drawing.Point(90, 143);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(121, 21);
            this.gender1.TabIndex = 18;
            // 
            // football1
            // 
            this.football1.AutoSize = true;
            this.football1.Location = new System.Drawing.Point(90, 339);
            this.football1.Name = "football1";
            this.football1.Size = new System.Drawing.Size(63, 17);
            this.football1.TabIndex = 19;
            this.football1.Text = "Football";
            this.football1.UseVisualStyleBackColor = true;
            // 
            // cricket1
            // 
            this.cricket1.AutoSize = true;
            this.cricket1.Location = new System.Drawing.Point(176, 339);
            this.cricket1.Name = "cricket1";
            this.cricket1.Size = new System.Drawing.Size(59, 17);
            this.cricket1.TabIndex = 20;
            this.cricket1.Text = "Cricket";
            this.cricket1.UseVisualStyleBackColor = true;
            this.cricket1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // hockey1
            // 
            this.hockey1.AutoSize = true;
            this.hockey1.Location = new System.Drawing.Point(262, 339);
            this.hockey1.Name = "hockey1";
            this.hockey1.Size = new System.Drawing.Size(57, 17);
            this.hockey1.TabIndex = 21;
            this.hockey1.Text = "Hocky";
            this.hockey1.UseVisualStyleBackColor = true;
            // 
            // submit1
            // 
            this.submit1.Location = new System.Drawing.Point(90, 375);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(61, 23);
            this.submit1.TabIndex = 22;
            this.submit1.Text = "Submit";
            this.submit1.UseVisualStyleBackColor = true;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(215, 375);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(75, 23);
            this.cancel1.TabIndex = 23;
            this.cancel1.Text = "Cancel";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // upload1
            // 
            this.upload1.Location = new System.Drawing.Point(351, 156);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(75, 23);
            this.upload1.TabIndex = 25;
            this.upload1.Text = "Upload";
            this.upload1.UseVisualStyleBackColor = true;
            this.upload1.Click += new System.EventHandler(this.upload1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG filles|*.jpg";
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.upload1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.hockey1);
            this.Controls.Add(this.cricket1);
            this.Controls.Add(this.football1);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.DOB1);
            this.Controls.Add(this.age1);
            this.Controls.Add(this.NIC1);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.passwd1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logIn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label1);
            this.Name = "newUser";
            this.Text = "New User";
            ((System.ComponentModel.ISupportInitialize)(this.age1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logIn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passwd1;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.MaskedTextBox NIC1;
        private System.Windows.Forms.NumericUpDown age1;
        private System.Windows.Forms.DateTimePicker DOB1;
        private System.Windows.Forms.ComboBox gender1;
        private System.Windows.Forms.CheckBox football1;
        private System.Windows.Forms.CheckBox cricket1;
        private System.Windows.Forms.CheckBox hockey1;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button upload1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}