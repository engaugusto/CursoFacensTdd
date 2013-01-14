using Aula0Console;
using NUnit.Framework;

namespace Aula0Test
{
    public class Aula0Test
    {
        [Test]
        public void HelloWorldTest()
        {
            Assert.AreEqual(Program.HelloWorld(),"Hello World");
        }
    }
}
