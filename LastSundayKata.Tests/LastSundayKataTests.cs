using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LastSundayKata.Tests
{
    [TestFixture]
    public class LastSundayKataTests
    {
        [Test]
        public void LastSunday_GivenYear2013_ShouldReturnLastSundayForJanuary()
        {
            //---------------Set up test pack-------------------
            var sut = Create();
            var expected = new DateTime(2013,1,27);
            var input = new DateTime(2013,1,1);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.LastSunday(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result.First());
        }

        [Test]
        public void LastSunday_GivenYear2013_ShouldReturnListOfLastSundaysForThatYear()
        {
            //---------------Set up test pack-------------------
            var sut = Create();
            var expected = ExpectedYears();
            var input = new DateTime(2013,1,1);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.LastSunday(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void LastSunday_GivenYear2020_ShouldReturnListOfLastSundayForFebruary()
        {
            //---------------Set up test pack-------------------
            var sut = Create();
            var expected = ExpectedYears();
            var input = new DateTime(2020,1,1);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.LastSunday(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(new DateTime(2020,2,23), result[1]);
        }

        [Test]
        public void LastSunday_GivenYear2023_ShouldReturnListOfLastSundayForFebruary()
        {
            //---------------Set up test pack-------------------
            var sut = Create();
            var expected = ExpectedYears();
            var input = new DateTime(2032,1,1);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.LastSunday(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(new DateTime(2032,2,29), result[1]);
        }

        private List<DateTime> ExpectedYears()
        {
            return new List<DateTime>
            {
                new DateTime(2013, 1, 27),
                new DateTime(2013, 2, 24),
                new DateTime(2013, 3, 31),
                new DateTime(2013, 4, 28),
                new DateTime(2013, 5, 26),
                new DateTime(2013, 6, 30),
                new DateTime(2013, 7, 28),
                new DateTime(2013, 8, 25),
                new DateTime(2013, 9, 29),
                new DateTime(2013, 10, 27),
                new DateTime(2013, 11, 24),
                new DateTime(2013, 12, 29),
            };
        }

        private  LastSundayKata Create()
        {
            return new LastSundayKata();
        }
    }
}
