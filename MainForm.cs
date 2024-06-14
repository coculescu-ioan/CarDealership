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
    public partial class MainForm : Form
    {
        public BindingList<Car> cars;
        
        public MainForm()
        {
            InitializeComponent();
            cars = new BindingList<Car>();
            DgvCars.DataSource = cars;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            using(AddEditForm addEditForm = new AddEditForm(car))
            {
                if(addEditForm.ShowDialog() == DialogResult.OK)
                {
                    cars.Add(car);
                    SortCars();
                    DgvCars.Refresh();

                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DgvCars.SelectedRows.Count > 0)
            {
                Car car = (Car)DgvCars.SelectedRows[0].DataBoundItem;
                using (AddEditForm addEditForm = new AddEditForm(car))
                {
                    if (addEditForm.ShowDialog() == DialogResult.OK)
                    {
                        SortCars();
                        DgvCars.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("No car entry selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvCars.SelectedRows.Count > 0)
            {
                Car car = (Car)DgvCars.SelectedRows[0].DataBoundItem;
                cars.Remove(car);
                SortCars();
                DgvCars.Refresh();
            }
            else
            {
                MessageBox.Show("No car entry selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SortCars()
        {
            var sortedCars = cars.OrderBy(car => car.Price).ToList();
            cars.Clear();
            foreach (var car in sortedCars)
            {
                cars.Add(car);
            }

            if (cars.Count > 0)
            {
                double averageDays = cars.Average(car => (int)car);
                toolStripStatusLabel1.Text = $"Average days since manufacture: {averageDays:F2}";
            }
        }
    }
}
