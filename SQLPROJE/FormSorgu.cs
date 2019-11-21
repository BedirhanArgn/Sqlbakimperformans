using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLPROJE
{
    public partial class FormSorgu : Form
    {
        Xml x = new Xml();
        SqlConnection cn;
        SqlCommand cmd;
        public FormSorgu(Xml x)
        {
            InitializeComponent();
            this.x = x;
        }

        private void datagridSorgu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSorgu_Load(object sender, EventArgs e)
        {
            try
            {
                x.connectionstring = x.XmlOku(1);
                cn = new SqlConnection(x.connectionstring);
                timer1.Interval = 1000;
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Veri Tabanı ismi boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("sp_executiontime", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "SqlTask");
            datagridSorgu.DataSource = ds.Tables["SqlTask"];
            datagridSorgu.Columns[4].Width = 530;
            datagridSorgu.Columns[3].Width = 70;
            cn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxgeri_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2 = new Form2(x);
                frm2.Show();
                this.Close();
            }
            catch { }

        }

        private void pictureBoxcikis_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
