using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vl.Particles.Core
{
    public enum TargetProperty
    {
        To_Force, To_Acceleration, To_Velocity, To_Position
    }

    public enum OperationType
    {
        Add, Subtract, Multiply, Divide, Min, Max
    }

}
