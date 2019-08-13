using gtlc.Controller;
using gtlc.Helpers;
using System;
using System.Windows.Forms;

namespace gtlc.View
{
    public partial class RoleCreate : Form
    {
        public RoleCreate()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            roleCreate();
        }

        private void inputRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                roleCreate();
            }
            else if ((Keys)e.KeyChar == Keys.Escape)
            {
                this.Close();
            }
        }

        private void roleCreate()
        {
            if (string.IsNullOrWhiteSpace(inputRole.Text))
            {
                MessageBox.Show("O campo não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Role role = new Role(0, inputRole.Text.ToString(), 1);
                RoleController roleController = new RoleController();

                roleController.Create(role);

                this.Close();
            }
        }
    }
}
