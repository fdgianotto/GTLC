using gtlc.Controller;
using gtlc.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtlc.View
{
    public partial class RoleView : Form
    {
        private RoleController roleController = new RoleController();
        private Role role = new Role();
        private Boolean listSwitch = false;

        public RoleView()
        {
            InitializeComponent();
        }

        // Updates views

        private void UpdateView()
        {
            roleGridView.Columns.Clear();

            roleGridView.DataSource = roleController.Read(roleSearch.Text.ToString(), listSwitch);
            
            #region Edit Column

            DataGridViewLinkColumn editColumn = new DataGridViewLinkColumn();
            {
                editColumn.HeaderText = "Editar";
                editColumn.Text = "Editar";
                editColumn.UseColumnTextForLinkValue = true;
                editColumn.Width = 48;
                editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                editColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            roleGridView.Columns.Add(editColumn);

            #endregion

            #region Delete Column

            DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn();
            {
                deleteColumn.HeaderText = "Excluir";
                deleteColumn.Text = "Excluir";
                deleteColumn.UseColumnTextForLinkValue = true;
                deleteColumn.Width = 48;
                deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                deleteColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            roleGridView.Columns.Add(deleteColumn);

            #endregion

            #region Restore Column

            DataGridViewLinkColumn restoreColumn = new DataGridViewLinkColumn();
            {
                restoreColumn.HeaderText = "Restaurar";
                restoreColumn.Text = "Restaurar";
                restoreColumn.UseColumnTextForLinkValue = true;
                restoreColumn.Width = 72;
                restoreColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                restoreColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            roleGridView.Columns.Add(restoreColumn);

            #endregion

            #region Columns Settings

            roleGridView.Columns[0].Visible = false;
            roleGridView.Columns[1].HeaderText = "Função";
            roleGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            roleGridView.Columns[2].Visible = false;

            if (listSwitch)
            {
                roleGridView.Columns[3].Visible = false;
                roleGridView.Columns[4].Visible = false;
            }
            else
            {
                roleGridView.Columns[5].Visible = false;
            }

            #endregion
        }

        // Updates view on form load and sets focus to search box

        private void RoleView_Load(object sender, EventArgs e)
        {
            UpdateView();

            roleSearch.Focus();
            roleSearch.Select();
        }

        // Updates view while typing on search box

        private void roleSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateView();
        }
        
        // Opens create dialog

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoleCreate roleCreateForm = new RoleCreate();
            roleCreateForm.ShowDialog();

            UpdateView();
        }

        // Identifies which link was clicked and performs respective operation

        private void roleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == 3)
                {
                    RoleUpdate roleUpdateForm = new RoleUpdate(Convert.ToInt16(senderGrid.CurrentRow.Cells[0].Value), senderGrid.CurrentRow.Cells[1].Value.ToString());

                    roleUpdateForm.ShowDialog();

                    UpdateView();
                }
                else if (e.ColumnIndex == 4)
                {
                    if ((int)MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                    {
                        roleController.Delete(role);
                        UpdateView();
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    if ((int)MessageBox.Show("Tem certeza que deseja restaurar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                    {
                        role.Active = 1;

                        roleController.Update(role);
                        UpdateView();
                    }
                }
            }
        }

        // Fills class attributes with values from selected row

        private void roleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            role.Id = Convert.ToInt16(senderGrid.CurrentRow.Cells[0].Value);
            role.Name = senderGrid.CurrentRow.Cells[1].Value.ToString();
            role.Active = Convert.ToInt16(senderGrid.CurrentRow.Cells[2].Value);
        }

        private void btnManageRemovedItems_Click(object sender, EventArgs e)
        {
            listSwitch = !listSwitch;

            if (listSwitch)
            {
                btnManageRemovedItems.Text = "Gerenciar funções";
            }
            else
            {
                btnManageRemovedItems.Text = "Gerenciar exclusões";
            }

            UpdateView();
        }
    }
}
