namespace classProje
{
    partial class FilmListele
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
            dataGridView1 = new DataGridView();
            label7 = new Label();
            txtId = new TextBox();
            txtPuan = new TextBox();
            cbxTur = new ComboBox();
            txtYorum = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            txtFilmad = new TextBox();
            txtYil = new TextBox();
            txtYonetmen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(936, 447);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlText;
            label7.ForeColor = Color.Cornsilk;
            label7.Location = new Point(3, 26);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 32;
            label7.Text = "id:";
            label7.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(181, 27);
            txtId.TabIndex = 31;
            txtId.Visible = false;
            // 
            // txtPuan
            // 
            txtPuan.Location = new Point(89, 188);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(181, 27);
            txtPuan.TabIndex = 30;
            // 
            // cbxTur
            // 
            cbxTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTur.FormattingEnabled = true;
            cbxTur.Items.AddRange(new object[] { "Aksiyon", "Macera", "Komedi", "Bilim Kurgu", "Korku", "Romantizm" });
            cbxTur.Location = new Point(89, 155);
            cbxTur.Name = "cbxTur";
            cbxTur.Size = new Size(181, 28);
            cbxTur.TabIndex = 29;
            // 
            // txtYorum
            // 
            txtYorum.Location = new Point(89, 224);
            txtYorum.Name = "txtYorum";
            txtYorum.Size = new Size(181, 175);
            txtYorum.TabIndex = 28;
            txtYorum.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlText;
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(3, 224);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 27;
            label6.Text = "Yorum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlText;
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(3, 59);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 26;
            label5.Text = "Film Adı:";
            // 
            // txtFilmad
            // 
            txtFilmad.Location = new Point(89, 56);
            txtFilmad.Name = "txtFilmad";
            txtFilmad.Size = new Size(181, 27);
            txtFilmad.TabIndex = 25;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(89, 122);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(181, 27);
            txtYil.TabIndex = 24;
            // 
            // txtYonetmen
            // 
            txtYonetmen.Location = new Point(89, 89);
            txtYonetmen.Name = "txtYonetmen";
            txtYonetmen.Size = new Size(181, 27);
            txtYonetmen.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlText;
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(3, 191);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 22;
            label4.Text = "Puan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlText;
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(3, 158);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 21;
            label3.Text = "Tür:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlText;
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(3, 125);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 20;
            label2.Text = "Yayın yılı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(3, 92);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 19;
            label1.Text = "Yönetmen:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.Desktop;
            btnGuncelle.ForeColor = Color.Cornsilk;
            btnGuncelle.Location = new Point(189, 405);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(81, 32);
            btnGuncelle.TabIndex = 18;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.Desktop;
            btnSil.ForeColor = Color.Cornsilk;
            btnSil.Location = new Point(89, 405);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(81, 32);
            btnSil.TabIndex = 33;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // FilmListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1234, 471);
            Controls.Add(btnSil);
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
            Controls.Add(btnGuncelle);
            Controls.Add(dataGridView1);
            Name = "FilmListele";
            Text = "FilmListele";
            Load += FilmListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label7;
        private TextBox txtId;
        private TextBox txtPuan;
        private ComboBox cbxTur;
        private RichTextBox txtYorum;
        private Label label6;
        private Label label5;
        private TextBox txtFilmad;
        private TextBox txtYil;
        private TextBox txtYonetmen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuncelle;
        private Button btnSil;
    }
}