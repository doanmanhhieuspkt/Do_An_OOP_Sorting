using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace DemoSort
{
    class ThongSo
    {
        private static int wigthIntButton=20;
        private static int paddingPanel;
        private static int paddingBotPanel=100;
        private static int sleep;
        private static Color intButton=Color.White;
        private static Color swap;
        private static Color index;
        private static int arrayaccesses=0;
        private static int comparisons=0;
        private static Label ac;
        private static bool isAlive;
        private static Panel panel;
        public static bool IsAlive { get => isAlive; set => isAlive = value; }
        public static int WigthIntButton { get => wigthIntButton; set => wigthIntButton = value; }
        public static int PaddingPanel { get => paddingPanel; set => paddingPanel = value; }
        public static int Sleep { get => sleep; set => sleep = value; }
        public static Color clSwap { get => swap;}
        public static Color clIndex { get => index;}
        public static Color clIntButton { get => intButton; }
        public static int Arrayaccesses { set => arrayaccesses = value; }
        public static int Comparisons { set => comparisons = value; }
        public static Label Ac { set => ac = value; }
      //  public static int HeightPanel { get => Panel.Height; }
        public static int WightPanel { get => Panel.Width;}
        public static Panel Panel { get => panel; set => panel = value; }
        public static int PaddingBotPanel { get => paddingBotPanel; set => paddingBotPanel = value; }

        public static void onComparisions()
        {
            comparisons++;

            if (ac != null)
                ac.Text = comparisons + " comparisons, " + arrayaccesses + " array accesses";

        }
        public static void onArrayaccesses()
        {
            arrayaccesses++;
            if (ac != null)
                ac.Text = comparisons + " comparisons, " + arrayaccesses + " array accesses";

        }
    }
}
