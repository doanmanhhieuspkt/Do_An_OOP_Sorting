using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace DemoSort
{
    public partial class Form1 : Form
    {
        private IntButtons IntButtons;
        private bool isTaoMang = false;
        private bool isHuy = false;
        private int[] A;
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
            
            ThongSo.Ac = ac;
            ThongSo.Panel = this.panel1;
        }
        private void Form1_load(object sender, EventArgs e)
        {
            CreateNew();
            trbSleep.Value = 400;
            ThongSo.Sleep = trbSleep.Value;
            lblDelay.Text = "Delay : " + trbSleep.Value.ToString() + "ms";
            thread = new Thread(IntButtons.BubbleSort);
        }
        private void CreateInt1D()
        {
            Random rd = new Random();
            try
            {
                if (int.Parse(txbLength.Text.ToString()) > 25)
                {
                    txbLength.Text = 25.ToString();
                }
                if (int.Parse(txbLength.Text.ToString()) < 2)
                {
                    txbLength.Text = 2.ToString();
                }
                int length = Int32.Parse(txbLength.Text.ToString());
                A = new int[length];
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = rd.Next(1, ThongSo.Panel.Height-ThongSo.PaddingBotPanel*2);

                }
                SizeButton();
                isTaoMang = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập một số nguyên (X<=25) ", "THÔNG BÁO");
                A = new int[25];
                txbLength.Text = 25.ToString();
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = rd.Next(1, ThongSo.Panel.Height - ThongSo.PaddingBotPanel * 2);

                }

            }

        }
        private void SizeButton()
        {
            ThongSo.PaddingPanel = 10;

            ThongSo.WigthIntButton = 35;
            ThongSo.PaddingPanel = (ThongSo.Panel.Width - ThongSo.WigthIntButton * A.Length)/2;
        }
        private void CreateNew()
        {
            CreateInt1D();

            //  IntButtons = new IntButtons(A);


            //  IntButtons.Add();
            Reset();
        }
        private void Reset()
        {
        
            if (isTaoMang == false)
            {
                return;
            }
            string str = "";
            for (int i = 0; i < A.Length - 1; i++)
            {
                str += A[i].ToString() + ";";
            }
            str += A[A.Length - 1].ToString();
            txbNhapTay.Text = str;
            txbLength.Text = A.Length.ToString();
            if(IntButtons!=null)
                IntButtons.Del();
            if (isHuy)
            {
                thread.Abort();
            }
            btnStop.Text = "Pause";
            btnSort.Enabled = true;
            lblDemoSort.Text = "DEMO SORTING ALGORITHM";
            IntButtons = new IntButtons(A);
            ThongSo.IsAlive = false;
            ThongSo.Comparisons = 0;
            ThongSo.Arrayaccesses = -1;
            ThongSo.onArrayaccesses();
            IntButtons.Add();
        }
       
        private void BtnSort_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = false;
            btnStop.Text = "Pause";
            if (rdBubbler.Checked)
            {
                lblDemoSort.Text = "          Bubbler Sort";
                thread = new Thread(IntButtons.BubbleSort);
            }
            if (rdInsertion.Checked)
            {
                lblDemoSort.Text = "          Insertion Sort";
                thread = new Thread(IntButtons.InsertionSort);
            }
            if (rdQuickSort.Checked)
            {
                lblDemoSort.Text = "          Quick Sort";
                thread = new Thread(IntButtons.QuickSort);
            }
            if (rdShell.Checked)
            {
                lblDemoSort.Text = "          Shell Sort";
                thread = new Thread(IntButtons.ShellSort);
            }
            if (rdMerge.Checked)
            {
                lblDemoSort.Text = "          Merge Sort";
                thread = new Thread(IntButtons.MergeSort);
            }
            if (rdHeapSort.Checked)
            {
                lblDemoSort.Text = "          Heap Sort";
                thread = new Thread(IntButtons.HeapSort);
            }
            if (rdSelecSort.Checked)
            {
                lblDemoSort.Text = "     Selection Sort";
                thread = new Thread(IntButtons.selectionSort);
            }
            thread.IsBackground = true;
            isHuy = true;
            ThongSo.IsAlive = true;
            thread.Start();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
           
             Reset();
        }   

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            
            
            CreateInt1D();
            Reset();
           
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult messageresult = MessageBox.Show("Bạn có muốn thoát ?", "DEMO SORTING ALGORITHMS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (messageresult == DialogResult.OK)
            {
                Close();
            }

        }
        private void TrbSleep_Scroll(object sender, EventArgs e)
        {
            ThongSo.Sleep = trbSleep.Value;
            lblDelay.Text = "Delay : " + trbSleep.Value.ToString() + "ms";
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
            {
                if (btnStop.Text.ToString() == "Pause")
                {
                    thread.Suspend();
                    isHuy = false;
                    btnStop.Text = "Continue";
                }
                else
                {
                    thread.Resume();
                    btnStop.Text = "Pause";
                    isHuy = true;
                }
            }

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            char[] spearator = { ',', ' ',';' };
            string[] tokens = txbNhapTay.Text.Split(spearator) ;
            if (tokens.Length > 25)
            {
                MessageBox.Show("Số lượng cho phép không vượt quá 25");
                return;
            }
            try
            {
                A = new int[tokens.Length];
                for(int i = 0; i < tokens.Length; i++)
                {
                    A[i] = int.Parse(tokens[i].ToString());
                    if(A[i]>(ThongSo.Panel.Height - ThongSo.PaddingBotPanel * 2) || A[i] < 0)
                    {
                        MessageBox.Show(0+"< số bạn nhập <"+ (ThongSo.Panel.Height - ThongSo.PaddingBotPanel * 2));
                        return;
                    }
                }
                SizeButton();
                isTaoMang = true;
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Xin kiểm tra lại số vừa nhập ", "Error");
            }
           
        }

    }
}
