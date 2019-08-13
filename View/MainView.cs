using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtlc.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VerTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleView roleViewForm = new RoleView();
            roleViewForm.Show();
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleCreate roleCreateForm = new RoleCreate();
            roleCreateForm.ShowDialog();
        }

        private void VerTudoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CityView cityViewForm = new CityView();
            cityViewForm.Show();
        }

        private void NovoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CityCreate cityCreateForm = new CityCreate();
            cityCreateForm.ShowDialog();
        }
    }
}
