using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
   class Position_snake
    {
        public  int Horizontal { get; set; }
        public  int Vertical { get; set; }
       public Position_snake()
        {
            Horizontal = 0;
            Vertical = 0;
        }
    }
}
