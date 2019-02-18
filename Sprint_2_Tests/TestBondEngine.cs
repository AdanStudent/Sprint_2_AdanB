using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_2_AdanB;

namespace Sprint_2_Tests
{
    [TestClass]
    public class TestBondEngine
    {
        [TestMethod]
        public void ConstructorTest()
        {
            BondEngine bondEngine = new BondEngine();

            PhysicsEngineState defaultPhysicsEngineState;
            defaultPhysicsEngineState = bondEngine.PhysicsEngine.Simulating;

            float defaultEngineVersion;
            defaultEngineVersion = bondEngine.CurrentVersion;

            string defaultProgrammingLang;
            defaultProgrammingLang = bondEngine.ProgrammingLanguage;

            string infoBondEngine = bondEngine.Info();

            Assert.AreEqual(defaultPhysicsEngineState, PhysicsEngineState.THREE_D);
            Assert.AreEqual(defaultEngineVersion, 2.0);
            Assert.AreEqual(defaultProgrammingLang, "C++");
            Assert.AreEqual(infoBondEngine, string.Format("This engine is currently running with {0} based physics, is running current version {1}, " +
                "and uses {2} programming language", PhysicsEngineState.THREE_D, 2.0, "C++"));
        }

        [TestMethod]
        public void UpdateVersionTest()
        {
            BondEngine bondEngine = new BondEngine();

            float defaultCurrentVersion;
            defaultCurrentVersion = bondEngine.CurrentVersion;

            bondEngine.UpdateVersion(2.1f);
            float updatedEngineVersion;
            updatedEngineVersion = bondEngine.CurrentVersion;

            bondEngine.UpdateVersion(-2);
            float downgradeEngineVersion;
            downgradeEngineVersion = bondEngine.CurrentVersion;

            bondEngine.UpdateVersion(.5f);
            float upgradeEngineVersion;
            upgradeEngineVersion = bondEngine.CurrentVersion;

            Assert.AreEqual(defaultCurrentVersion, 2.0f);
            Assert.AreEqual(updatedEngineVersion, 2.0f);
            Assert.AreEqual(downgradeEngineVersion, 2.0f);
            Assert.AreEqual(upgradeEngineVersion, 2.5f);
        }


    }
}
