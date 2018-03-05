using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public enum Movement {Left,Up,Right,Bottom };
   public class SnakeSettings
    {
        public  int width { get; set; }
        public  int height { get; set; }
        public  int speed { get; set ; }
       // public   int score { get; set; }
        public  int points { get; set; }
        public static bool GameOver { get; set; }
        public  Movement Move { get; set; }
        public SnakeSettings()
        {
            width = 15;
            height = 15;
            speed = 8;
            //score = 0;
            points = 0;
            GameOver = false;
            Move = Movement.Up;
        }
       //public void set_speed(int speed1)
       //{
       //    speed = speed1;
       //}
    }
}
