using System;
using System.Diagnostics;

namespace CLRvia12
{
    internal class OperationTimer : IDisposable
    {
        private Stopwatch m_stopwatch;
        private String m_text;
        private Int32 m_collectionCount;

        public OperationTimer(string v)
        {
            PrepareForOperation();

            this.m_text = v;
            m_collectionCount = GC.CollectionCount(0);
            m_stopwatch = Stopwatch.StartNew();
        }

        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        public void Dispose()
        {
            Console.WriteLine("{0} (GCs={1,3}) {2}", m_stopwatch.Elapsed,
            GC.CollectionCount(0) - m_collectionCount, m_text);
        }
    }
}