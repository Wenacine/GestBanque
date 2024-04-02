using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class InvalidOperationException : Exception
    {
        public string InvalidOperation { get; set; }

        public InvalidOperationException(string InvalidOperation) : this(InvalidOperation, "InvalidOperation")
        {

        }

        public InvalidOperationException(string InvalidOperation, string message) : base(message)
        {
            this.InvalidOperation = InvalidOperation;
        }
    }
}
