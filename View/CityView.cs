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
    public partial class CityView : Form
    {
        private CityController cityController = new CityController();
        private City city = new City();
        private Boolean listSwitch = false;

        public CityView()
        {
            InitializeComponent();
        }

        // Updates views

        private void UpdateView()
        {
            cityGridView.Columns.Clear();

            cityGridView.DataSource = cityController.Read(citySearch.Text.ToString(), listSwitch);
            
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

            cityGridView.Columns.Add(editColumn);

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

            cityGridView.Columns.Add(deleteColumn);

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

            cityGridView.Columns.Add(restoreColumn);

            #endregion

            #region Columns Settings

            cityGridView.Columns[0].Visible = false;
            cityGridView.Columns[1].HeaderText = "Função";
            cityGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cityGridView.Columns[2].Visible = false;

            if (listSwitch)
            {
                cityGridView.Columns[3].Visible = false;
                cityGridView.Columns[4].Visible = false;
            }
            else
            {
                cityGridView.Columns[5].Visible = false;
            }

            #endregion
        }

        // Updates view on form load and sets focus to search box

        private void CityView_Load(object sender, EventArgs e)
        {
            UpdateView();

            citySearch.Focus();
            citySearch.Select();
        }

        // Updates view while typing on search box

        private void citySearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateView();
        }
        
        // Opens create dialog

        private void button1_Click_1(object sender, EventArgs e)
        {
            CityCreate cityCreateForm = new CityCreate();
            cityCreateForm.ShowDialog();

            UpdateView();
        }

        // Identifies which link was clicked and performs respective operation

        private void cityGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == 3)
                {
                    CityUpdate cityUpdateForm = new CityUpdate(Convert.ToInt16(senderGrid.CurrentRow.Cells[0].Value), senderGrid.CurrentRow.Cells[1].Value.ToString());

                    cityUpdateForm.ShowDialog();

                    UpdateView();
                }
                else if (e.ColumnIndex == 4)
                {
                    if ((int)MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                    {
                        cityController.Delete(city);
                        UpdateView();
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    if ((int)MessageBox.Show("Tem certeza que deseja restaurar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                    {
                        city.Active = 1;

                        cityController.Update(city);
                        UpdateView();
                    }
                }
            }
        }

        // Fills class attributes with values from selected row

        private void cityGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            city.Id = Convert.ToInt16(senderGrid.CurrentRow.Cells[0].Value);
            city.Name = senderGrid.CurrentRow.Cells[1].Value.ToString();
            city.Active = Convert.ToInt16(senderGrid.CurrentRow.Cells[2].Value);
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
