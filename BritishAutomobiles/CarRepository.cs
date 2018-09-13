using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BritishAutomobiles.Segment;

namespace BritishAutomobiles
{
    public class CarRepository
    {
        public SegmentEnum Segment { get; set; }

        public List<Car> carList { get; set; }
        public CarRepository(string filePath, SegmentEnum segment)
        {
            Segment = segment;
            carList = new List<Car>();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entry = line.Split('-');
                if (entry[5] == segment.ToString())
                {
                    AddCar(entry);
                }
            }
        }
        public void AddCar(string[] entries)
        {
            var manufacture = entries[0];
            var model = entries[1];
            var engineSize = double.Parse(entries[2]);
            var fuelType = entries[3];
            var valvTrainConfig = entries[4];
            carList.Add(new Car(manufacture, model, engineSize, fuelType, valvTrainConfig));
        }
    }
}
