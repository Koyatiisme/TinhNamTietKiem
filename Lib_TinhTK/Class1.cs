using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_TinhTK
{
    public class TinhSoNam
    {
        public float s, t, p;
        public int n {  get; private set; }

        public void TinhThang ()
        {
            while (s < t)
            {
                s += s * (0.01f * p);
                n++;
            }
        }

    }
}
