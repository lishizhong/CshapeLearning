using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conn = new SqlConnection("");
            conn.Open();
            Console.WriteLine("ok");
        }
    }
}
