using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
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
        {
            new Program().TestUDP();
        }

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
        public void testSQL()
        {
            var connectStr = "Data Source=dnsdbserver;Initial Catalog=Tfs_ZYTCollection;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            SqlConnection sqlConn = new SqlConnection(connectStr);
            SqlCommand command = new SqlCommand(
                "SELECT * FROM [dbo].[tbl_Field]", sqlConn);
            command.Parameters.AddWithValue("@fime", 1);
            if (sqlConn.State != System.Data.ConnectionState.Open)
            {
                sqlConn.Open();
            }
            var obj = command.ExecuteScalar();
            int whileCount = 100000;
            do
            {
                List<string> barcode = new List<string>(1000);
                using (var reader = command.ExecuteReader(System.Data.CommandBehavior.SequentialAccess))
                {
                    while (reader.Read())
                    {
                        //int colId = reader.GetOrdinal("Name");
                        //var val = reader[0];
                        //var sf = reader["ToStateConstID"];
                        //string fname = reader.GetString(colId);
                        ////reader.GetGuid(1);
                        //barcode.Add(fname);
                    }
                }
            }
            while (whileCount-- > 0);
            command.Dispose();
            sqlConn.Close();
        }

        public void TestUDP()
        {
            Assembly.GetExecutingAssembly();
            int k = 100;
            var data =
                File.ReadAllBytes(Process.GetCurrentProcess().MainModule.FileName);
            while (k-- > 0)
            {
                var server = new UdpClient("192.168.6.1", 8080);
                server.SendAsync(data, data.Length);
                Console.Write(".");
            }
        }
    }

    public class T1Class
    {
        public int abc() { return 0x11; }  //0x11111111 = 511
        public int j;
        protected int x;
        protected int z;
        protected internal int xy;
        public static T1Class operator +(T1Class t1, T1Class t2)
        {
            t1.j = t1.j + t2.j + 1;
            return t1;
        }

        public static T1Class operator &(T1Class t1, T1Class t2)
        {
            return new T1Class();
        }
    }
}
