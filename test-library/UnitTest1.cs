using System;
using Xunit;
using library;
using System.Collections.Generic;

namespace test_library
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> testlist = new List<int>();
            testlist.Add(3);
            testlist.Add(6);
            testlist.Add(9);
            Assert.Equal(testlist,Multiples.of(3,10));
            Assert.NotEqual(testlist,Multiples.of(5,10));
        }
        [Fact]
        public void Test2()
        {
            
        }
    }
}
