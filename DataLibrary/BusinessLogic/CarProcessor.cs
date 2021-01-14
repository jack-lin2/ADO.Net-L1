using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic {
    public static class CarProcessor {
        //can also be static, will not hold any data
        public static int CreateCar(string registrationNumber, string carType) {
            CarModel data = new CarModel {
                RegistrationNumber = registrationNumber,
                CarType = carType
            };

            string sql = @"insert into dbo.Car (RegistrationNumber, CarType)
                            values (@RegistrationNumber, @CarType)";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<CarModel> LoadCars() {
            string sql = @"select Id, RegistrationNumber, CarType from dbo.Car";

            return SqlDataAccess.LoadData<CarModel>(sql);
        }
    
    
    }



}
