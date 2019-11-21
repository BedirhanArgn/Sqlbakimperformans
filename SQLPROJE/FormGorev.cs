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
using System.Threading;
namespace SQLPROJE
{
    public partial class FormGorev : Form
    {
        Xml x = new Xml();
        SqlConnection cn;
        public FormGorev(Xml x)
        {
          InitializeComponent();
            this.x = x;
        }

        private void FormGorev_Load(object sender, EventArgs e)
        {


            timer1.Start();

        }

        private void pictureBoxcikis_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            cn = new SqlConnection(x.XmlOku(2));
            SqlCommand cmd2 = new SqlCommand("select * from SqlTask_Clients", cn);
            SqlDataAdapter dr2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            dr2.Fill(ds2, "SqlTask_Clients");
        
            dataGridView1.DataSource = ds2.Tables["SqlTask_Clients"];



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Form2 frm2 = new Form2(x);
            frm2.Show();
            this.Close();


        }

        private void pictureBoxcikis_Click_1(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void pictureBoxgeri_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2 = new Form2(x);
                frm2.Show();
                this.Close();
            }
            catch { }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
