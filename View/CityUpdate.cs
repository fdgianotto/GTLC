using gtlc.Controller;
using gtlc.Helpers;
using System;
using System.Windows.Forms;

namespace gtlc.View
{
    public partial class CityUpdate : Form
    {
        private City city;

        public CityUpdate(int cityId, String inputCity)
        {
            InitializeComponent();

            city = new City(cityId, inputCity, 1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            cityUpdate();
        }

        private void inputCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                cityUpdate();
            }
            else if ((Keys)e.KeyChar == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cityUpdate()
        {
            if (string.IsNullOrWhiteSpace(inputCity.Text))
            {
                MessageBox.Show("O campo não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CityController cityController = new CityController();

                city.Name = inputCity.Text;

                cityController.Update(city);

                this.Close();
            }
        }

        private void CityUpdate_Load(object sender, EventArgs e)
        {
            inputCity.Text = city.Name;
        }
    }
}
