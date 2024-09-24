using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBody.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BodyComposition BodyComposition { get; set; }
        public BodyMeasurements BodyMeasurements { get; set; }

    }
}

