using System;
using System.Collections.Generic;
using System.Numerics;

namespace VectorMathTests
{
    class Program
    {



        static int Main(string[] args)
        {
            var a = new System.Numerics.Vector<short>(-5);
            a = System.Numerics.Vector.Abs(a);
            if (a[0] != 5)
            {
                return 0;
            }
            var b = System.Numerics.Vector<int>.One;
            b = System.Numerics.Vector.Abs(b);
            if (b[3] != 1)
            {
                return 0;
            }
            var c = new System.Numerics.Vector<long>(-11);
            c = System.Numerics.Vector.Abs(c);
            if (c[1] != 11)
            {
                return 0;
            }

            var d = new System.Numerics.Vector<double>(-100.0);
            d = System.Numerics.Vector.Abs(d);
            if (d[0] != 100)
            {
                return 0;
            }
            var e = new System.Numerics.Vector<float>(-22);
            e = System.Numerics.Vector.Abs(e);
            if (e[3] != 22)
            {
                return 0;
            }
            var f = new System.Numerics.Vector<ushort>(21);
            f = System.Numerics.Vector.Abs(f);
            if (f[7] != 21)
            {
                return 0;
            }
            var g = new System.Numerics.Vector<ulong>(21);
            g = System.Numerics.Vector.Abs(g);
            if (g[1] != 21)
            {
                return 0;
            }

            return 100;
        }
    }
}
