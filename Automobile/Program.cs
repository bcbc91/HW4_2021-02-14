using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoProps autoProps = new AutoProps()
            {
                Id = 1,
                Brand = "Volkswagen",
                Model = "Passat",
                DoorType = DoorType.BeşKapılı,
                Horsepower = 125,
                VagonType = VagonType.Binek,
                TopSpeed = 215,
                TractionType = TractionType.ÖndenÇekişli,
                Acceleration = 9.1,
                Weight = 1385,
                EngineDisplacement = 1398
            };

            Console.WriteLine("Id: "+ autoProps.Id);
            Console.WriteLine("Brand: "+autoProps.Brand);
            Console.WriteLine("Model: "+ autoProps.Model);
            Console.WriteLine("DoorType: "+autoProps.DoorType);
            Console.WriteLine("Horsepower: "+autoProps.Horsepower);
            Console.WriteLine("VagonType: "+autoProps.VagonType);
            Console.WriteLine("TopSpeed: "+autoProps.TopSpeed);
            Console.WriteLine("TractionType: "+autoProps.TractionType);
            Console.WriteLine("Acceleration: "+autoProps.Acceleration);
            Console.WriteLine("Weight: "+autoProps.Weight);
            Console.WriteLine("EngineDisplacement: "+autoProps.EngineDisplacement);


            AutoProps autoProps2 = new AutoProps()
            {
                Id = 2,
                Brand = "Audi",
                Model = "A3",
                DoorType = DoorType.BeşKapılı,
                Horsepower = 105,
                VagonType = VagonType.Binek,
                TopSpeed = 195,
                TractionType = TractionType.ÖndenÇekişli,
                Acceleration = 9.8,
                Weight = 1325,
                EngineDisplacement = 1198
            };
            Console.WriteLine("Id: " + autoProps2.Id);
            Console.WriteLine("Brand: " + autoProps2.Brand);
            Console.WriteLine("Model: " + autoProps2.Model);
            Console.WriteLine("DoorType: " + autoProps2.DoorType);
            Console.WriteLine("Horsepower: " + autoProps2.Horsepower);
            Console.WriteLine("VagonType: " + autoProps2.VagonType);
            Console.WriteLine("TopSpeed: " + autoProps2.TopSpeed);
            Console.WriteLine("TractionType: " + autoProps2.TractionType);
            Console.WriteLine("Acceleration: " + autoProps2.Acceleration);
            Console.WriteLine("Weight: " + autoProps2.Weight);
            Console.WriteLine("EngineDisplacement: " + autoProps2.EngineDisplacement);

            Console.ReadLine();

        }
    }
}
