using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlant
{
    public class Sensor
    {
        public void RegisterTick(object sender, VitalDetectorEventArgs e)
        {

            Console.WriteLine("For the record: " + e.Name  +" is alive!");
        }
        public void MakeBip(object sender, VitalDetectorEventArgs e)
        {
            Console.WriteLine("BIIIIP");
        }

    }
}
