using System;

namespace Polymorphism
{
    internal class Program
    {
        internal static void Console_life(ref All_Info all_info)
        {
            while (true)
            {
                while (all_info.window.index_user == -1)
                {
                    all_info.window.index_user = Windows_Action.Windows_Begin(ref all_info.window, ref all_info);
                }
                if (IN.Main_Page(ref all_info) == -1)
                    return;     
            }
        }

        internal static void Main()
        {
            Console.Title = "Больница";
            All_Info all_info = new(Constants.CORDS_WINDOW_X, Constants.CORDS_WINDOW_Y, Constants.SIZE_WINDOW_X, Constants.SIZE_WINDOW_Y);
            Console.CursorVisible = false;
            while (true)
            {
                Console_life(ref all_info);
                all_info.window.index_user = -1;
            }
        }
    }
}

