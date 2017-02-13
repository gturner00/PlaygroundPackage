using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Playground;

namespace Playground.Tests
{        
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void TestGetRandomTime()
        {
            for (int i = 0; i < 100; i++)
            {
                int x = Program.GetRandomTime();
                Assert.GreaterOrEqual(x, 0);
                Assert.LessOrEqual(x, 6000);
            }
        }        
    }
}
