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
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }
        SqlConn Sql = new SqlConn();
        List<DataRow> ty = new List<DataRow>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_nom.Text = row.Cells[1].Value.ToString();
                textBox_nbr.Text = row.Cells[2].Value.ToString();               
            }
            catch (Exception uue)
            { }
        }

        private void Type_Load(object sender, EventArgs e)
        {
            Sql.Connect();
            string req = "SELECT idType, nomType 'Nom de type de materiel' , MTBFMat 'Nombre de produit' FROM typeMateriel LEFT JOIN Materiel ON typeMateriel.idType = Materiel.id_TypeMat";
            
            
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ty.Add(dr);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            Sql.disconnect();
            ///
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            //idmateriel
            var t = ty[rowindex][0];
            string query = $"update typeMateriel set nomType = '{textBox_nom.Text}' where idType = {t} update Materiel set MTBFMat ={textBox_nbr.Text} where id_TypeMat = {t} ;";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            MessageBox.Show("Type est bien Modifier !");
            Type_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
