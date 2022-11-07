using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class CalculationOperationNotSupportedException:CalculationException
    {
        private const string DEFAULT_MESSAGE = "Specified Operation was out of the range of valid values";
        public string Operation { get; }

        /// <summary>
        /// creates a new <see cref="CalculationOperationNotSupportedException"/> with predefined message
        /// </summary>
        public CalculationOperationNotSupportedException():base(DEFAULT_MESSAGE)
        {

        }
        /// <summary>
        /// creates a new <see cref="CalculationOperationNotSupportedException"/> with predefined message
        /// and wrapped inner Exception
        /// </summary>
        public CalculationOperationNotSupportedException(Exception innerException):base(DEFAULT_MESSAGE, innerException)
        {

        }
        /// <summary>
        /// creates a new <see cref="CalculationOperationNotSupportedException"/> with user defined message
        /// and wrapped inner Exception
        /// </summary>
        public CalculationOperationNotSupportedException(string message,Exception innerException) : base(message, innerException)
        {

        }

        /// <summary>
        /// creates a new <see cref="CalculationOperationNotSupportedException"/> with default message
        /// </summary>
        public CalculationOperationNotSupportedException(string operation) : base(DEFAULT_MESSAGE) 
        {
            Operation = operation;
        }

        public override string ToString()
        {
            if(Operation==null)
                return base.ToString();

            return base.ToString()+Environment.NewLine+$"Unsupported Operation: {Operation}";
        }
    }
}
