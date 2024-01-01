namespace project2
{
    partial class signup
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
            this.label2 = new System.Windows.Forms.Label();
            this.Su_btn = new System.Windows.Forms.Button();
            this.Su_Password = new System.Windows.Forms.TextBox();
            this.Su_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Su_Username = new System.Windows.Forms.TextBox();
            this.Su_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "PASSWORD";
            // 
            // Su_btn
            // 
            this.Su_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Su_btn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_btn.Location = new System.Drawing.Point(464, 520);
            this.Su_btn.Name = "Su_btn";
            this.Su_btn.Size = new System.Drawing.Size(150, 40);
            this.Su_btn.TabIndex = 9;
            this.Su_btn.Text = "REGISTER";
            this.Su_btn.UseVisualStyleBackColor = false;
            this.Su_btn.Click += new System.EventHandler(this.Su_btn_Click);
            // 
            // Su_Password
            // 
            this.Su_Password.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_Password.Location = new System.Drawing.Point(362, 431);
            this.Su_Password.Name = "Su_Password";
            this.Su_Password.Size = new System.Drawing.Size(345, 40);
            this.Su_Password.TabIndex = 8;
            // 
            // Su_Email
            // 
            this.Su_Email.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_Email.Location = new System.Drawing.Point(362, 272);
            this.Su_Email.Name = "Su_Email";
            this.Su_Email.Size = new System.Drawing.Size(345, 40);
            this.Su_Email.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(132, 367);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(149, 28);
            this.username.TabIndex = 12;
            this.username.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "EMAIL";
            // 
            // Su_Username
            // 
            this.Su_Username.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_Username.Location = new System.Drawing.Point(362, 355);
            this.Su_Username.Name = "Su_Username";
            this.Su_Username.Size = new System.Drawing.Size(345, 40);
            this.Su_Username.TabIndex = 14;
            // 
            // Su_name
            // 
            this.Su_name.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_name.Location = new System.Drawing.Point(362, 197);
            this.Su_name.Name = "Su_name";
            this.Su_name.Size = new System.Drawing.Size(345, 40);
            this.Su_name.TabIndex = 15;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 783);
            this.Controls.Add(this.Su_name);
            this.Controls.Add(this.Su_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Su_btn);
            this.Controls.Add(this.Su_Password);
            this.Controls.Add(this.Su_Email);
            this.Controls.Add(this.label1);
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Su_btn;
        private System.Windows.Forms.TextBox Su_Password;
        private System.Windows.Forms.TextBox Su_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Su_Username;
        private System.Windows.Forms.TextBox Su_name;
    }
}