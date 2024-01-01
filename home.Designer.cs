namespace project2
{
    partial class home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JackFruit = new System.Windows.Forms.LinkLabel();
            this.button_Sg = new System.Windows.Forms.Button();
            this.Button_Au = new System.Windows.Forms.Button();
            this.button_Pd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.JackFruit);
            this.panel1.Controls.Add(this.button_Sg);
            this.panel1.Controls.Add(this.Button_Au);
            this.panel1.Controls.Add(this.button_Pd);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 127);
            this.panel1.TabIndex = 0;
            // 
            // JackFruit
            // 
            this.JackFruit.AutoSize = true;
            this.JackFruit.Font = new System.Drawing.Font("Harrington", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackFruit.LinkColor = System.Drawing.Color.White;
            this.JackFruit.Location = new System.Drawing.Point(63, 43);
            this.JackFruit.Name = "JackFruit";
            this.JackFruit.Size = new System.Drawing.Size(174, 32);
            this.JackFruit.TabIndex = 2;
            this.JackFruit.TabStop = true;
            this.JackFruit.Text = "Allan Fruits";
            // 
            // button_Sg
            // 
            this.button_Sg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sg.Location = new System.Drawing.Point(506, 43);
            this.button_Sg.Name = "button_Sg";
            this.button_Sg.Size = new System.Drawing.Size(129, 44);
            this.button_Sg.TabIndex = 1;
            this.button_Sg.Text = "Shoping";
            this.button_Sg.UseVisualStyleBackColor = true;
            this.button_Sg.Click += new System.EventHandler(this.button_Sg_Click);
            // 
            // Button_Au
            // 
            this.Button_Au.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Au.Location = new System.Drawing.Point(687, 43);
            this.Button_Au.Name = "Button_Au";
            this.Button_Au.Size = new System.Drawing.Size(129, 44);
            this.Button_Au.TabIndex = 2;
            this.Button_Au.Text = "About Us";
            this.Button_Au.UseVisualStyleBackColor = true;
            this.Button_Au.Click += new System.EventHandler(this.Button_Au_Click);
            // 
            // button_Pd
            // 
            this.button_Pd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pd.Location = new System.Drawing.Point(325, 43);
            this.button_Pd.Name = "button_Pd";
            this.button_Pd.Size = new System.Drawing.Size(129, 44);
            this.button_Pd.TabIndex = 0;
            this.button_Pd.Text = "Product Details";
            this.button_Pd.UseVisualStyleBackColor = true;
            this.button_Pd.Click += new System.EventHandler(this.button_Pd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(685, 805);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project2.Properties.Resources.aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Sg;
        private System.Windows.Forms.Button Button_Au;
        private System.Windows.Forms.Button button_Pd;
        private System.Windows.Forms.LinkLabel JackFruit;
        private System.Windows.Forms.Button button1;
    }
}