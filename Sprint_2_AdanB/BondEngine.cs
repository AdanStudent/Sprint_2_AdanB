using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_2_AdanB
{
    public class BondEngine : GameEngine
    {
        public BondEngine()
        {
            UpdateVersion(1);
            this.PhysicsEngine.ChangeState(PhysicsEngineState.THREE_D);
        }
    }
}
