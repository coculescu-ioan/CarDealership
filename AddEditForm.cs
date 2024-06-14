using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class AddEditForm : Form
    {
        private List<Manufacturer> manufacturerList;
        private Car _car;

        public AddEditForm(Car car)
        {
            InitializeComponent();
            manufacturerList = Manufacturer.GetFromTXT("Manufacturer.txt");

            CbManufacturer.DataSource = manufacturerList;
            CbManufacturer.DisplayMember = "Name";
            CbManufacturer.ValueMember = "Id";

            _car = car;

            DtpManufacturingDate.Value = car.ManufacturingDate;
            TbPrice.Text = car.Price.ToString();
            CbManufacturer.SelectedIndex = car.ManufacturerId - 1;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                _car.ManufacturingDate = DtpManufacturingDate.Value;
                _car.Price = double.Parse(TbPrice.Text);
                _car.ManufacturerId = CbManufacturer.SelectedIndex + 1;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("One or more fields have invalid data.", "Please review", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtpManufacturingDate_Validating(object sender, CancelEventArgs e)
        {
            if (DtpManufacturingDate.Value.AddYears(2) < DateTime.Now 
                || DtpManufacturingDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "The manufacturing date should be in the current or the previous year!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void TbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(TbPrice.Text, out double _) || double.Parse(TbPrice.Text) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "The price is invalid!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void CbManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if(CbManufacturer.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Please select a manufacturer!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }
    }
}
