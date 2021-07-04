using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCalculator.Exceptions
{
    public class DivisionbyZeroException : ApplicationException
    {
        public DivisionbyZeroException(string description):base(description)
        {

        }
    }
}
