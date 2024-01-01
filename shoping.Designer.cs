namespace project2
{
    partial class shoping
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
            this.chb_apple = new System.Windows.Forms.CheckBox();
            this.cmp_apple = new System.Windows.Forms.ComboBox();
            this.chb_wm = new System.Windows.Forms.CheckBox();
            this.chb_mango = new System.Windows.Forms.CheckBox();
            this.chb_guava = new System.Windows.Forms.CheckBox();
            this.chb_grapes = new System.Windows.Forms.CheckBox();
            this.chb_pomo = new System.Windows.Forms.CheckBox();
            this.chb_orange = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmp_mango = new System.Windows.Forms.ComboBox();
            this.cmp_guava = new System.Windows.Forms.ComboBox();
            this.cmp_grapes = new System.Windows.Forms.ComboBox();
            this.cmp_pomo = new System.Windows.Forms.ComboBox();
            this.cmp_orange = new System.Windows.Forms.ComboBox();
            this.cmp_wm = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_apple = new System.Windows.Forms.TextBox();
            this.txt_orange = new System.Windows.Forms.TextBox();
            this.txt_pomo = new System.Windows.Forms.TextBox();
            this.txt_grapes = new System.Windows.Forms.TextBox();
            this.txt_guava = new System.Windows.Forms.TextBox();
            this.txt_mango = new System.Windows.Forms.TextBox();
            this.txt_wm = new System.Windows.Forms.TextBox();
            this.btn_total = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbill = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_apple
            // 
            this.chb_apple.AutoSize = true;
            this.chb_apple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_apple.Location = new System.Drawing.Point(26, 190);
            this.chb_apple.Name = "chb_apple";
            this.chb_apple.Size = new System.Drawing.Size(78, 26);
            this.chb_apple.TabIndex = 0;
            this.chb_apple.Text = "Apple";
            this.chb_apple.UseVisualStyleBackColor = true;
            this.chb_apple.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmp_apple
            // 
            this.cmp_apple.FormattingEnabled = true;
            this.cmp_apple.Items.AddRange(new object[] {
            "KG",
            "GR"});
            this.cmp_apple.Location = new System.Drawing.Point(278, 188);
            this.cmp_apple.Name = "cmp_apple";
            this.cmp_apple.Size = new System.Drawing.Size(44, 24);
            this.cmp_apple.TabIndex = 1;
            // 
            // chb_wm
            // 
            this.chb_wm.AutoSize = true;
            this.chb_wm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_wm.Location = new System.Drawing.Point(25, 630);
            this.chb_wm.Name = "chb_wm";
            this.chb_wm.Size = new System.Drawing.Size(128, 26);
            this.chb_wm.TabIndex = 3;
            this.chb_wm.Text = "WaterMelon";
            this.chb_wm.UseVisualStyleBackColor = true;
            this.chb_wm.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chb_mango
            // 
            this.chb_mango.AutoSize = true;
            this.chb_mango.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mango.Location = new System.Drawing.Point(25, 552);
            this.chb_mango.Name = "chb_mango";
            this.chb_mango.Size = new System.Drawing.Size(86, 26);
            this.chb_mango.TabIndex = 4;
            this.chb_mango.Text = "Mango";
            this.chb_mango.UseVisualStyleBackColor = true;
            this.chb_mango.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chb_guava
            // 
            this.chb_guava.AutoSize = true;
            this.chb_guava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_guava.Location = new System.Drawing.Point(26, 476);
            this.chb_guava.Name = "chb_guava";
            this.chb_guava.Size = new System.Drawing.Size(85, 26);
            this.chb_guava.TabIndex = 5;
            this.chb_guava.Text = "Guava";
            this.chb_guava.UseVisualStyleBackColor = true;
            this.chb_guava.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chb_grapes
            // 
            this.chb_grapes.AutoSize = true;
            this.chb_grapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_grapes.Location = new System.Drawing.Point(26, 402);
            this.chb_grapes.Name = "chb_grapes";
            this.chb_grapes.Size = new System.Drawing.Size(87, 26);
            this.chb_grapes.TabIndex = 6;
            this.chb_grapes.Text = "grapes";
            this.chb_grapes.UseVisualStyleBackColor = true;
            // 
            // chb_pomo
            // 
            this.chb_pomo.AutoSize = true;
            this.chb_pomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_pomo.Location = new System.Drawing.Point(26, 340);
            this.chb_pomo.Name = "chb_pomo";
            this.chb_pomo.Size = new System.Drawing.Size(139, 26);
            this.chb_pomo.TabIndex = 7;
            this.chb_pomo.Text = "Pomogranate";
            this.chb_pomo.UseVisualStyleBackColor = true;
            // 
            // chb_orange
            // 
            this.chb_orange.AutoSize = true;
            this.chb_orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_orange.Location = new System.Drawing.Point(26, 262);
            this.chb_orange.Name = "chb_orange";
            this.chb_orange.Size = new System.Drawing.Size(88, 26);
            this.chb_orange.TabIndex = 8;
            this.chb_orange.Text = "orange";
            this.chb_orange.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(-6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 115);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("High Tower Text", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(336, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 38);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Allan Fruits";
            // 
            // cmp_mango
            // 
            this.cmp_mango.FormattingEnabled = true;
            this.cmp_mango.Items.AddRange(new object[] {
            "1kg",
            "1/2kg"});
            this.cmp_mango.Location = new System.Drawing.Point(278, 552);
            this.cmp_mango.Name = "cmp_mango";
            this.cmp_mango.Size = new System.Drawing.Size(44, 24);
            this.cmp_mango.TabIndex = 11;
            // 
            // cmp_guava
            // 
            this.cmp_guava.FormattingEnabled = true;
            this.cmp_guava.Items.AddRange(new object[] {
            "1kg",
            "1/2kg"});
            this.cmp_guava.Location = new System.Drawing.Point(278, 476);
            this.cmp_guava.Name = "cmp_guava";
            this.cmp_guava.Size = new System.Drawing.Size(44, 24);
            this.cmp_guava.TabIndex = 12;
            // 
            // cmp_grapes
            // 
            this.cmp_grapes.FormattingEnabled = true;
            this.cmp_grapes.Items.AddRange(new object[] {
            "1kg",
            "1/2kg"});
            this.cmp_grapes.Location = new System.Drawing.Point(278, 405);
            this.cmp_grapes.Name = "cmp_grapes";
            this.cmp_grapes.Size = new System.Drawing.Size(44, 24);
            this.cmp_grapes.TabIndex = 13;
            // 
            // cmp_pomo
            // 
            this.cmp_pomo.FormattingEnabled = true;
            this.cmp_pomo.Items.AddRange(new object[] {
            "1kg",
            "1/2kg"});
            this.cmp_pomo.Location = new System.Drawing.Point(278, 336);
            this.cmp_pomo.Name = "cmp_pomo";
            this.cmp_pomo.Size = new System.Drawing.Size(44, 24);
            this.cmp_pomo.TabIndex = 14;
            // 
            // cmp_orange
            // 
            this.cmp_orange.FormattingEnabled = true;
            this.cmp_orange.Items.AddRange(new object[] {
            "1kg",
            "1/2kg"});
            this.cmp_orange.Location = new System.Drawing.Point(278, 259);
            this.cmp_orange.Name = "cmp_orange";
            this.cmp_orange.Size = new System.Drawing.Size(44, 24);
            this.cmp_orange.TabIndex = 15;
            // 
            // cmp_wm
            // 
            this.cmp_wm.FormattingEnabled = true;
            this.cmp_wm.Items.AddRange(new object[] {
            "1kg",
            "1/2kg"});
            this.cmp_wm.Location = new System.Drawing.Point(278, 633);
            this.cmp_wm.Name = "cmp_wm";
            this.cmp_wm.Size = new System.Drawing.Size(44, 24);
            this.cmp_wm.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(337, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 397);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product_Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Orginal_Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // txt_apple
            // 
            this.txt_apple.Location = new System.Drawing.Point(168, 190);
            this.txt_apple.Name = "txt_apple";
            this.txt_apple.Size = new System.Drawing.Size(80, 22);
            this.txt_apple.TabIndex = 18;
            // 
            // txt_orange
            // 
            this.txt_orange.Location = new System.Drawing.Point(168, 262);
            this.txt_orange.Name = "txt_orange";
            this.txt_orange.Size = new System.Drawing.Size(80, 22);
            this.txt_orange.TabIndex = 19;
            // 
            // txt_pomo
            // 
            this.txt_pomo.Location = new System.Drawing.Point(168, 340);
            this.txt_pomo.Name = "txt_pomo";
            this.txt_pomo.Size = new System.Drawing.Size(80, 22);
            this.txt_pomo.TabIndex = 20;
            // 
            // txt_grapes
            // 
            this.txt_grapes.Location = new System.Drawing.Point(168, 409);
            this.txt_grapes.Name = "txt_grapes";
            this.txt_grapes.Size = new System.Drawing.Size(80, 22);
            this.txt_grapes.TabIndex = 21;
            // 
            // txt_guava
            // 
            this.txt_guava.Location = new System.Drawing.Point(168, 480);
            this.txt_guava.Name = "txt_guava";
            this.txt_guava.Size = new System.Drawing.Size(80, 22);
            this.txt_guava.TabIndex = 22;
            // 
            // txt_mango
            // 
            this.txt_mango.Location = new System.Drawing.Point(168, 556);
            this.txt_mango.Name = "txt_mango";
            this.txt_mango.Size = new System.Drawing.Size(80, 22);
            this.txt_mango.TabIndex = 23;
            // 
            // txt_wm
            // 
            this.txt_wm.Location = new System.Drawing.Point(168, 637);
            this.txt_wm.Name = "txt_wm";
            this.txt_wm.Size = new System.Drawing.Size(80, 22);
            this.txt_wm.TabIndex = 24;
            // 
            // btn_total
            // 
            this.btn_total.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_total.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_total.Location = new System.Drawing.Point(192, 708);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(130, 39);
            this.btn_total.TabIndex = 25;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = false;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(610, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 39);
            this.button2.TabIndex = 26;
            this.button2.Text = "Payment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtbill
            // 
            this.txtbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbill.Location = new System.Drawing.Point(371, 714);
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(148, 38);
            this.txtbill.TabIndex = 27;
            // 
            // TOTAL
            // 
            this.TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TOTAL.Location = new System.Drawing.Point(371, 633);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(200, 69);
            this.TOTAL.TabIndex = 28;
            this.TOTAL.TabStop = false;
            this.TOTAL.Text = "TOTAL";
            // 
            // shoping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 811);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.txtbill);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.txt_wm);
            this.Controls.Add(this.txt_mango);
            this.Controls.Add(this.txt_guava);
            this.Controls.Add(this.txt_grapes);
            this.Controls.Add(this.txt_pomo);
            this.Controls.Add(this.txt_orange);
            this.Controls.Add(this.txt_apple);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmp_wm);
            this.Controls.Add(this.cmp_orange);
            this.Controls.Add(this.cmp_pomo);
            this.Controls.Add(this.cmp_grapes);
            this.Controls.Add(this.cmp_guava);
            this.Controls.Add(this.cmp_mango);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chb_orange);
            this.Controls.Add(this.chb_pomo);
            this.Controls.Add(this.chb_grapes);
            this.Controls.Add(this.chb_guava);
            this.Controls.Add(this.chb_mango);
            this.Controls.Add(this.chb_wm);
            this.Controls.Add(this.cmp_apple);
            this.Controls.Add(this.chb_apple);
            this.Name = "shoping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.shoping_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_apple;
        private System.Windows.Forms.ComboBox cmp_apple;
        private System.Windows.Forms.CheckBox chb_wm;
        private System.Windows.Forms.CheckBox chb_mango;
        private System.Windows.Forms.CheckBox chb_guava;
        private System.Windows.Forms.CheckBox chb_grapes;
        private System.Windows.Forms.CheckBox chb_pomo;
        private System.Windows.Forms.CheckBox chb_orange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmp_mango;
        private System.Windows.Forms.ComboBox cmp_guava;
        private System.Windows.Forms.ComboBox cmp_grapes;
        private System.Windows.Forms.ComboBox cmp_pomo;
        private System.Windows.Forms.ComboBox cmp_orange;
        private System.Windows.Forms.ComboBox cmp_wm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_apple;
        private System.Windows.Forms.TextBox txt_orange;
        private System.Windows.Forms.TextBox txt_pomo;
        private System.Windows.Forms.TextBox txt_grapes;
        private System.Windows.Forms.TextBox txt_guava;
        private System.Windows.Forms.TextBox txt_mango;
        private System.Windows.Forms.TextBox txt_wm;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.GroupBox TOTAL;
    }
}