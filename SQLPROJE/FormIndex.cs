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
    public partial class FormIndex : Form
    {
        Xml x = new Xml();
        SqlConnection cn;
        SqlCommand cmd;
        public FormIndex(Xml x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
               
                    string isletilecekquery = "use " + cmbBoxVeriTabanı.SelectedItem + " " + "SELECT OBJECT_NAME(ips.OBJECT_ID),i.NAME ,ips.index_id,avg_fragmentation_in_percent,page_count FROM sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, 'SAMPLED') ips INNER JOIN sys.indexes i ON(ips.object_id = i.object_id) AND(ips.index_id = i.index_id) AND index_type_desc IN('CLUSTERED INDEX', 'NONCLUSTERED INDEX', 'UNIQUE INDEX') AND avg_fragmentation_in_percent>" + cmbBoxBozulma.SelectedItem + " " + "ORDER BY avg_fragmentation_in_percent DESC";
                    cmd.CommandText = isletilecekquery;
                    cmd.ExecuteNonQuery();
                    cn.Close();

                     cn.Open();
         
                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    dr.Fill(ds2, "SqlTask_Clients");

                dataGridView1.DataSource = ds2.Tables["SqlTask_Clients"];
                cn.Close();

            }
            catch
            {
                MessageBox.Show("VeriTabanı Seçimi Yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(x.XmlOku(3));
            FindDb();
        }
        public void FindDb()
        {
                string query = "SELECT name FROM master.sys.databases where name<>'Program' and name<>'DB_Task_Manager' and name<>'master' and name<>'model'and name<>'msdb' and name<>'tempdb'";
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxVeriTabanı.Items.Add(dr["name"]);
                }
                cn.Close();
            cmbBoxBozulma.Items.Add("5");
            cmbBoxBozulma.Items.Add("10");
            cmbBoxBozulma.Items.Add("20");
            cmbBoxBozulma.Items.Add("40");
            cmbBoxBozulma.Items.Add("60");
            cmbBoxBozulma.Items.Add("70");
            cmbBoxBozulma.Items.Add("80");
            cmbBoxBozulma.Items.Add("90");


            


        }

        private void pictureBoxcikis_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch {}
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
    }
}
