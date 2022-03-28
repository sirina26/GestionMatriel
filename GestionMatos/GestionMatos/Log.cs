using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            this.IsMdiContainer = true;
            l.MdiParent = this;
            l.Dock = DockStyle.Fill;
            l.Show();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.IsMdiContainer = true;
            l.MdiParent = this;
            l.Dock = DockStyle.Fill;
            l.Show();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscription i = new Inscription();
            this.IsMdiContainer = true;
            i.MdiParent = this;
            i.Dock = DockStyle.Fill;
            i.Show();
        }

        
        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Red; }
            }

            public override Color MenuBorder  //added for changing the menu border
            {
                get { return Color.Green; }
            }

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }
    }
}
