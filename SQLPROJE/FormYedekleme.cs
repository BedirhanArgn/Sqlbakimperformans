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
    public partial class FormYedekleme : Form
    {
        Xml x = new Xml();
        SqlCommand cmd;
        SqlConnection cn;
        public FormYedekleme(Xml x)
        {
            InitializeComponent();
             this.x=x;
        }
        private void btnYedekleme_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxVeriTabanı.SelectedItem != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "|*.bak";
                    saveFileDialog.ShowDialog();
                    string path = saveFileDialog.FileName;
                    string backup = "BACKUP DATABASE " + cmbBoxVeriTabanı.SelectedItem + " TO DISK='" + path + "'";
                        cn.Open();
                    cmd = new SqlCommand(backup,cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Veri Tabanını Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            { }
        }

        private void FormYedekleme_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(x.XmlOku(3));
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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2 = new Form2(x);
                frm2.Show();
                this.Close();
            }
            catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }
    }
}
