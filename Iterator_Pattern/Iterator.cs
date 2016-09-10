using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    /// <summary>
    /// Iterator
    /// </summary>
    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
