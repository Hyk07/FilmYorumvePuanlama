﻿namespace classProje
{
    partial class AnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(332, 68);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 0;
            button1.Text = "Film Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(469, 68);
            button2.Name = "button2";
            button2.Size = new Size(131, 38);
            button2.TabIndex = 1;
            button2.Text = "Film Listele";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(343, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 36);
            label1.TabIndex = 2;
            label1.Text = "Film Değerlendir";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.HD_wallpaper_film_strip_film_projector;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(620, 334);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}