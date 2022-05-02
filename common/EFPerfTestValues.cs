using System;

namespace common
{
    public class EFPerfTestValues
    {
        public static long batchId => 200000;
        public static string[] ds => new[] { "Data Source=.\\SQLEXPRESS;Initial catalog=efperftest;Integrated Security=False;User ID=test;Password=test;" };
    }
}
