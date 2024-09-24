using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBody.Domain
{
    public class BodyMeasurements
    {
        public int Id { get; set; }
        public double MeasureChest {  get; set; }
        public double MeasureShoulders { get; set; }
        public double MeasureLeftArm { get; set; }
        public double MeasureRightArm { get; set; }
        public double MeasureLeftForeArm { get; set; }
        public double MeasureRightForeArm { get; set; }
        public double MeasureAbs { get; set; }
        public double MeasureLeftThigh { get; set; }
        public double MeasureRightThigh { get; set; }
        public double MeasureLeftCalf { get; set; }
        public double MeasureRightCalf { get;set; }
    }
}
