using ADO.Net_L1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;

namespace ADO.Net_L1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RegisterCar() {
            ViewBag.Message = "Register Car";

            return View();
        }

        public ActionResult ViewCarTypes() {
            ViewBag.Message = "Car Types";

            var data = CarProcessor.LoadCars();

            //Tramsformation
            List<CarModel> cars = new List<CarModel>();
            List<string> carTypes = new List<string>();
            
            foreach (var row in data) {
                if (carTypes.Contains(row.CarType) == false) {
                    cars.Add(new CarModel {
                        RegistrationNumber = row.RegistrationNumber,
                        CarType = row.CarType
                    });
                    carTypes.Add(row.CarType);
                }

            }

            return View(cars);
        }

        public ActionResult FindCarType() {
            ViewBag.Message = "Search Car Registration number";
            var data = CarProcessor.LoadCars();
            //Tramsformation
            List<CarModel> cars = new List<CarModel>();
            foreach (var row in data) {
                cars.Add(new CarModel {
                    RegistrationNumber = row.RegistrationNumber,
                    CarType = row.CarType
                });
            }

            return View(cars);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterCar(CarModel model) {
            if (ModelState.IsValid) {
                int recordsCreated = CarProcessor.CreateCar(model.RegistrationNumber, model.CarType);
                return RedirectToAction("RegisterCar");
            }

            return View();
        }





    }
}