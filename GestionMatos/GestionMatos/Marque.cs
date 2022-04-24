using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Marque : Form
    {
        public Marque()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();
        List<DataRow> marq = new List<DataRow>();

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //idmateriel
            var t = marq[rowindex][0];

            string query = $"update Marque set nomMrq = '{textBoxNom}' where idMat = {t}";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            MessageBox.Show("Marque est bien Modifier !");
            Marque_Load(sender, e);

        }

        private void Marque_Load(object sender, EventArgs e)
        {
            Sql.Connect();
            string req = "SELECT idMrq, nomMrq 'Nom de marque' FROM Marque";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                marq.Add(dr);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void ajouterbtn_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Marque VALUES ('{textBoxNom.Text}');";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            Marque_Load(sender, e);
            MessageBox.Show($"'{textBoxNom.Text}' est bien été ajouté !");
        }

        private void suppbtn_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //idIntervention
            var t = marq[rowindex][0];
            string query = $"Delete from Marque where idMrq={t};";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            MessageBox.Show("Marque est bien supprimer");
            Marque_Load(sender, e);

        }

        private void chercherbtn_Click(object sender, EventArgs e)
        {
            if (textBoxchercher.Text == "")
            {
                Marque_Load(sender, e);
                return;
            }
            Sql.Connect();
            string st = textBoxchercher.Text;
            string req = $"Select * from Marque where nomMrq like('" + st + "%');";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            Sql.disconnect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{ DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBoxNom.Text = row.Cells[1].Value.ToString(); 
            }
            catch(Exception ex)
            {

            }
           
        }
    }
}
