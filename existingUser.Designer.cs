namespace mainForm
{
    partial class existingUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin3 = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.login3 = new System.Windows.Forms.TextBox();
            this.password3 = new System.Windows.Forms.TextBox();
            this.email3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btnLogin3
            // 
            this.btnLogin3.Location = new System.Drawing.Point(49, 189);
            this.btnLogin3.Name = "btnLogin3";
            this.btnLogin3.Size = new System.Drawing.Size(75, 23);
            this.btnLogin3.TabIndex = 2;
            this.btnLogin3.Text = "Login";
            this.btnLogin3.UseVisualStyleBackColor = true;
            this.btnLogin3.Click += new System.EventHandler(this.btnLogin3_Click);
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(148, 189);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(75, 23);
            this.btnCancel3.TabIndex = 3;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forget Password?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(148, 322);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(75, 23);
            this.btnReset3.TabIndex = 6;
            this.btnReset3.Text = "Reset now!";
            this.btnReset3.UseVisualStyleBackColor = true;
            // 
            // login3
            // 
            this.login3.Location = new System.Drawing.Point(148, 68);
            this.login3.Name = "login3";
            this.login3.Size = new System.Drawing.Size(100, 20);
            this.login3.TabIndex = 7;
            // 
            // password3
            // 
            this.password3.Location = new System.Drawing.Point(148, 110);
            this.password3.Name = "password3";
            this.password3.Size = new System.Drawing.Size(100, 20);
            this.password3.TabIndex = 8;
            // 
            // email3
            // 
            this.email3.Location = new System.Drawing.Point(148, 275);
            this.email3.Name = "email3";
            this.email3.Size = new System.Drawing.Size(100, 20);
            this.email3.TabIndex = 9;
            // 
            // existingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.email3);
            this.Controls.Add(this.password3);
            this.Controls.Add(this.login3);
            this.Controls.Add(this.btnReset3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel3);
            this.Controls.Add(this.btnLogin3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "existingUser";
            this.Text = "Existing User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin3;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset3;
        private System.Windows.Forms.TextBox login3;
        private System.Windows.Forms.TextBox password3;
        private System.Windows.Forms.TextBox email3;
    }
}