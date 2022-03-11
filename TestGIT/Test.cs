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

        internal static Test CreatewithMR(string testName, string date)
        {
            return new Test
            {
                TestName = "MR." + testName, Date ="01/jan/2022"
            };
        }
    }
}
