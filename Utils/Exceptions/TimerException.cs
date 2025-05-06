using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroDigital.Models.Exceptions
{
    class TimerException : ApplicationException
    {
        public TimerException(string message) : base(message)
        {
        }
    }
}
