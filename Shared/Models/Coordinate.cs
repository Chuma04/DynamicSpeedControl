using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSpeedControl.Shared.Models
{
    public class Coordinate : BaseEntity
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
