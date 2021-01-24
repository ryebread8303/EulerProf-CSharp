using System;
using Xunit;
using library;
using System.Collections.Generic;

namespace test_library
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiples()
        {
            List<int> testlist = new List<int>();
            testlist.Add(3);
            testlist.Add(6);
            testlist.Add(9);
            Assert.Equal(testlist,Multiples.of(3,10));
            Assert.NotEqual(testlist,Multiples.of(5,10));
        }
        [Fact]
        public void TestFibonacci()
        {
            List<int> testlist = new List<int>();
            testlist.Add(1);
            testlist.Add(2);
            testlist.Add(3);
            testlist.Add(5);
            testlist.Add(8);
            testlist.Add(13);
            testlist.Add(21);
            testlist.Add(34);
            testlist.Add(55);
            testlist.Add(89);
            //Assert.Equal(testlist,Fibonacci.first(10));
        }
        [Fact]
        public void TestTests()
        {
            Assert.False(Tests.IsOdd(2));
            Assert.True(Tests.IsOdd(1));
            //Assert.True(Tests.IsOdd(0));
        }
    }
}
