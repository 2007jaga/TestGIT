using System;
using System.Collections.Generic;
using System.Text;

namespace TestGIT
{
    internal class Test
    {
        public string TestName { get; set; }

        public string Date { get; set; }


        internal static Test Create(string testName, string date)
        {
            return new Test
            {
                TestName = testName,
                Date = date
            };
        }
    }
}
