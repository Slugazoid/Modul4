using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022400122
{
    internal class MesinKopi
    {
        public enum State { OFF, STANDBY, BREWING, MAINTENANCE }
        public enum Trigger { POWER_ON,  POWER_OFF, START_BREW, FINISH_BREW, START_MAINTENANCE, FINISH_MAINTENANCE }
        private State currentState;
        public MesinKopi()
        {
            currentState = State.OFF;
            Console.WriteLine("Mesin Kopi Mati");
        }
        public void ubahState(Trigger trigger) 
        {
            //currentState = State.OFF;
            State nextState = currentState;
            Console.WriteLine(currentState);
            switch (currentState)
            { 
                case State.OFF:
                    if (trigger == Trigger.POWER_ON)
                    {
                        nextState = State.STANDBY;
                    }
                    else if (trigger == Trigger.POWER_OFF)
                    {
                        nextState = State.OFF;
                    }
                    break;

                case State.STANDBY:
                    if(trigger == Trigger.START_BREW)
                    {
                        nextState = State.BREWING;
                    }
                    else if (trigger == Trigger.POWER_OFF)
                    {
                        nextState = State.OFF;
                    }
                    else if (trigger == Trigger.START_MAINTENANCE)
                    {
                        nextState = State.MAINTENANCE;
                    }
                    break;

                case State.BREWING:
                    if (trigger == Trigger.FINISH_BREW)
                    {
                        nextState = State.STANDBY;
                    }
                    else if (trigger == Trigger.START_BREW)
                    {
                        nextState = State.BREWING;
                    }
                    break;
                    
                case State.MAINTENANCE:
                    if (trigger == Trigger.FINISH_MAINTENANCE)
                    {
                        nextState = State.STANDBY;
                    }
                    else if (trigger == Trigger.START_MAINTENANCE)
                    {
                        nextState = State.MAINTENANCE;
                    }
                    break;
            }
            currentState = nextState;
            if (trigger == Trigger.POWER_ON)
            {
                Console.WriteLine("Mesin off berubah menjadi Standby");
            }
            else if (trigger == Trigger.START_BREW)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
            }
            else if (trigger == Trigger.FINISH_BREW)
            {
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
            }
            else if (trigger == Trigger.START_MAINTENANCE)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
            }
            else if (trigger == Trigger.FINISH_MAINTENANCE)
            {
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
            }
            else if (trigger == Trigger.POWER_OFF)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Off");
            }

        }
    }
}
