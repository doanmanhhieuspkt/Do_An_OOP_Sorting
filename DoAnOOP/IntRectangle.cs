using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP
{
    class IntRectangle
    {
        private int value;
        private int mindex;
        private Rectangle rectangle;
        private static Graphics graphics;
        private static int width;
        private static int sleep;
        private static int max_height;
        private static int padding = 30;
        private static long comparisons=0 ;
        private static long arrayaccesses=0 ;
        private static Label label;
        private static Color irColor = Color.Red;
        private static Color irbackgourdColor = SystemColors.GrayText;
        private static Color ircolorSwap = Color.Blue;
        private Color isColor = Color.Red;

        public IntRectangle(int value, int i)
        {
            this.mindex = i;
            this.value = value;
            rectangle = new Rectangle(i * (width + 1) + padding, max_height - this.value, width, this.value);
           
        }
        public IntRectangle(IntRectangle x)
        {
            this.mindex = x.mindex;
            this.rectangle = x.rectangle;
            this.value = x.value;
        }
      

        private static void onComparisions()
        {
            comparisons++;
       

              Label.Text = comparisons + " comparisons, " + arrayaccesses + " array accesses";
     
        }
        public void Fill()
        {
            isColor = Color.Red;
            graphics.FillRectangle(new SolidBrush(irColor), this.rectangle);
        }
        public void Fill(Color color)
        {
            isColor = color;
            graphics.FillRectangle(new SolidBrush(color), this.rectangle);
        }
        public void Fill(Color color,int asleep)
        {
            Thread.Sleep(asleep);
            graphics.FillRectangle(new SolidBrush(color), this.rectangle);
        }
        public static bool operator < (IntRectangle a,IntRectangle b)
        {
            onComparisions();
            return a.value < b.value;
        }
        public static bool operator >(IntRectangle a, IntRectangle b)
        {
            onComparisions();
            return a.value > b.value;
        }
        public static bool operator >=(IntRectangle a, IntRectangle b)
        {
            onComparisions();
            return a.value >= b.value;
        }
        public static bool operator <=(IntRectangle a, IntRectangle b)
        {
            onComparisions();
            return a.value <= b.value;
        }
        public static bool operator ==(IntRectangle a, IntRectangle b)
        {
            onComparisions();
            return a.value == b.value;
        }
        public static bool operator !=(IntRectangle a, IntRectangle b)
        {
            onComparisions();
            return a.value != b.value;
        }
        public static void Set(ref IntRectangle a,ref IntRectangle  b)
        {
           
            graphics.FillRectangle(new SolidBrush(irbackgourdColor), a.rectangle);
            Thread.Sleep(sleep);
            a = new IntRectangle(b.value,a.mindex);
            arrayaccesses +=2;
            graphics.FillRectangle(new SolidBrush(irColor), a.rectangle);
        }
        public static void Swap(ref IntRectangle  i,ref IntRectangle j)
        {
            
            graphics.FillRectangle(new SolidBrush(ircolorSwap), i.rectangle);

            graphics.FillRectangle(new SolidBrush(ircolorSwap), j.rectangle);
            Thread.Sleep(sleep);
            graphics.FillRectangle(new SolidBrush(irbackgourdColor), i.rectangle);
            graphics.FillRectangle(new SolidBrush(irbackgourdColor), j.rectangle);
            arrayaccesses += 2;
            int t = i.value;
            i = new IntRectangle(j.value, i.mindex);
            j = new IntRectangle(t, j.mindex);
            graphics.FillRectangle(new SolidBrush(irColor), i.rectangle);
            graphics.FillRectangle(new SolidBrush(irColor), j.rectangle);
        }
        public static int Padding { get => padding; set => padding = value; }
        public static Label Label { get => label; set => label = value; }
        public static Graphics Graphics { get => graphics; set => graphics = value; }
        public static int Max_height { get => max_height; set => max_height = value; }
        public static int Width { get => width; set => width = value; }
        public static Color IrbackgourdColor { get => irbackgourdColor; }
        public static Color IrColor { get => irColor;}
        public static int Sleep { get => sleep; set => sleep = value; }
        public static long Comparisons { get => comparisons; set => comparisons = value; }
        public static long Arrayaccesses { get => arrayaccesses; set => arrayaccesses = value; }
        public Color IsColor { get => isColor; set => isColor = value; }
    }
}
