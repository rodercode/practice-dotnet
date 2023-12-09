using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokeapi.Services
{
    public class Car
    {
        private AUDI _audi;
        public Car()
        {
                _audi = new AUDI("BMW A7");
        }
    }

    public class AUDI
    {
        public AUDI(string ModelName)
        {
        }

    }    
}