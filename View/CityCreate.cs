using gtlc.Controller;
using gtlc.Helpers;
using System;
using System.Windows.Forms;

namespace gtlc.View
{
    public partial class CityCreate : Form
    {
        public CityCreate()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            cityCreate();
        }

        private void inputCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                cityCreate();
            }
            else if ((Keys)e.KeyChar == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cityCreate()
        {
            if (string.IsNullOrWhiteSpace(inputCity.Text))
            {
                MessageBox.Show("O campo não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                City city = new City(0, inputCity.Text.ToString(), 1);
                CityController cityController = new CityController();

                cityController.Create(city);

                this.Close();
            }
        }
    }
}
