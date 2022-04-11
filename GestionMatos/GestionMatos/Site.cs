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
    public partial class Site : Form
    {
        public Site()
        {
            InitializeComponent();
        }
        List<int> listeId = new List<int>();
        SqlConn Sql = new SqlConn();

        void FillListBox()
        {
            listBox1.Items.Clear();
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("select * from Site", Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(string.Format("{0} | {1} \t {2}", reader["idSite"], reader["nomSite"], reader["departementSite"]));
            }

            Sql.disconnect();
        }

        private void Site_Load_1(object sender, EventArgs e)
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
            string selected = ((ListBox)sender).SelectedItem.ToString();
            //int siri = listeId [listBox1.Items.IndexOf(selected) + 1 ];
            string[] s = selected.Split('|');
            int ss= Convert.ToInt32(s[0]);
            //int ss = listBox1.Items.IndexOf(selected)+1; 
            
            string query = $"select * from Site where idSite='{ss}'";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                reader.Read();                
                textBox5.Text = reader["idSite"].ToString();
                textBox1.Text = reader["nomSite"].ToString();
                textBox2.Text = reader["departementSite"].ToString();
                textBox3.Text = reader["CPSite"].ToString();
                textBox4.Text = reader["adresseSite"].ToString();

            }
            Sql.disconnect();
        }

        bool Verif()
        {
            string nomSi = textBox1.Text;
            string depar = textBox2.Text;
            string cpSi = textBox3.Text;
            string adrSi = textBox4.Text;

            if (String.IsNullOrEmpty(nomSi))
            {
                errorProvider1.SetError(textBox1, "Saisie le nom site !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (String.IsNullOrEmpty(depar))
                {
                    errorProvider2.SetError(textBox2, "Saisie departement !");
                    return false;
                }
                else
                {
                    errorProvider2.Clear();
                    if (String.IsNullOrEmpty(cpSi))
                    {
                        errorProvider3.SetError(textBox3, "Saisie le code postale de site");
                        return false;
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(adrSi))
                        {
                            errorProvider3.SetError(textBox4, "Saisie l'adresse de site");
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
        }
        //Ajouter
        private void button1_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                string query = $"INSERT INTO Site VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}');";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListBox();
                MessageBox.Show("Site bien ajouté !", "Ajouter");
            }
        }
        //Supprimer
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Selectionnez un Site");
                return;
            }
            if (Verif())
            {
                string query = $"delete from Site where idSite={textBox5.Text};";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListBox();
                MessageBox.Show("Site bien supprimer !", "Supprimer");
            }
        }
        //modifier
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Selectionnez un Site");
                return;
            }
            if (Verif())
            {
                string query = $"update Site set nomSite='{textBox1.Text}',departementSite='{textBox2.Text}',CPSite='{textBox3.Text}'," +
                               $"adresseSite='{textBox4.Text}' where idSite='{textBox5.Text}';"; Sql.Connect();
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                FillListBox();
                MessageBox.Show("Site bien modifié !", "Modifier");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
