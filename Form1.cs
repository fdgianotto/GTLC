using gtlc.Model.Database;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace gtlc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            //Controller.Controller funcaoController = new Controller.Controller();

            //dataGridView1.DataSource = funcaoController.Read();
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].HeaderText = "Função";
            //dataGridView1.Columns[2].Visible = false;

            //DataGridViewLinkColumn editColumn = new DataGridViewLinkColumn();
            //{
            //    editColumn.HeaderText = "Editar";
            //    editColumn.Text = "Editar";
            //    editColumn.UseColumnTextForLinkValue = true;
            //    editColumn.Width = 64;
            //    editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    editColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //dataGridView1.Columns.Add(editColumn);

            //DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn();
            //{
            //    deleteColumn.HeaderText = "Excluir";
            //    deleteColumn.Text = "Excluir";
            //    deleteColumn.UseColumnTextForLinkValue = true;
            //    deleteColumn.Width = 64;
            //    editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    editColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //dataGridView1.Columns.Add(deleteColumn);

            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void myDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
//            Controller.Controller funcaoController = new Controller.Controller();
  //          funcaoController.Create(textFuncao.Text);
    //        UpdateView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // Get row ID column

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == 3)
                {
                    Debug.WriteLine(senderGrid.CurrentRow.Cells[0].Value);
                } else if (e.ColumnIndex == 4)
                {
                    Debug.WriteLine(senderGrid.CurrentRow.Cells[0].Value);
                }
            }
        }
    }
}
