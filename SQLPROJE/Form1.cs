using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace SQLPROJE
{

    public partial class Form1 : Form
    {
        Xml x = new Xml();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x.connectionstringyol = Path.GetFullPath("cstring.xml");

        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            string user = kullaniciadi.Text;
            string pass = sifre.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SIMI68N; Initial Catalog=Program;User Id=sa;Password=bedir123456;");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where kullaniciAdi='" + kullaniciadi.Text + "' AND kullaniciSifre='" + sifre.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarıyla Yapıldı");
                con.Close();
                Form2 f2 = new Form2(x);
                f2.Show();
                this.Opacity=0;
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }
    }
}
