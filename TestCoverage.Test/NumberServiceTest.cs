using NUnit.Framework;
using TestCoverage.Console;

namespace TestCoverage.Test
{
    public class NumberServiceTest
    {
        [Test]
        public void Test4()
        {
            NumberService.Process(4);
        }

        [Test]
        public void Test15()
        {
            NumberService.Process(15);
        }

        [Test]
        public void Test150()
        {
            NumberService.Process(150);
        }

        [Test]
        public void TestMinus()
        {
            NumberService.Process(-1);
        }
    }
}