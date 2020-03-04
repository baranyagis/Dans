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

namespace Dans
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=.; database=AralikIskurDb; uid=sa; pwd=123; MultipleActiveResultSets=True;");
        
        public Form1()
        {
            InitializeComponent();
            con.Open();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvEslesme.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT KisiAd FROM Ogrenciler order by newid()", con);
            SqlCommand cmd2 = new SqlCommand("SELECT KisiAd FROM Ogrenciler order by newid() desc", con);

            var dr1 = cmd.ExecuteReader();
            var dr2 = cmd2.ExecuteReader();

            while(dr1.Read())
            {
                dr2.Read();
                dgvEslesme.Rows.Add(dr1["KisiAd"], dr2["KisiAd"]);
            }
            dr1.Close();
            dr2.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
