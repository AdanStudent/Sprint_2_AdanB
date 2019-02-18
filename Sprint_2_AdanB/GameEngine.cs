using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_2_AdanB
{
    public abstract class GameEngine
    {
        public PhysicsEngine PhysicsEngine
        {
            get;
            protected set;
        }

        public float CurrentVersion
        {
            get;
            protected set;
        }

        public string ProgrammingLanguage
        {
            get;
            protected set;
        }


        public GameEngine()
        {
            this.PhysicsEngine = new PhysicsEngine();
            this.CurrentVersion = 1.0f;
            this.ProgrammingLanguage = "C++";
        }

        public string Info()
        {
            return String.Format("This engine is currently running with {0} based physics, is running current version {1}, and uses {2} programming language", 
                                this.PhysicsEngine.Simulating, this.CurrentVersion, this.ProgrammingLanguage);
        }

        public bool UpdateVersion(float num)
        {
            if (this.CurrentVersion + 1 >= this.CurrentVersion + num && num > 0)
            {
                this.CurrentVersion += num;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
