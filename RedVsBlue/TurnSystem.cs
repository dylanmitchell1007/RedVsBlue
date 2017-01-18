using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVsBlue
{
    class TurnSystem
    {
        
        public TurnSystem()
        {
            
        }



        public Player ActivePlayer = new Player();
        public Party ActiveParty = new Party();

        public void Startup(Party One, Party Two)
        {
            ActiveParty = One;
            ActivePlayer = One.Squad[One.ID];
        }

        public void CurrentPlayer()
        {
            if(ActiveParty.ID >= ActiveParty.Squad.Count())
            {
                
            }


            ActivePlayer = ActiveParty.Squad[ActiveParty.ID];
            
        }
        


    }
}
