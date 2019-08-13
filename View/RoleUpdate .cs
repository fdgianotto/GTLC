using gtlc.Controller;
using gtlc.Helpers;
using System;
using System.Windows.Forms;

namespace gtlc.View
{
    public partial class RoleUpdate : Form
    {
        private Role role;

        public RoleUpdate(int roleId, String inputRole)
        {
            InitializeComponent();

            role = new Role(roleId, inputRole, 1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            roleUpdate();
        }

        private void inputRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                roleUpdate();
            }
            else if ((Keys)e.KeyChar == Keys.Escape)
            {
                this.Close();
            }
        }

        private void roleUpdate()
        {
            if (string.IsNullOrWhiteSpace(inputRole.Text))
            {
                MessageBox.Show("O campo não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RoleController roleController = new RoleController();

                role.Name = inputRole.Text;

                roleController.Update(role);

                this.Close();
            }
        }

        private void RoleUpdate_Load(object sender, EventArgs e)
        {
            inputRole.Text = role.Name;
        }
    }
}
