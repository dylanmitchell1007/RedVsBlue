using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVsBlue
{
    class Party
    {
       public List<Player> Squad = new List<Player>();
       public int ID = 0;//CurrentPlayer
        /// <summary>
        /// This Party Default Constructor.
        /// </summary>
        public Party() { }
        /// <summary>
        /// This is the container with the Players in it.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        public void AddPlayer(Player p)
        {
            Squad.Add(p);
            p.onEndTurn += NextPlayer;

        }
      
       public void NextPlayer()
        {
            ID++;

        }
         
        
    
    }
   



}
