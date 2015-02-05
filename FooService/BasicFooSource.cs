using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooService
{
    public class BasicFooSource : IFooSource
    {
        public string GetAllFoo()
        {
            return "Significant amount of foo...";
        }
    }
}
