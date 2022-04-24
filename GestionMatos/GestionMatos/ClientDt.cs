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
    public partial class ClientDt : Form
    {
        public ClientDt()
        {
            InitializeComponent();
        }

        SqlConn Sql = new SqlConn();
        List<DataRow> listClie = new List<DataRow>();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_nom.Text = row.Cells[1].Value.ToString();
                textBox_mail.Text = row.Cells[2].Value.ToString();
                textBox_tel.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception Ex)
            {

            }
        }
            
        public bool Verif()
        {
            string nomCl = textBox_nom.Text;
            string mailCl = textBox_mail.Text;
            string telCl = textBox_tel.Text;
            if (String.IsNullOrEmpty(nomCl))
            {
                errorProvider1.SetError(textBox_nom, "Saisie Nom !");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (String.IsNullOrEmpty(mailCl))
                {
                    errorProvider2.SetError(textBox_mail, "Saisie l'email !");
                    return false;
                }
                else
                {
                    errorProvider2.Clear();
                    if (String.IsNullOrEmpty(telCl))
                    {
                        errorProvider3.SetError(textBox_tel, "Saisie le num de tel");
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

        private void ClientDt_Load(object sender, EventArgs e)
        {
            Sql.Connect();
            string req = "SELECT idClient, nomClient 'Nom de Client', mailClient 'Mail de Client', telClient 'Numéro de téléphone' From Client;";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listClie.Add(dr);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                //idIntervention
                var t = listClie[rowindex][0];

                //dicionaire id Client
                string query = $"update Client set nomClient='{textBox_nom.Text}',mailClient='{textBox_mail.Text}'," +
                $"telClient='{textBox_tel.Text}' where idClient={t};";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                ClientDt_Load(sender, e);
                MessageBox.Show($"'{textBox_nom.Text}' est bien été modifié !");
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                string query = $"INSERT INTO Client VALUES ('{textBox_nom.Text}','{textBox_mail.Text}','{textBox_tel.Text}');";
                Sql.Connect();
                SqlCommand cmd = new SqlCommand(query, Sql.Conn);
                cmd.ExecuteNonQuery();
                Sql.disconnect();
                ClientDt_Load(sender, e);
                MessageBox.Show($"'{textBox_nom.Text}' est bien été ajouté !");
            }
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            var t = listClie[rowindex][0];
            string query = $"Delete from Client where idClient={t};";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            MessageBox.Show("Client supprimer");
            ClientDt_Load(sender, e);
        }

        private void chercher_btn_Click(object sender, EventArgs e)
        {

            if (text_chercher.Text == "")
            {
                ClientDt_Load(sender, e);
                return;
            }
            Sql.Connect();

            //var type = (int)idTypedic.FirstOrDefault(x => x.Value == textBoxChercher.Text).Key;

            string check = "nomClient";

            if (radioButton_nom.Checked)
            {
                check = "nomClient";
            }
            else if (radioButton_mail.Checked)
            {
                check = "mailClient";
            }
            else if (radioButton_nbrtel.Checked)
            {
                check = "telClient";
            }
            string st = text_chercher.Text;
            string req = "SELECT idClient, nomClient 'Nom de Client', mailClient 'Mail de Client', telClient 'Numéro de téléphone' From Client where " + check + " like('" + st + "%');";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            Sql.disconnect();
        }
    }
}
//formborderstyle
