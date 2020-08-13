using NUnit.Framework;
using System.Net.Http;

namespace ItayDrowingAppTest
{
    public class Tests
    {
        public readonly HttpClient client = new HttpClient();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            client.GetAsync("https://www.walla.co.il");
            Assert.Pass();
        }
    }
}