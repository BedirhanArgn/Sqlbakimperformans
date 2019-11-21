namespace SQLPROJE
{
    partial class FormIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxgeri = new System.Windows.Forms.PictureBox();
            this.pictureBoxcikis = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxVeriTabanı = new System.Windows.Forms.ComboBox();
            this.cmbBoxBozulma = new System.Windows.Forms.ComboBox();
            this.btnReorganize = new System.Windows.Forms.Button();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.btnSorgula);
            this.panel1.Controls.Add(this.btnRebuild);
            this.panel1.Controls.Add(this.btnReorganize);
            this.panel1.Controls.Add(this.cmbBoxBozulma);
            this.panel1.Controls.Add(this.cmbBoxVeriTabanı);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxgeri);
            this.panel1.Controls.Add(this.pictureBoxcikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 180);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "İNDEKS İŞLEMLERİ";
            // 
            // pictureBoxgeri
            // 
            this.pictureBoxgeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxgeri.Image")));
            this.pictureBoxgeri.Location = new System.Drawing.Point(1308, 12);
            this.pictureBoxgeri.Name = "pictureBoxgeri";
            this.pictureBoxgeri.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxgeri.TabIndex = 5;
            this.pictureBoxgeri.TabStop = false;
            this.pictureBoxgeri.Click += new System.EventHandler(this.pictureBoxgeri_Click);
            // 
            // pictureBoxcikis
            // 
            this.pictureBoxcikis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcikis.Image")));
            this.pictureBoxcikis.Location = new System.Drawing.Point(1356, 12);
            this.pictureBoxcikis.Name = "pictureBoxcikis";
            this.pictureBoxcikis.Size = new System.Drawing.Size(33, 27);
            this.pictureBoxcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxcikis.TabIndex = 4;
            this.pictureBoxcikis.TabStop = false;
            this.pictureBoxcikis.Click += new System.EventHandler(this.pictureBoxcikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veri Tabanı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bozulma Yüzdesi:";
            // 
            // cmbBoxVeriTabanı
            // 
            this.cmbBoxVeriTabanı.FormattingEnabled = true;
            this.cmbBoxVeriTabanı.Location = new System.Drawing.Point(207, 97);
            this.cmbBoxVeriTabanı.Name = "cmbBoxVeriTabanı";
            this.cmbBoxVeriTabanı.Size = new System.Drawing.Size(225, 24);
            this.cmbBoxVeriTabanı.TabIndex = 8;
            // 
            // cmbBoxBozulma
            // 
            this.cmbBoxBozulma.FormattingEnabled = true;
            this.cmbBoxBozulma.Location = new System.Drawing.Point(207, 142);
            this.cmbBoxBozulma.Name = "cmbBoxBozulma";
            this.cmbBoxBozulma.Size = new System.Drawing.Size(225, 24);
            this.cmbBoxBozulma.TabIndex = 9;
            // 
            // btnReorganize
            // 
            this.btnReorganize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnReorganize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReorganize.ForeColor = System.Drawing.Color.White;
            this.btnReorganize.Location = new System.Drawing.Point(841, 97);
            this.btnReorganize.Name = "btnReorganize";
            this.btnReorganize.Size = new System.Drawing.Size(176, 52);
            this.btnReorganize.TabIndex = 10;
            this.btnReorganize.Text = "REORGANIZE";
            this.btnReorganize.UseVisualStyleBackColor = false;
            // 
            // btnRebuild
            // 
            this.btnRebuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnRebuild.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRebuild.ForeColor = System.Drawing.Color.White;
            this.btnRebuild.Location = new System.Drawing.Point(646, 97);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(158, 52);
            this.btnRebuild.TabIndex = 11;
            this.btnRebuild.Text = "REBUILD";
            this.btnRebuild.UseVisualStyleBackColor = false;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSorgula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.Color.White;
            this.btnSorgula.Location = new System.Drawing.Point(459, 97);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(158, 52);
            this.btnSorgula.TabIndex = 12;
            this.btnSorgula.Text = "SORGULA";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 606);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 786);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIndex";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.Button btnReorganize;
        private System.Windows.Forms.ComboBox cmbBoxBozulma;
        private System.Windows.Forms.ComboBox cmbBoxVeriTabanı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxgeri;
        private System.Windows.Forms.PictureBox pictureBoxcikis;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}