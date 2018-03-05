using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    internal class Button_Detector
    {
        private static Hashtable Buttons = new Hashtable();
        public static bool ButtonPressed(System.Windows.Forms.Keys key)
        {
            if (Buttons[key] == null)
            {
                return false;
            }
            else
                return (bool)Buttons[key];
        }
        public static void ButtonChanged(System.Windows.Forms.Keys key, bool state)
        {
            Buttons[key] = state;
        }


        //internal static bool ButtonPressed(System.Windows.Forms.Keys keys)
       // {
            //throw new NotImplementedException();
        //}

        //internal static bool ButtonPressed(keys key)
        //{
        //    if (Buttons[key] == null)
        //    {
        //        return false;
        //    }
        //    else
        //        return (bool)Buttons[key];
        //}

        //internal static bool ButtonPressed(System.Windows.Forms.Keys keys)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static bool ButtonPressed(System.Windows.Forms.Keys keys)
        //{
        //   if (Buttons == null)
        //    {
        //        return false;
        //    }
        //    else
        //        return true;
        //}
    }
}
