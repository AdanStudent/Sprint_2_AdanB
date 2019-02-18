using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_2_AdanB
{
    public enum PhysicsEngineState { NONE, TWO_D, THREE_D}
    public class PhysicsEngine
    {
        public PhysicsEngine()
        {
            this.Simulating = PhysicsEngineState.NONE;
        }

        public PhysicsEngineState Simulating
        {
            get;
            protected set;
        }

        public void ChangeState(PhysicsEngineState state)
        {
            this.Simulating = state;
        }


    }
}
