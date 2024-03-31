namespace EntityProject
{
    partial class frmKatmanliMimari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adisoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.chckIsActive = new System.Windows.Forms.CheckBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelID,
            this.Birim,
            this.Adisoyadi,
            this.Telefon,
            this.Adres,
            this.Email,
            this.Tarih,
            this.IsActive,
            this.BirimID});
            this.dataGridView1.Location = new System.Drawing.Point(2, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PersonelID
            // 
            this.PersonelID.DataPropertyName = "PersonelID";
            this.PersonelID.HeaderText = "Personel ID";
            this.PersonelID.Name = "PersonelID";
            // 
            // Birim
            // 
            this.Birim.DataPropertyName = "BirimAdi";
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            // 
            // Adisoyadi
            // 
            this.Adisoyadi.DataPropertyName = "Adisoyadi";
            this.Adisoyadi.HeaderText = "Adı Soyadı";
            this.Adisoyadi.Name = "Adisoyadi";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = false;
            // 
            // BirimID
            // 
            this.BirimID.DataPropertyName = "BirimID";
            this.BirimID.HeaderText = "Birim ID";
            this.BirimID.Name = "BirimID";
            this.BirimID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(146, 9);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(158, 23);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(146, 273);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(93, 23);
            this.txtPersonelID.TabIndex = 2;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adı Soyadı:";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdiSoyadi.Location = new System.Drawing.Point(146, 302);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(210, 23);
            this.txtAdiSoyadi.TabIndex = 2;
            this.txtAdiSoyadi.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birimi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(146, 389);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 23);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(86, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(146, 393);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(210, 67);
            this.txtAdres.TabIndex = 2;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(84, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(146, 466);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(87, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(66, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Durumu:";
            // 
            // cmbBirim
            // 
            this.cmbBirim.DisplayMember = "BirimAdi";
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(146, 332);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(210, 21);
            this.cmbBirim.TabIndex = 3;
            this.cmbBirim.ValueMember = "BirimID";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(146, 364);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(210, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // chckIsActive
            // 
            this.chckIsActive.AccessibleName = "";
            this.chckIsActive.AutoSize = true;
            this.chckIsActive.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chckIsActive.Location = new System.Drawing.Point(146, 244);
            this.chckIsActive.Name = "chckIsActive";
            this.chckIsActive.Size = new System.Drawing.Size(61, 17);
            this.chckIsActive.TabIndex = 5;
            this.chckIsActive.Text = "Aktif Mi";
            this.chckIsActive.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYeni.Location = new System.Drawing.Point(416, 455);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 43);
            this.btnYeni.TabIndex = 6;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKaydet.Location = new System.Drawing.Point(522, 455);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 43);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.BackColor = System.Drawing.Color.Red;
            this.btnSilme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSilme.Location = new System.Drawing.Point(628, 455);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(100, 43);
            this.btnSilme.TabIndex = 6;
            this.btnSilme.Text = "Sil";
            this.btnSilme.UseVisualStyleBackColor = false;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 501);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 25);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // frmKatmanliMimari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 531);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.chckIsActive);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKatmanliMimari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katmanlı Mimari";
            this.Load += new System.EventHandler(this.FrmKatmanliMimari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adisoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.CheckBox chckIsActive;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

