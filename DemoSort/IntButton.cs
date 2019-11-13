using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace DemoSort
{
    class IntButton : Button
    {
        private int value;

        public int Value { get => value; set => this.value = value; }

        public IntButton(int value) : base()
        {
            this.value = value;
            Text = value.ToString();
            Size = new Size(ThongSo.WigthIntButton, value+20);
            BackColor = ThongSo.clIntButton;
        }
        public IntButton(IntButton intButton) : base()
        {
            this.value =intButton.value;
            Text =intButton.Text;
            Size = new Size(ThongSo.WigthIntButton, value);
            BackColor = intButton.BackColor;
            Location = intButton.Location;

        }
        public static bool operator <(IntButton a, IntButton b)
        {
            ThongSo.onComparisions();
            return a.value < b.value;
        }
        public static bool operator <(IntButton a, int b)
        {
            ThongSo.onComparisions();
            return a.value < b;
        }
        public static bool operator <( int b, IntButton a)
        {
            ThongSo.onComparisions();
            return a.value > b;
        }
        public static bool operator >(int b, IntButton a)
        {
            ThongSo.onComparisions();
            return a.value < b;
        }
        public static bool operator >(IntButton a, int b)
        {
            ThongSo.onComparisions();
            return a.value > b;
        }
        public static bool operator >(IntButton a, IntButton b)
        {
            ThongSo.onComparisions();
            return a.value > b.value;
        }
        public static bool operator ==(IntButton a, IntButton b)
        {
            ThongSo.onComparisions();
            return a.value == b.value;
        }
        public static bool operator >=(IntButton a, IntButton b)
        {
            ThongSo.onComparisions();
            return a.value >= b.value;
        }
        public static bool operator <=(IntButton a, IntButton b)
        {
            ThongSo.onComparisions();
            return a.value <= b.value;
        }
        public static bool operator !=(IntButton a, IntButton b)
        {
            ThongSo.onComparisions();
            return a.value != b.value;
        }
        public IntButton(IContainer contaiter)
        {
            contaiter.Add(this);

        }
        public static void Swap(ref IntButton a,ref IntButton b)
        {
            ThongSo.onArrayaccesses();
            ThongSo.onArrayaccesses();
            Point tLocation = a.Location;
            string tText = a.Text;
            Color tBackColor= a.BackColor;
            int tValue = a.value;
            Size tSize = a.Size;
          
            a.Location = new Point(a.Location.X, b.Location.Y);
            a.Text = b.Text;
            a.Size = b.Size;
            a.value = b.value;
            a.BackColor = b.BackColor;
            b.Location = new Point(b.Location.X, tLocation.Y);
            b.Text = tText;
            b.Size = tSize;
            b.value = tValue;
            b.BackColor = tBackColor;
        }
        public static void Set(ref IntButton a,  int b)
        {
            a.value = b;
            a.Location = new Point(a.Location.X, ThongSo.Panel.Height - ThongSo.PaddingBotPanel - a.value-20);
            a.Text = b.ToString();
         
            a.Size = new Size(ThongSo.WigthIntButton, a.value+20);

        }

    }
}
