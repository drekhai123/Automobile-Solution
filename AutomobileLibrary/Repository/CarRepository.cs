using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId) => CarDBContext.Instance.DeleteCar(carId);

        public Car GetCarByID(int carId) => CarDBContext.Instance.GetCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarsList();
        public void InsertCar(Car car) => CarDBContext.Instance.AddNewCar(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.UpdateCar(car);
    }
}
