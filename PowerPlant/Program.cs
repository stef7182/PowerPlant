using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlant
{
    class Program
    {
        static void Main(string[] args)
        {
            VitalDetector vitalDetector = new VitalDetector() { Name = "Bob" };
            Sensor sensor = new Sensor();

            vitalDetector.Tick += sensor.RegisterTick;
            vitalDetector.Tick += sensor.MakeBip;
            vitalDetector.StartDecetor();

        }
    }
}
