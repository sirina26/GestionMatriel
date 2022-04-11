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
    public partial class Intervention : Form
    {
        public Intervention()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        IDictionary<int, string> idmatdic = new Dictionary<int, string>();
        IDictionary<int, string> idcldic = new Dictionary<int, string>();
        List<DataRow> inter = new List<DataRow>();

        SqlConn Sql = new SqlConn();
        private void Intervention_Load(object sender, EventArgs e)
        {
        
            Sql.Connect();
            string req = "SELECT idInter, datePlanifie, nomMat, Etat, nomClient, Intervention.idMat, Intervention.id_Client,Commentaire FROM Intervention LEFT JOIN Materiel ON Intervention.idMat = Materiel.idMat LEFT JOIN Client ON Intervention.id_Client = Client.idClient";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                inter.Add(dr);
            }
           
            dataGridView2.DataSource = dt;
            //dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;//idMAt
            dataGridView2.Columns[6].Visible = false;
            //checkbox
            mat.Checked.ToString();
            ///comboMateriel
            string query = "Select idMat, nomMat From Materiel";
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.CommandText = query;
            SqlDataReader drd = cmd.ExecuteReader();

            while (drd.Read())
            {
                comboMateriel.Items.Add(drd["nomMat"]).ToString();
                var myk = idmatdic.FirstOrDefault(x => x.Value == drd["nomMat"].ToString()).Key;
                //if contient idmatdic
                if (!(idmatdic.ContainsKey(myk)))
                {
                    idmatdic.Add((int)drd["idMat"], drd["nomMat"].ToString());
                }
            }
            comboMateriel.SelectedIndex= 1;
           
            Sql.disconnect();

            //Etat
            comboEtat.SelectedIndex = 1;

            //comboclient
            Sql.Connect();
            string queryc = "Select idClient, nomClient From Client";
            SqlCommand cmdc = new SqlCommand(queryc, Sql.Conn);
            cmdc.CommandText = queryc;
            SqlDataReader drdc = cmdc.ExecuteReader();

            while (drdc.Read())
            {
                comboClient.Items.Add(drdc["nomClient"]).ToString();
                var mykc = idcldic.FirstOrDefault(x => x.Value == drdc["nomClient"].ToString()).Key;

                if (!(idcldic.ContainsKey(mykc)))
                {
                    idcldic.Add((int)drdc["idClient"], drdc["nomClient"].ToString());
                }
            }
            comboClient.SelectedIndex = 1;
            Sql.disconnect();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //recuperer id mater
            string dicmat = comboMateriel.Text;
            string diccli = comboClient.Text;
            var myk = idmatdic.FirstOrDefault(x => x.Value == dicmat).Key;
            var mykc = idcldic.FirstOrDefault(x => x.Value == diccli).Key;

            int idma = (int)myk;
            int idc = (int)mykc;
            string query = $"INSERT INTO Intervention VALUES ('{dateIntr.Value}','{textComment.Text}',{myk},'{mykc}','{comboEtat.Text}');";
            Sql.Connect();
            SqlCommand cmd = new SqlCommand(query, Sql.Conn);
            cmd.ExecuteNonQuery();
            Sql.disconnect();
            Intervention_Load(sender, e);
            MessageBox.Show("Intervention bien ajouté !", "Ajouter");
        }

        private void comboMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                dateIntr.Text = row.Cells[1].Value.ToString();
                comboMateriel.Text = row.Cells[2].Value.ToString();
                textComment.Text = row.Cells[7].Value.ToString();
                comboClient.Text = row.Cells[4].Value.ToString();
                comboEtat.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textCher.Text == "")
            {
                Intervention_Load(sender, e);
                return;
            }
            Sql.Connect();

            string check = "nomMat";

            if (clie.Checked)
            {
                check = "nomClient";
            }
            else if (etat.Checked)
            {
                check = "Etat";
            }
            string st = textCher.Text;
            string req = "SELECT idInter, datePlanifie, nomMat, Etat, nomClient, Intervention.idMat, Intervention.id_Client,Commentaire FROM Intervention LEFT JOIN Materiel ON Intervention.idMat = Materiel.idMat LEFT JOIN Client ON Intervention.id_Client = Client.idClient where " + check +" like('"+ st+"%');";
            SqlDataAdapter sda = new SqlDataAdapter(req, Sql.Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView2.DataSource = dt;
            Sql.disconnect();

        }
       
        private void mat_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        //Modifier
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            //idIntervention
            var t = inter[rowindex][0];

        }
    }
}
