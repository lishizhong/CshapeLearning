using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//告诉编译器检查CLS相容性
[assembly: CLSCompliant(true)]

namespace CLRvia01
{

    /*
     * CLR:通用语言运行时
     * CTS:通用类型系统
     * CLI:公共语言基础结构
     * CLS:公共语言规范
     */
    public class Program
    {
        static void Main(string[] args)
        { }

        public void T1()
        {
            Console.WriteLine(this.GetType().Module.FullyQualifiedName);
            var osVer = Environment.Is64BitOperatingSystem;
            Console.WriteLine("osBit:" + osVer);
            Console.WriteLine(this.GetHashCode());
            T1Class t1 = new T1Class();
            var t2 = new T1Class();
            t1.j = t2.j = 100;
            Console.WriteLine((t1 + t2).j);
            Assert.IsTrue(t1.j == 201);
        }
    }

    public class T1Class
    {
        public UInt32 abc() { return 0; }
        public int j;
        protected int x;
        protected int z;
        protected internal int xy;
        public static T1Class operator +(T1Class t1, T1Class t2)
        {
            t1.j = t1.j + t2.j + 1;
            return t1;
        }

    }
}
