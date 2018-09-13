using System;

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

        internal void Print(Segment.SegmentEnum segment)
        {
            Console.WriteLine(Manufacture + " " + Model + " " + EngineSize.ToString() + " " + FuelType + " " + ValveTrainConfig + " " + segment.ToString() + "\n ");
        }
    }
}
