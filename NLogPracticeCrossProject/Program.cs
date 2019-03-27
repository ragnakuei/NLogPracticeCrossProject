using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace NLogPracticeCrossProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var bl = new TestBL();
            bl.Test();
        }
    }
}
