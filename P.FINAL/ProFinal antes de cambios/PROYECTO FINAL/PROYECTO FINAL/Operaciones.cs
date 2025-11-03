using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class Operaciones
    {
        public double _a11, _a12, _a21, _a22, _delt2;
        public void casillas(double a11, double a12, double a21, double a22)
        {
            _a11 = a11;
            _a12 = a12;
            _a21 = a21;
            _a22 = a22;
            double delta2x2 = (_a11 * _a22) - (_a21 * _a12);
            _delt2 = delta2x2;
        }
        public double ReturnDelta()
        { return _delt2; }


    }
}
