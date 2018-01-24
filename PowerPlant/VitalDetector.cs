using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlant
{
    public delegate  void DG_VitalDecetorTick(object sender, VitalDetectorEventArgs e);
    public class VitalDetector
    {
        public string Name { get; set; }

        public event DG_VitalDecetorTick Tick;

        public void StartDecetor()
        {
            while (true)
            {
                Tick(this, new VitalDetectorEventArgs() { Name = this.Name });
                System.Threading.Thread.Sleep(1000);
            }
        }

    }


    public class VitalDetectorEventArgs : EventArgs
    {
        public string Name { get; set; }
    }
}
