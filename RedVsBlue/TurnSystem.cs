using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVsBlue
{
    class TurnSystem
    {
        List<Party> Parties;
        TurnSystem()
        {
            Parties = new List<Party>();
        }


        
        public Player ActivePlayer = new Player();
        public Party ActiveParty = new Party();
        
        public ActiveParty.ActivePlayer[];    
        //ActiveParty.members[currentPlayerIndex]
        /// <summary>
        /// If it is not a Players turn they will be placed in queue
        /// </summary>
        public void Queue()
        {
            
                
        }
        
        public void EndTurn()
        {
            
            
        }



    }
}
