using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovannis.Modelos.Excepciones
{
    public class ConnectionException : Exception
    {
        public ConnectionException(string message) : base(message)
        {
        }
    }
}
