using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototypeApp
{
    public interface IMyClonable<T>
    {
        T MyClone();
    }
}
