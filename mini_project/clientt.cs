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
    public partial class clientt : Form
    {
        SqlConnection cn = new SqlConnection();
        int c;
        public clientt()
        {
            InitializeComponent();
        }

        private void clientt_Load(object sender, EventArgs e)
        {
             acceuil accv = new acceuil();
           c=accv.functt();
           cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\project_\\mini_project\\mini_project\\DB.mdf\";Integrated Security=True;User Instance=True";

           try
           {
               cn.Open();


           }

           catch (Exception ex)
           {

               MessageBox.Show(ex.Message);
           }






           String req = "select pseudo,nom,prenom,solde from clients where id = " + c + ";";
           SqlDataAdapter a = new SqlDataAdapter(req, cn);
           DataSet b = new DataSet();
           a.Fill(b, "clients");
           gredclient.DataSource = b.Tables["clients"];
            
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil gg = new acceuil();
            this.Close();
            gg.Show();
        }

       
    }
}
