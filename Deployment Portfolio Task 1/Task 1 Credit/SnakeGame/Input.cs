using System.Collections; 
using System.Windows.Forms;

//Coding Reference: https://www.mooict.com/c-tutorial-create-a-classic-snake-game-in-visual-studio/

namespace SnakeGame
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();
        public static bool KeyPress(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}