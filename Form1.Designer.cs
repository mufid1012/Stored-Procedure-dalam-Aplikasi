namespace CrudSederhana
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(113, 30);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(200, 20);
            this.txtNIM.TabIndex = 0;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(113, 70);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(113, 150);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(200, 20);
            this.txtTelepon.TabIndex = 3;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(113, 190);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 20);
            this.txtAlamat.TabIndex = 4;
            // 
            // lblNIM
            // 
            this.lblNIM.Location = new System.Drawing.Point(33, 30);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(100, 23);
            this.lblNIM.TabIndex = 5;
            this.lblNIM.Text = "NIM:";
            // 
            // lblNama
            // 
            this.lblNama.Location = new System.Drawing.Point(33, 70);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(100, 23);
            this.lblNama.TabIndex = 6;
            this.lblNama.Text = "Nama:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(33, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelepon
            // 
            this.lblTelepon.Location = new System.Drawing.Point(33, 150);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(100, 23);
            this.lblTelepon.TabIndex = 8;
            this.lblTelepon.Text = "Telepon:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.Location = new System.Drawing.Point(33, 190);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(100, 23);
            this.lblAlamat.TabIndex = 9;
            this.lblAlamat.Text = "Alamat:";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(68, 222);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(102, 35);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(194, 222);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(102, 35);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(68, 266);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(102, 35);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(194, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 35);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.Refresh);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(68, 307);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(228, 35);
            this.btnImportExcel.TabIndex = 14;
            this.btnImportExcel.Text = "Import Data";
            this.btnImportExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMahasiswa.Location = new System.Drawing.Point(333, 30);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.Size = new System.Drawing.Size(660, 285);
            this.dgvMahasiswa.TabIndex = 15;
            this.dgvMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1025, 358);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.dgvMahasiswa);
            this.Name = "Form1";
            this.Text = "CRUD Mahasiswa + Import Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;

        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.Label lblAlamat;

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnImportExcel;

        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}
