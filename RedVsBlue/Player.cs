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

        public Player(int pHealth, string pName)
        {
            health = pHealth;
            name = pName;




        }




       int health;
        public int Health
        {
            get { return health;}
            set { health = value;}
        }
       string name;
       public string Name
        {
            get { return name; }
            set { name = value;}
        }

       int attack = 20;
       

        public delegate void OnEndTurn();
        public OnEndTurn onEndTurn;

        /// <summary>
        /// This End Turns for each players
        /// </summary>
        public void EndTurn()
        {
        if (onEndTurn != null)
            {
                onEndTurn.Invoke();
            }
        
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
