using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        
        SqlConn Sql = new SqlConn();
        void FillListBox()
        {
            listBox1.Items.Clear();
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("select * from Client", Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(string.Format("{0} | {1} \t {2}", reader["idClient"], reader["nomClient"], reader["mailClient"]));
            }
            
            Sql.disconnect();
        }
        private void Clients_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        void lastItem()
        {
            if (listBox1.SelectedItem == null)
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastItem();
            string selected = ((ListBox)sender).SelectedItem.ToString();
            string[] s = selected.Split('|');
            int ss = Convert.ToInt32(s[0]);

            string query = $"select * from Client where idClient={ss}";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                reader.Read();
                textBox1.Text = reader["nomClient"].ToString();
                textBox2.Text = reader["mailClient"].ToString();
                textBox3.Text = reader["telClient"].ToString();
                textBox4.Text = reader["idClient"].ToString();
            }
            Sql.disconnect();
        }
        bool Verif()
        {
            string nomCl = textBox1.Text;
            string mailCl = textBox2.Text;
            string telCl = textBox3.Text;
            if (String.IsNullOrEmpty(nomCl))
            { 
                errorProvider1.SetError(textBox1, "Saisie Nom !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (String.IsNullOrEmpty(mailCl))
                {                    
                    errorProvider2.SetError(textBox2, "Saisie l'email !");
                    return false;
                }
                else
                {
                    errorProvider2.Clear();
                    if (String.IsNullOrEmpty(telCl)) 
                    {
                        errorProvider3.SetError(textBox3, "Saisie le num de tel");
                        return false;
                    }
                    else
                    {
                        errorProvider3.Clear();
                        return true;
                    }
                    
                }
            }
        }

        //ajouter btn
        private void button1_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                string query = $"INSERT INTO Client VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}');";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListBox();
                MessageBox.Show("Client bien ajouté !", "Ajouter");
            }

        }

        private void listBox_SelectedIndexDelate(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Selectionnez un Client");
                return;
            }
            if (Verif())
            {
                string query = $"update Client set nomClient='{textBox1.Text}',mailClient='{textBox2.Text}'," +
                $"telClient='{textBox3.Text}' where idClient='{textBox4.Text}';";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListBox();
                MessageBox.Show("Client bien modifié !", "Modifier");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Selectionnez un Client");
                return;
            }
            if (Verif())
            {
                string query = $"delete c from Client where idClient='{textBox4.Text}';";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListBox();
                MessageBox.Show("Client bien supprimer !", "Supprimer");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//formborderstyle