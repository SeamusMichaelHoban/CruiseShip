using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseShip
{
    class Travel
    {


        public int Age {get; set;}
        public int Value {get; set;}
        public string ReturnValue { get; set;}
        

        public void Traveler()
        {
            //Default Costructor
        }


        public virtual void Choice()
        {
            //we will override this in the cruiseship class.
        }

        public int SwitchValue()
        {
            if(Age == 26)
            {
                return 1;
            }
            else if(Age == 27)
            {
                return 2;
            }
            else if(Age == 28)
            {
                return 3;
            }
            else if(Age == 29)
            {
                return 4;
            }
            else if(Age == 30)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
    }
}
