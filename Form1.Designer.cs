namespace Kutuphane_Otomasyonu
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewKitaplar = new DataGridView();
            numericUpDownSayfaSayisi = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            textBoxYazarSoyadi = new TextBox();
            label2 = new Label();
            textBoxYazarAdi = new TextBox();
            label1 = new Label();
            textBoxKitapAdi = new TextBox();
            buttonKitapEkle = new Button();
            tabPage2 = new TabPage();
            dataGridViewOduncAlanlar = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            listBoxKitaplar = new ListBox();
            buttonOduncVer = new Button();
            listBoxUyeler = new ListBox();
            tabPage3 = new TabPage();
            buttonIadeAl = new Button();
            dgvTakip = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSayfaSayisi).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOduncAlanlar).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTakip).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1377, 574);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 24, 0);
            tabPage1.Controls.Add(dataGridViewKitaplar);
            tabPage1.Controls.Add(numericUpDownSayfaSayisi);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxYazarSoyadi);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxYazarAdi);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxKitapAdi);
            tabPage1.Controls.Add(buttonKitapEkle);
            tabPage1.Font = new Font("Zalando Sans Expanded", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(1369, 542);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Uye ve Kitap Yonetimi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Location = new Point(354, 30);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.Size = new Size(996, 489);
            dataGridViewKitaplar.TabIndex = 12;
            // 
            // numericUpDownSayfaSayisi
            // 
            numericUpDownSayfaSayisi.Location = new Point(13, 221);
            numericUpDownSayfaSayisi.Name = "numericUpDownSayfaSayisi";
            numericUpDownSayfaSayisi.Size = new Size(313, 22);
            numericUpDownSayfaSayisi.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Zalando Sans Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(10, 194);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 10;
            label4.Text = "Sayfa Sayisi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Zalando Sans Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(10, 126);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 8;
            label3.Text = "Yazar Soyadi";
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Location = new Point(10, 152);
            textBoxYazarSoyadi.Margin = new Padding(5, 4, 5, 4);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(316, 22);
            textBoxYazarSoyadi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zalando Sans Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(10, 62);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 6;
            label2.Text = "Yazar Adi";
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(10, 88);
            textBoxYazarAdi.Margin = new Padding(5, 4, 5, 4);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(316, 22);
            textBoxYazarAdi.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zalando Sans Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(10, 4);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 4;
            label1.Text = "Kitap Adi";
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(10, 30);
            textBoxKitapAdi.Margin = new Padding(5, 4, 5, 4);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(316, 22);
            textBoxKitapAdi.TabIndex = 1;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Font = new Font("Zalando Sans Expanded", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonKitapEkle.ForeColor = SystemColors.ActiveCaptionText;
            buttonKitapEkle.Location = new Point(10, 261);
            buttonKitapEkle.Margin = new Padding(5, 4, 5, 4);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(129, 29);
            buttonKitapEkle.TabIndex = 2;
            buttonKitapEkle.Text = "Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 24, 0);
            tabPage2.Controls.Add(dataGridViewOduncAlanlar);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(listBoxKitaplar);
            tabPage2.Controls.Add(buttonOduncVer);
            tabPage2.Controls.Add(listBoxUyeler);
            tabPage2.Font = new Font("Zalando Sans Expanded", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5, 4, 5, 4);
            tabPage2.Size = new Size(1369, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Odunc Verme ";
            // 
            // dataGridViewOduncAlanlar
            // 
            dataGridViewOduncAlanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOduncAlanlar.Location = new Point(620, 42);
            dataGridViewOduncAlanlar.Name = "dataGridViewOduncAlanlar";
            dataGridViewOduncAlanlar.Size = new Size(741, 474);
            dataGridViewOduncAlanlar.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Zalando Sans Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(10, 15);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 6;
            label6.Text = "Uyeler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Zalando Sans Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(419, 15);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 5;
            label5.Text = "Kitaplar";
            // 
            // listBoxKitaplar
            // 
            listBoxKitaplar.FormattingEnabled = true;
            listBoxKitaplar.Location = new Point(419, 42);
            listBoxKitaplar.Name = "listBoxKitaplar";
            listBoxKitaplar.Size = new Size(186, 274);
            listBoxKitaplar.TabIndex = 2;
            // 
            // buttonOduncVer
            // 
            buttonOduncVer.ForeColor = SystemColors.ActiveCaptionText;
            buttonOduncVer.Location = new Point(202, 42);
            buttonOduncVer.Name = "buttonOduncVer";
            buttonOduncVer.Size = new Size(211, 37);
            buttonOduncVer.TabIndex = 1;
            buttonOduncVer.Text = "Odunc Ver";
            buttonOduncVer.UseVisualStyleBackColor = true;
            buttonOduncVer.Click += buttonOduncVer_Click;
            // 
            // listBoxUyeler
            // 
            listBoxUyeler.FormattingEnabled = true;
            listBoxUyeler.Location = new Point(10, 42);
            listBoxUyeler.Name = "listBoxUyeler";
            listBoxUyeler.Size = new Size(186, 274);
            listBoxUyeler.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(0, 24, 0);
            tabPage3.Controls.Add(buttonIadeAl);
            tabPage3.Controls.Add(dgvTakip);
            tabPage3.Font = new Font("Zalando Sans Expanded", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Margin = new Padding(5, 4, 5, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(5, 4, 5, 4);
            tabPage3.Size = new Size(1369, 542);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Takip ve Iade Ekrani";
            // 
            // buttonIadeAl
            // 
            buttonIadeAl.ForeColor = SystemColors.ActiveCaptionText;
            buttonIadeAl.Location = new Point(8, 20);
            buttonIadeAl.Name = "buttonIadeAl";
            buttonIadeAl.Size = new Size(409, 95);
            buttonIadeAl.TabIndex = 14;
            buttonIadeAl.Text = "Kitabı İade Al";
            buttonIadeAl.UseVisualStyleBackColor = true;
            buttonIadeAl.Click += buttonIadeAl_Click;
            // 
            // dgvTakip
            // 
            dgvTakip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTakip.Location = new Point(423, 20);
            dgvTakip.Name = "dgvTakip";
            dgvTakip.Size = new Size(925, 515);
            dgvTakip.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 579);
            Controls.Add(tabControl1);
            Font = new Font("Zalando Sans Expanded Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.Control;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Kutuphane Otomasyonu";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSayfaSayisi).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOduncAlanlar).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTakip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private TextBox textBoxKitapAdi;
        private Button buttonKitapEkle;
        private Label label4;
        private Label label3;
        private TextBox textBoxYazarSoyadi;
        private Label label2;
        private TextBox textBoxYazarAdi;
        private NumericUpDown numericUpDownSayfaSayisi;
        private DataGridView dataGridViewKitaplar;
        private ListBox listBoxKitaplar;
        private Button buttonOduncVer;
        private ListBox listBoxUyeler;
        private Label label6;
        private Label label5;
        private DataGridView dataGridViewOduncAlanlar;
        private DataGridView dgvTakip;
        private Button buttonIadeAl;
    }
}
