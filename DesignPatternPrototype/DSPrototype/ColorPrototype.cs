using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPrototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
