using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseShip
{
    class CruiseLine: Travel
    {
        public CruiseLine() { }
        public CruiseLine (int age) { }
        public string GetCruise()
        {
        switch (base.SwitchValue())
            {
                case 1:
                    ReturnValue = "Disney";
                    return ReturnValue;
                    break;

                case 2:
                    ReturnValue = "Norwegian";
                    return ReturnValue;
                    break;

                case 3:
                    ReturnValue = "Royal Caribbean";
                    return ReturnValue;
                    break;

                case 4:
                    ReturnValue = "Princess";
                    return ReturnValue;
                    break;

                case 5:
                    ReturnValue = "Celebrity";
                    return ReturnValue;
                    break;
                default:
                    ReturnValue = "Raft";
                    return ReturnValue;
                    break;

            }
        }
    }
}
