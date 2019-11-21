namespace SQLPROJE
{
    partial class FormSorgu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSorgu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxgeri = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxcikis = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagridSorgu = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.pictureBoxgeri);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBoxcikis);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1480, 68);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBoxgeri
            // 
            this.pictureBoxgeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxgeri.Image")));
            this.pictureBoxgeri.Location = new System.Drawing.Point(1371, 18);
            this.pictureBoxgeri.Name = "pictureBoxgeri";
            this.pictureBoxgeri.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxgeri.TabIndex = 3;
            this.pictureBoxgeri.TabStop = false;
            this.pictureBoxgeri.Click += new System.EventHandler(this.pictureBoxgeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÇALIŞAN SORGULAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxcikis
            // 
            this.pictureBoxcikis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcikis.Image")));
            this.pictureBoxcikis.Location = new System.Drawing.Point(1419, 18);
            this.pictureBoxcikis.Name = "pictureBoxcikis";
            this.pictureBoxcikis.Size = new System.Drawing.Size(33, 27);
            this.pictureBoxcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxcikis.TabIndex = 1;
            this.pictureBoxcikis.TabStop = false;
            this.pictureBoxcikis.Click += new System.EventHandler(this.pictureBoxcikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // datagridSorgu
            // 
            this.datagridSorgu.BackgroundColor = System.Drawing.Color.White;
            this.datagridSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSorgu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridSorgu.Location = new System.Drawing.Point(0, 68);
            this.datagridSorgu.Name = "datagridSorgu";
            this.datagridSorgu.RowTemplate.Height = 24;
            this.datagridSorgu.Size = new System.Drawing.Size(1480, 789);
            this.datagridSorgu.TabIndex = 1;
            this.datagridSorgu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridSorgu_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 857);
            this.Controls.Add(this.datagridSorgu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSorgu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormSorgu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSorgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxcikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagridSorgu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxgeri;
    }
}