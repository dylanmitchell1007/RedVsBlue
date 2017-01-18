using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVsBlue
{
    //
    class Player
    {
        /// <summary>
        /// This is Player Default Constructor.
        /// </summary>
        public Player() { }
        public int health = 100;
        public string Name;
        public int attack = 20;
        public int ID = 0;
        delegate void onEndTurn()
        {
            OnEndTurn  
        }
        /// <summary>
        /// This End Turns for each players
        /// </summary>
        public void EndTurn()
        {
        if (OnEndTurn != null) ;
        
          //if each player goes in each party, go to the next party and cycle through
         
        }
        /// <summary>
        /// This is the Attack Function that each Player will have
        /// </summary>
        public void Attack()
        {
           

        }

        /// <summary>
        /// This is the Defend Function that each Player will have
        /// </summary>
        public void Defend()
        {


        }
    }
 
    




}
