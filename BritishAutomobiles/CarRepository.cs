using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static BritishAutomobiles.Segment;

namespace BritishAutomobiles
{
    public class CarRepository
    {
        public SegmentEnum Segment { get; set; }

        public List<Car> CarList { get; set; }
        public CarRepository(string filePath, SegmentEnum segment)
        {
            Segment = segment;
            CarList = new List<Car>();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            var json = string.Join("", lines);
            AddCars(json);
        }
        private void AddCars(string json)
        {

            var jObject = JObject.Parse(json);
            var cars = jObject["cars"];
            foreach (var car in cars)
            {
                if (car["manufacturer"] == null)
                    throw new Exception("value is not present at MANUFACTURE field");
                else if (car["model"] == null)
                    throw new Exception("value is not present at MODEL field");
                else if (car["engine-size"] == null)
                    throw new Exception("value is not present at ENGINE SIZE field");
                else if (car["fuel-type"] == null)
                    throw new Exception("value is not present at FUEL TYPE field");
                else if (car["valve-train"] == null)
                    throw new Exception("value is not present at VALVE TRAIN field");

                if (Segment.ToString() == car["segment"].Value<string>())
                    CarList.Add(new Car(
                        car["manufacturer"].Value<string>(),
                        car["model"].Value<string>(),
                        car["engine-size"].Value<double>(),
                        car["fuel-type"].Value<string>(),
                        car["valve-train"].Value<string>()));
            }
        }
        public void PrintCars()
        {
            foreach (var car in CarList)
            {
                car.Print();
            }
        }
    }
}
