using System;
using static BritishAutomobiles.Segment;

namespace BritishAutomobiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\Bruger\Desktop\BritishAutomobiles.txt";
            CarRepository MiniCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentA);
            CarRepository SmallCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentB);
            CarRepository MediumCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentC);
            CarRepository LargeCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentD);
            CarRepository ExecutiveCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentE);
            CarRepository LuxuryCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentF);
            CarRepository SportsUtilityCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentJ);
            CarRepository MultiPurposeCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentM);
            CarRepository SportsCarsSegment = new CarRepository(filePath, SegmentEnum.SegmentS);

            MiniCarsSegment.PrintCars();
            SmallCarsSegment.PrintCars();
            MediumCarsSegment.PrintCars();
            LargeCarsSegment.PrintCars();
            ExecutiveCarsSegment.PrintCars();
            LuxuryCarsSegment.PrintCars();
            SportsUtilityCarsSegment.PrintCars();
            MultiPurposeCarsSegment.PrintCars();
            SportsCarsSegment.PrintCars();
            Console.ReadLine();
        }
    }
}
