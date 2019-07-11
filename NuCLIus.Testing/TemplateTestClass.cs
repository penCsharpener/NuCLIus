using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests {
    public class TemplateTestClass {

        [SetUp]
        public void Setup() {

        }

        [TestCase("Execute", false)]
        [TestCase("Execute", true)]
        public async Task TemplateTest(string desc, bool doExecute) {
            
        }
    }
}