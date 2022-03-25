using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace GestionMatos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sql.Connect();
                string pw = this.Hash(textBox2.Text);
                SqlCommand cmd = new SqlCommand("select * from [GestionMatosDB].[dbo].[User] Where loginUser=@user and passwordUser='"+pw+"'", Sql.Conn);
                //SqlCommand cmd = new SqlCommand("select * from [GestionMatosDB].[dbo].[User] Where loginUser=@user and passwordUser=@pw", Sql.Conn);
                cmd.Parameters.AddWithValue("@user", textBox1.Text); 
                //cmd.Parameters.AddWithValue(this.Hash("@pw"), textBox2.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    MessageBox.Show("Vous êtes connecté");
                    this.Hide();
                    var p = new Principale();
                    p.Show();
                }
                else
                    MessageBox.Show("Utilisateur ou mot de passe incorrecte!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Sql.disconnect();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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

        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
