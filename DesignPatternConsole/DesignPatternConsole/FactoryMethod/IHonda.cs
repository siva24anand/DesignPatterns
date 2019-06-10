using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    //product
    public interface IHonda
    {
        string Name { get; }
        string Color { get; }
        int GetCarModel { get; }
    }
}
