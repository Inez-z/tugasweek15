namespace TUGAS_WEEK_15
{
    partial class Formsatu
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
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.textBoxNamaItem = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBoxKiri = new System.Windows.Forms.ListBox();
            this.listBoxKanan = new System.Windows.Forms.ListBox();
            this.buttonSalin = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(32, 41);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(87, 20);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // textBoxNamaItem
            // 
            this.textBoxNamaItem.Location = new System.Drawing.Point(181, 38);
            this.textBoxNamaItem.Name = "textBoxNamaItem";
            this.textBoxNamaItem.Size = new System.Drawing.Size(226, 26);
            this.textBoxNamaItem.TabIndex = 1;
            this.textBoxNamaItem.TextChanged += new System.EventHandler(this.buttonInput_Click);
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(33, 94);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(68, 20);
            this.labelKategori.TabIndex = 2;
            this.labelKategori.Text = "Kategori";
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(181, 90);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(100, 24);
            this.radioButtonMakanan.TabIndex = 3;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(308, 90);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(99, 24);
            this.radioButtonMinuman.TabIndex = 4;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(181, 137);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(140, 31);
            this.buttonInput.TabIndex = 5;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.TextChanged += new System.EventHandler(this.listBoxKiri_SelectedIndexChanged);
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBoxKiri
            // 
            this.listBoxKiri.FormattingEnabled = true;
            this.listBoxKiri.ItemHeight = 20;
            this.listBoxKiri.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti",
            "Keju",
            "Daging giling",
            "Teh",
            "Bir"});
            this.listBoxKiri.Location = new System.Drawing.Point(8, 225);
            this.listBoxKiri.Name = "listBoxKiri";
            this.listBoxKiri.Size = new System.Drawing.Size(313, 424);
            this.listBoxKiri.TabIndex = 6;
            // 
            // listBoxKanan
            // 
            this.listBoxKanan.FormattingEnabled = true;
            this.listBoxKanan.ItemHeight = 20;
            this.listBoxKanan.Location = new System.Drawing.Point(465, 225);
            this.listBoxKanan.Name = "listBoxKanan";
            this.listBoxKanan.Size = new System.Drawing.Size(305, 424);
            this.listBoxKanan.TabIndex = 7;
            this.listBoxKanan.SelectedIndexChanged += new System.EventHandler(this.listBoxKanan_SelectedIndexChanged);
            // 
            // buttonSalin
            // 
            this.buttonSalin.Location = new System.Drawing.Point(340, 225);
            this.buttonSalin.Name = "buttonSalin";
            this.buttonSalin.Size = new System.Drawing.Size(99, 47);
            this.buttonSalin.TabIndex = 8;
            this.buttonSalin.Text = ">";
            this.buttonSalin.UseVisualStyleBackColor = true;
            this.buttonSalin.Click += new System.EventHandler(this.buttonSalin_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(340, 290);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(99, 46);
            this.buttonX.TabIndex = 9;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(344, 373);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(44, 20);
            this.labelFilter.TabIndex = 10;
            this.labelFilter.Text = "Filter";
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(349, 419);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(101, 24);
            this.checkBoxMakanan.TabIndex = 11;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            this.checkBoxMakanan.Click += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(349, 461);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(100, 24);
            this.checkBoxMinuman.TabIndex = 12;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // Formsatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 674);
            this.Controls.Add(this.checkBoxMinuman);
            this.Controls.Add(this.checkBoxMakanan);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonSalin);
            this.Controls.Add(this.listBoxKanan);
            this.Controls.Add(this.listBoxKiri);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.radioButtonMinuman);
            this.Controls.Add(this.radioButtonMakanan);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.textBoxNamaItem);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "Formsatu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.Formsatu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.TextBox textBoxNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBoxKiri;
        private System.Windows.Forms.ListBox listBoxKanan;
        private System.Windows.Forms.Button buttonSalin;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
    }
}

