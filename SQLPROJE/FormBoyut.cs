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
    public partial class FormBoyut : Form
    {
        Xml x = new Xml();
        SqlConnection cn;
        SqlCommand cmd;
        public FormBoyut(Xml x)
        {
            this.x = x;
            InitializeComponent();
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

        private void FormBoyut_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(x.XmlOku(3));
            cn.Open();
            getsize();
            cn.Close();
            logicalNameRead();

        }
        public void getsize()
        {
            cmd = new SqlCommand("sp_sizeofdb", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            dr.Fill(ds2, "SqlTask_Clients");

            dataGridView1.DataSource = ds2.Tables["SqlTask_Clients"];

            dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void logicalNameRead()
        {
            cn.Open();
            cmd = new SqlCommand("sp_logicalnamedb",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxVeriTabanı.Items.Add(dr["LogicalName"]);
            }
            cn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxVeriTabanı.SelectedItem != null)
                {
                    string query = "DBCC SHRINKFILE (" + cmbBoxVeriTabanı.SelectedItem + ", 1);";
                    Console.WriteLine(query);
                    cn.Open();
                    getsize();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Database Seçiniz");
                }
            }
            catch
            {}







        }
    }
}
