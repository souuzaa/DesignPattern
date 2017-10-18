using FacadePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facades
{
    public class CarFacade
    {
        private readonly Accessories accessories;
        private readonly Body body;
        private readonly Engine engine;
        private readonly Model model;

        public CarFacade()
        {
            accessories = new Accessories();
            body = new Body();
            engine = new Engine();
            model = new Model();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("******** Car creation is completed. **********");
        }
    }
}
