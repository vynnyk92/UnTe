using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LogAn.Test
{
    [TestFixture]
    public class LogAnTest
    {
        [TestCase("twst.SLF", true)]
        [TestCase("twst.slf", true)]
        [Category("1")]
        public void IsValidFileName_CorrectName_ReturnTrue(string filename, bool expectedResult)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(filename);
            result.Should().Be(expectedResult);
        }

        [Test]
        [Category("2")]
        public void IsValidFileName_IncorrectName_ThrowException()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            Action act =() => analyzer.IsValidLogFileName("filename");
            act.Should().Throw<ArgumentException>().WithMessage(LogAnalyzer.WRONG);
        }

        [Test]
        public void IsValidFileName_IncorrectName_ThrowException2()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            var ex = Assert.Catch<ArgumentException>(()=> analyzer.IsValidLogFileName("filename"));
            StringAssert.Contains(LogAnalyzer.WRONG, ex.Message);
        }
    }
}
