namespace SQLPROJE
{
    partial class FormBoyut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoyut));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxcikis = new System.Windows.Forms.PictureBox();
            this.pictureBoxgeri = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShrink = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbBoxVeriTabanı = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.cmbBoxVeriTabanı);
            this.panel2.Controls.Add(this.btnShrink);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBoxcikis);
            this.panel2.Controls.Add(this.pictureBoxgeri);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 144);
            this.panel2.TabIndex = 5;
            // 
            // pictureBoxcikis
            // 
            this.pictureBoxcikis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcikis.Image")));
            this.pictureBoxcikis.Location = new System.Drawing.Point(883, 25);
            this.pictureBoxcikis.Name = "pictureBoxcikis";
            this.pictureBoxcikis.Size = new System.Drawing.Size(33, 27);
            this.pictureBoxcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxcikis.TabIndex = 4;
            this.pictureBoxcikis.TabStop = false;
            this.pictureBoxcikis.Click += new System.EventHandler(this.pictureBoxcikis_Click);
            // 
            // pictureBoxgeri
            // 
            this.pictureBoxgeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxgeri.Image")));
            this.pictureBoxgeri.Location = new System.Drawing.Point(825, 25);
            this.pictureBoxgeri.Name = "pictureBoxgeri";
            this.pictureBoxgeri.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxgeri.TabIndex = 5;
            this.pictureBoxgeri.TabStop = false;
            this.pictureBoxgeri.Click += new System.EventHandler(this.pictureBoxgeri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "VERİ TABANI BOYUT KÜÇÜLTME";
            // 
            // btnShrink
            // 
            this.btnShrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnShrink.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShrink.ForeColor = System.Drawing.Color.White;
            this.btnShrink.Location = new System.Drawing.Point(447, 84);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(239, 44);
            this.btnShrink.TabIndex = 11;
            this.btnShrink.Text = "BOYUT KÜÇÜLTME";
            this.btnShrink.UseVisualStyleBackColor = false;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 462);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbBoxVeriTabanı
            // 
            this.cmbBoxVeriTabanı.FormattingEnabled = true;
            this.cmbBoxVeriTabanı.Location = new System.Drawing.Point(188, 97);
            this.cmbBoxVeriTabanı.Name = "cmbBoxVeriTabanı";
            this.cmbBoxVeriTabanı.Size = new System.Drawing.Size(225, 24);
            this.cmbBoxVeriTabanı.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Veri Tabanı Adı:";
            // 
            // FormBoyut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBoyut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBoyut";
            this.Load += new System.EventHandler(this.FormBoyut_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxcikis;
        private System.Windows.Forms.PictureBox pictureBoxgeri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBoxVeriTabanı;
        private System.Windows.Forms.Label label2;
    }
}