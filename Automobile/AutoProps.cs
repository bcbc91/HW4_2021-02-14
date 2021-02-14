using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class AutoProps
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DoorType DoorType { get; set; }
        public short Horsepower { get; set; }
        public VagonType VagonType { get; set; }
        public short TopSpeed { get; set; }
        public TractionType TractionType { get; set; }
        public double Acceleration { get; set; }
        public short Weight { get; set; }
        public short EngineDisplacement { get; set; }
    }
}
