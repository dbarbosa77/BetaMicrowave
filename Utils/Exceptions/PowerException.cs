using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroDigital.Models.Exceptions
{
    class PowerException : ApplicationException
    {
        public PowerException(string message) : base(message)
        {
        }
    }
}
