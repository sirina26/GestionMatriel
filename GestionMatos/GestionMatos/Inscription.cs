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

namespace GestionMatos
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();

        private void Inscription_Load(object sender, EventArgs e)
        {

        }
        //btn
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sql.Connect();
                //si il existe dans la base de donnée
                string us = textBox1.Text;
                SqlCommand cmdE = new SqlCommand("select * from [GestionMatosDB].[dbo].[User] Where loginUser='" + us + "'", Sql.Conn);
                SqlDataReader reader = cmdE.ExecuteReader();

                if (reader.HasRows != true)
                {
                    reader.Close();
                    Login l = new Login();
                    string pw = l.Hash(textBox2.Text);
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User] (loginUser, passwordUser) VALUES(@user,'" + pw + "');", Sql.Conn);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);

                    SqlDataReader readert = cmd.ExecuteReader();
                    MessageBox.Show("Utilisateur est bien enregistrer! Vous pouvez vous connecter");
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur existe déjà!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Sql.disconnect();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
    
}
