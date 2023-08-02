using DynamicSpeedControl.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSpeedControl.Shared.Models
{
    public class RestrictedAreaEntity : BaseEntity
    {

        public bool IsInArea(LocationObject location)
        {
            throw new NotImplementedException();
        }
    }
}
