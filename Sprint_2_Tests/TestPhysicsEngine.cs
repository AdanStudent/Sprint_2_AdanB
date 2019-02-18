using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_2_AdanB;


namespace Sprint_2_Tests
{
    [TestClass]
    public class TestPhysicsEngine
    {
        [TestMethod]
        public void ConstructorTest()
        {
            PhysicsEngine physicsEngine = new PhysicsEngine();

            PhysicsEngineState defaultEngineState;
            defaultEngineState = physicsEngine.Simulating;

            Assert.AreEqual(defaultEngineState, defaultEngineState);
        }

        [TestMethod]
        public void StateTest()
        {
            PhysicsEngine physicsEngine = new PhysicsEngine();

            PhysicsEngineState defaultEngineState;
            defaultEngineState = physicsEngine.Simulating;

            physicsEngine.ChangeState(PhysicsEngineState.TWO_D);
            PhysicsEngineState TwoDChangedEngineState;
            TwoDChangedEngineState = physicsEngine.Simulating;

            physicsEngine.ChangeState(PhysicsEngineState.THREE_D);
            PhysicsEngineState ThreeDChangedEngineState;
            ThreeDChangedEngineState = physicsEngine.Simulating;

            Assert.AreEqual(defaultEngineState, PhysicsEngineState.NONE);
            Assert.AreEqual(TwoDChangedEngineState, PhysicsEngineState.TWO_D);
            Assert.AreEqual(ThreeDChangedEngineState, PhysicsEngineState.THREE_D);

        }


    }
}
