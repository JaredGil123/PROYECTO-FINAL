using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class tresportres1
    {
        public double _b11, _b12, _b13, _b21, _b22, _b23, _b31, _b32, _b33, _Determinante;
        public void Matriz(double b11, double b12, double b13, double c21, double c22, double c23, double d31, double d32, double d33)
        {
            double Det, Dx1, Dx2, Dx3;
            _b11 = b11;
            _b12 = b12;
            _b13 = b13;
            _b21 = c21;
            _b22 = c22;
            _b23 = c23;
            _b31 = d31;
            _b32 = d32;
            _b33 = d33;
            Dx1 = (_b11) * ((_b22 * _b33) - (_b32 * _b23));
            Dx2 = (-(_b12)) * ((_b21 * _b33) - (_b31 * _b23));
            Dx3 = (_b13) * ((_b21 * _b32) - (_b31 * _b22));
            Det = Dx1 + Dx2 + Dx3;
            _Determinante = Det;


        }
        public double CalDet()
        {
            return _Determinante;
        }

    }
}
