using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBoard
{
    public abstract class Animal
    {
        public char Species  { get; set; }
        protected string Gender { get; set; }
  
        protected double Weight { get; set; }
        protected bool Alive { get; set; }
        public Tile Tile { get; set; } //eksistere kun på Tile indbyrdes reference

        protected Board Board;

        //public abstract int eat();
        //public abstract int getMove();


    }
}
