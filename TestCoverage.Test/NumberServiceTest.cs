namespace TestCoverage.Test
{
    public class NumberServiceTest
    {
        [Test]
        public void Test1()
        {
            NumberService.Describe(1);
        }

        [Test]
        public void Test2()
        {
            NumberService.Describe(20);
        }

        [Test]
        public void Test3()
        {
            NumberService.Describe(150);
        }

        [Test]
        public void Test4()
        {
            NumberService.Describe(1150);
        }

        [Test]
        public void Test5()
        {
            NumberService.Describe(-1150);
        }
    }
}