using HelloCalculator.Exceptions;
using System;

namespace HelloCalculator
{
    public class Calculator
    {
        public float Jumlah(float v1, float v2)
        {
            return v1+v2;
        }

        public float Bagi(int v1, int v2)
        {
            if(v2 == 0)
                throw new DivisionbyZeroException("Tidak boleh pembagian dengan 0");
           
            return v1 / v2;
        }
    }
}
