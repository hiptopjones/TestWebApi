using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FooService
{
    public class FooController : ApiController
    {
        private IFooSource FooSource { get; set;}

        public FooController()
        {
            FooSource = new BasicFooSource();
        }

        public string Get()
        {
            return FooSource.GetAllFoo();
        }
    }
}
