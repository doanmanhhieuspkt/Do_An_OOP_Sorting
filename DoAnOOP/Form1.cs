using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trbSleep.Value = 25;
            IntRectangle.Graphics = pnlPain.CreateGraphics();
            IntRectangle.Label = lbComArray;
            IntRectangle.Max_height = pnlPain.Height - IntRectangle.Padding;
            lbSleep.Text = "Delay : " + trbSleep.Value.ToString() + "ms";
            rdBS.Checked = true;

        }
        private int[] A;
        private int Length=600;
        private IntRectangles intRectangles;
        private bool isTaoMang = false;
        private Thread thread;
        private void CreateInts()
        {
            try
            {
                Length = int.Parse(txbLength.Text.ToString());
                A = new int[Length];
                
                IntRectangle.Width = (pnlPain.Width - 2*IntRectangle.Padding) / A.Length;
                while ((IntRectangle.Width + 1) * A.Length + 2* IntRectangle.Padding >= pnlPain.Width)
                {
                    IntRectangle.Width--;
                }
                if (IntRectangle.Width < 1)
                {
                    IntRectangle.Width = 1;
                }
                Random rd = new Random();

                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = rd.Next(1, pnlPain.Height- 2*IntRectangle.Padding);

                }
                isTaoMang = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a positive integer", "Notification");
               
            }
        }
        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (isTaoMang == false)
            {
                return;
            }
            if (intRectangles.IsALive == true)
            {
                btnSort.Enabled = false;
                return;
            }
          
            thread = new Thread(intRectangles.BubbleSort);
            if (rdIS.Checked)
            {
                thread = new Thread(intRectangles.InsertionSort);
            }
            if (rdQS.Checked)
            {
                thread = new Thread(intRectangles.QuickSort);
            }
            if (rdMS.Checked)
            {
                thread = new Thread(intRectangles.MergeSort);
            }
            if (rdHeapSort.Checked)
            {
                thread = new Thread(intRectangles.HeapSort);
            }
            if (rdShellSort.Checked)
            {
                thread = new Thread(intRectangles.shellSort);
            }
            if (rdSelectionSort.Checked)
            {
                thread = new Thread(intRectangles.selectionSort);
            }
            thread.IsBackground = true;
            thread.Start();
            isHuy = true;
            intRectangles.IsALive = true;
            btnSort.Enabled = false;
        }
        private void Reset()
        {
            if (isTaoMang == false)
            {
                return;
            }
            intRectangles = new IntRectangles(A);
            IntRectangle.Sleep = trbSleep.Value;
            intRectangles.FillIntRectangles();
            if (isHuy)
            {
                thread.Abort();
            }
            btnPause.Text = "Pause";
            btnSort.Enabled = true;
            intRectangles.IsALive = false;
        }
        private bool isHuy;
       
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void TrbSleep_Scroll(object sender, EventArgs e)
        {
            if (isTaoMang == false)
            {
                trbSleep.Value = 25;
                return;
            }
            IntRectangle.Sleep = trbSleep.Value;
            lbSleep.Text = "Delay : " + trbSleep.Value.ToString() + "ms";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult messageresult = MessageBox.Show("Do you want to exit?", "SORTING ALGORITHMS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (messageresult == DialogResult.OK)
            {
                Close();
            }

        }
        private void RdBS_CheckedChanged(object sender, EventArgs e)
        {
            Reset();

        }
        private void RdIS_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }
        private void RdQS_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }
        private void RdMS_CheckedChanged(object sender, EventArgs e)
        {
            Reset();

        }
        private void RdHeapSort_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }
        private void RdShellSort_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void RdSelectionSort_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnCreateArray_Click(object sender, EventArgs e)
        {
            CreateInts();
            if (isTaoMang == false)
            {
                return;
            }
            Reset();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (isTaoMang == false)
            {
                return;
            }
            if (intRectangles.IsALive)
            {
                if (btnPause.Text.ToString() == "Pause")
                {
                    thread.Suspend();
                    btnPause.Text = "Resume";
                    isHuy = false;
                }
                else
                {
                    thread.Resume();
                    btnPause.Text = "Pause";
                    isHuy = true;
                }
            }
        }
    }
}
