using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    class myExceptions : Exception 
    {
        public myExceptions() : base("Empty Input")
        {

        }

        public myExceptions(String message) : base(message)
        {

        }
    }
}
