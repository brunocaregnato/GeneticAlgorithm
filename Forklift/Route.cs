using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forklift
{
    public class Route
    {
        public enum Movement
        {
            North,
            South,
            East,
            West
        }

        public IEnumerable<Movement> Movements { get; private set; }

        public Route(IEnumerable<Movement> movements)
        {
            Movements = movements;
        }
    }
}
