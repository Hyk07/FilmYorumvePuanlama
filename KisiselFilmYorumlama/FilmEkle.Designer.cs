namespace classProje
{
    partial class FilmEkle
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
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtYonetmen = new TextBox();
            txtYil = new TextBox();
            txtFilmad = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtYorum = new RichTextBox();
            cbxTur = new ComboBox();
            txtPuan = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ControlText;
            btnEkle.ForeColor = Color.Cornsilk;
            btnEkle.Location = new Point(195, 454);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 32);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(22, 141);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Yönetmen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(22, 174);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Yayın yılı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(22, 207);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 3;
            label3.Text = "Tür:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(22, 240);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Puan:";
            // 
            // txtYonetmen
            // 
            txtYonetmen.BackColor = SystemColors.Window;
            txtYonetmen.Location = new Point(108, 138);
            txtYonetmen.Name = "txtYonetmen";
            txtYonetmen.Size = new Size(181, 27);
            txtYonetmen.TabIndex = 5;
            // 
            // txtYil
            // 
            txtYil.BackColor = SystemColors.Window;
            txtYil.Location = new Point(108, 171);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(181, 27);
            txtYil.TabIndex = 6;
            // 
            // txtFilmad
            // 
            txtFilmad.BackColor = SystemColors.Window;
            txtFilmad.Location = new Point(108, 105);
            txtFilmad.Name = "txtFilmad";
            txtFilmad.Size = new Size(181, 27);
            txtFilmad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(22, 108);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Film Adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(22, 273);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 11;
            label6.Text = "Yorum:";
            // 
            // txtYorum
            // 
            txtYorum.BackColor = SystemColors.Window;
            txtYorum.Location = new Point(108, 273);
            txtYorum.Name = "txtYorum";
            txtYorum.Size = new Size(181, 175);
            txtYorum.TabIndex = 13;
            txtYorum.Text = "";
            // 
            // cbxTur
            // 
            cbxTur.BackColor = SystemColors.Window;
            cbxTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTur.FormattingEnabled = true;
            cbxTur.Items.AddRange(new object[] { "Aksiyon", "Macera", "Komedi", "Bilim Kurgu", "Korku", "Romantizm" });
            cbxTur.Location = new Point(108, 204);
            cbxTur.Name = "cbxTur";
            cbxTur.Size = new Size(181, 28);
            cbxTur.TabIndex = 14;
            // 
            // txtPuan
            // 
            txtPuan.BackColor = SystemColors.Window;
            txtPuan.Location = new Point(108, 237);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(181, 27);
            txtPuan.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Cornsilk;
            label7.Location = new Point(22, 75);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 17;
            label7.Text = "id:";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Location = new Point(108, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(181, 27);
            txtId.TabIndex = 16;
            txtId.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Cornsilk;
            label8.Location = new Point(92, 9);
            label8.Name = "label8";
            label8.Size = new Size(151, 39);
            label8.TabIndex = 18;
            label8.Text = "Film Ekle";
            // 
            // FilmEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = Properties.Resources.desktop_wallpaper_spiderman_amazing_cool_black_dark_thumbnail;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(303, 498);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(txtPuan);
            Controls.Add(cbxTur);
            Controls.Add(txtYorum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtFilmad);
            Controls.Add(txtYil);
            Controls.Add(txtYonetmen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Name = "FilmEkle";
            Text = "FilmEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtYonetmen;
        private TextBox txtYil;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtFilmad;
        private Label label5;
        private Label label6;
        private RichTextBox txtYorum;
        private ComboBox cbxTur;
        private TextBox txtPuan;
        private Label label7;
        private TextBox txtId;
        private Label label8;
    }
}