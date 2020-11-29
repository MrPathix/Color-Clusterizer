using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Clusterizer.Models
{
    public class ProgressReport
    {
        public bool IsOperating { get; set; }
        public Bitmap Bitmap { get; set; }
        public int Progress { get; set; }
    }
}
