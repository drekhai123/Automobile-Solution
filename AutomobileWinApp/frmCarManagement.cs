using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibrary.BussinessObject;

namespace AutomobileWinApp
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        //Create a DataSource
        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Add car",
                InsertOrUpdate = false,
                CarRepository = carRepository
            };
            if(frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                //Set focus car inserted
                source.Position = source.Count - 1;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void btClose_Click(object sender, EventArgs e) => Close();

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btDelete.Enabled = false;
            //Register this event to open the frmCarDetails form that perform updating
            dgvCarList.CellDoubleClick += DgvCarList_CellDoubleClick;
        }
        //----------------------------------------------------------------
        private void DgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Update car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = carRepository
            };
            if(frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        //-----------------------------------------------------------------
        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car()
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,  
                    Manufacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car"); 
            }
            return car;
        }
        private void ClearText()
        {
            txtCarID.Text = string.Empty;   
            txtCarName.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty; 
        }
        public void LoadCarList()
        {
            var cars = carRepository.GetCars();
            try
            {
                //The Binding Source component is designed to simplyfy
                //the process of binding controls to an underlying datasource
                source = new BindingSource();
                source.DataSource = cars;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();    
                txtManufacturer.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManufacturer.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;
                if(cars.Count() == 0)
                {
                    ClearText();
                    btDelete.Enabled = false;
                }
                else
                {
                    btDelete.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car first");
            }
        }
    }
}
