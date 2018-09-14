using Newtonsoft.Json.Linq;
using System;
using static BritishAutomobiles.Segment;

namespace BritishAutomobiles
{
    public class Car
    {
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; private set; }
        public string FuelType { get; set; }
        public string ValveTrainConfig { get; set; }

        //public bool edited { get; private set; }

        public Car(string manufacture, string model, double engineSize, string fuelType, string valveTrainConfig)
        {
            Manufacture = manufacture;
            Model = model;
            EngineSize = engineSize;
            FuelType = fuelType;
            ValveTrainConfig = valveTrainConfig;
        }

        public void Print()
        {
            Console.WriteLine(Manufacture + " == " + Model + " " + EngineSize.ToString() + " " + FuelType + " >> " + ValveTrainConfig + "\n ");
        }

        //public override string ToString()
        //{
        //    return Manufacture + " " + Model + " " + EngineSize.ToString() + " " + FuelType + " " + ValveTrainConfig;
        //}
       
        //public void SetEnginesize(double size)
        //{
        //    edited = true;
        //    EngineSize = size;
        //}
    }
}
