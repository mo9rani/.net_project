using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace mini_project
{
    public partial class afficher : Form
    {

        SqlConnection cn = new SqlConnection();

        public afficher()
        {
            InitializeComponent();
        }

        private void afficher_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\project_\\mini_project\\mini_project\\DB.mdf\";Integrated Security=True;User Instance=True";

            try
            {
                cn.Open();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






            String req = "select * from vetement";
            SqlDataAdapter a = new SqlDataAdapter(req, cn);
            DataSet b = new DataSet();
            a.Fill(b, "vetement");
            gred.DataSource = b.Tables["vetement"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin adm = new admin();
            this.Close();
            adm.Show();
        }

        private void gred_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
