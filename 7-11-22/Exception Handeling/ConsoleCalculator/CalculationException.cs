using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class CalculationException : Exception
    {
        private const string DEFAULT_MESSAGE = "An Error occured during calculation.Ensure that the operator is supported and the values ar within valid ranges";
        
        /// <summary>
        /// creates a new <see cref="CalculationException"/> with predefined message
        /// </summary>
        public CalculationException():base(DEFAULT_MESSAGE)
        {

        }

        /// <summary>
        /// creates a new <see cref="CalculationException"/> with user defined message
        /// </summary>
        public CalculationException(string message):base(message)
        {

        }
        /// <summary>
        /// creates a new <see cref="CalculationException"/> with user defined message
        /// and wrapped inner Exception
        /// </summary>
        public CalculationException(string message,Exception exception):base(message,exception)
        {

        }
        /// <summary>
        /// creates a new <see cref="CalculationException"/> with predefined message
        /// and wrapped inner Exception
        /// </summary>
        public CalculationException( Exception innerException) : base(DEFAULT_MESSAGE, innerException)
        {

        }




    }
}
