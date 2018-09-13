using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritishAutomobiles
{
    public class Car
    {
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; set; }
        public string FuelType { get; set; }
        public string ValveTrainConfig { get; set; }

        public Car(string manufacture, string model, double engineSize, string fuelType, string valveTrainConfig)
        {
            Manufacture = manufacture;
            Model = model;
            EngineSize = engineSize;
            FuelType = fuelType;
            ValveTrainConfig = valveTrainConfig;
        }
    }
}
