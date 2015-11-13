using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Halloween.Tests
{
    [TestFixture]
    public class TestMainTest
    {
        /// <summary>
        /// WARNING: all tests passed!!!!!!!!
        /// </summary>
        [Test]
        public void TestToAcceptAcceptance()
        {
            var proxyNonMockedSut = new ObjectOriented32bitXmlBuglessParserManager();

            Assert.IsNotNull(proxyNonMockedSut);
        }
    }
}
