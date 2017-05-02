using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLRvia01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CLRvia01.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void T1Test()
        {
            Trace.WriteLine("Start Test");

            new Program().T1();
            
        }
    }
}