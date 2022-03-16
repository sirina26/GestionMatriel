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
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("select * from Site", Sql.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
        }
    }
}
