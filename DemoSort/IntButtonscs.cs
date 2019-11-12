using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
namespace DemoSort
{
    class IntButtons
    {
        IntButton[] intButtons;
        public IntButtons(int[] A)
        {
            intButtons = new IntButton[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                intButtons[i] = new IntButton(A[i]);
                intButtons[i].Location = new Point(i * ThongSo.WigthIntButton + ThongSo.PaddingPanel, ThongSo.Panel.Height - ThongSo.PaddingBotPanel - A[i]-20);
            }
        }
        public void Add()
        {
            for(int i = 0; i < intButtons.Length; i++)
            {
 
                ThongSo.Panel.Controls.Add(intButtons[i]);
            }
        }
        public void Add(IntButton[] ints)
        {
            for (int i = 0; i < intButtons.Length; i++)
            {

                ThongSo.Panel.Controls.Add(ints[i]);
            }
        }
        public void Del(IntButton[] ints)
        {
            for (int i = 0; i < intButtons.Length; i++)
            {
                ThongSo.Panel.Controls.Remove(ints[i]);
            }
        }
        public void Del()
        {
            for (int i = 0; i < intButtons.Length; i++)
            {
                ThongSo.Panel.Controls.Remove(intButtons[i]);
            }
        }
        private IntButton this[int index]
        {
            get
            {
                ThongSo.onArrayaccesses();
                return intButtons[index];
            }
        }
        public void BubbleSort()
        {
            for (int i = 0; i < intButtons.Length; i++)
            {
                for (int j = 0; j < intButtons.Length - i-1; j++)
                {
                  
                    intButtons[j ].BackColor = Color.Green;
                    Thread.Sleep(ThongSo.Sleep);
                    
                    if (this[j]> this[j + 1])
                    {
                        intButtons[j+1].BackColor = Color.Green;
                        Thread.Sleep(ThongSo.Sleep);
                        IntButton.Swap(ref intButtons[j],ref intButtons[j+1]);
                      
                        Thread.Sleep(ThongSo.Sleep);
                     


                    }
                    intButtons[j].BackColor = Color.White;
                    intButtons[j + 1].BackColor = Color.Yellow;
                }

            }
            intButtons[0].BackColor = Color.Yellow;
        }
        public void InsertionSort()
        {
            int j;
            int t;
            intButtons[0].BackColor = Color.Yellow;
            for (int i = 1; i < intButtons.Length; i++)
            {
                j = i - 1;
                t = this[i].Value;
                ThongSo.onArrayaccesses();
                intButtons[i].Location = new Point(intButtons[i].Location.X, ThongSo.Panel.Height - ThongSo.PaddingBotPanel +2);
                intButtons[i].BackColor = Color.Aqua;
                Thread.Sleep(ThongSo.Sleep);
            while (j >= 0 && t < intButtons[j])
                {
                    Thread.Sleep(ThongSo.Sleep);
                    IntButton.Set(ref intButtons[j + 1], intButtons[j].Value);
                    ThongSo.onArrayaccesses();
                    ThongSo.onArrayaccesses();
                    intButtons[j + 1].BackColor = Color.Yellow;
                    intButtons[j].Location = new Point(intButtons[j].Location.X, ThongSo.Panel.Height - ThongSo.PaddingBotPanel + 2);
                    intButtons[j].BackColor = Color.Aqua;
                    intButtons[j].Text = t.ToString();
                    intButtons[j].Size = new Size(ThongSo.WigthIntButton, t);

                    j--;
                }
               
                IntButton.Set(ref intButtons[j + 1], t);
                ThongSo.onArrayaccesses();
                intButtons[j + 1].BackColor = Color.Yellow;
                Thread.Sleep(ThongSo.Sleep);
               
            }
        }
        private int partition(int low, int high)
        {
            int pivot = this[high].Value; // pivot  
            intButtons[high].BackColor = Color.Green;
            int i = (low - 1); // Index of smaller element  
            for (int j = low; j <= high - 1; j++)
            {
                intButtons[i + 1].BackColor = Color.Aqua;
                Thread.Sleep(ThongSo.Sleep);
          
                // If current element is smaller than the pivot  
                if (this[j] < pivot)
                {
                    i++; // increment index of smaller element  
                    intButtons[j].BackColor = Color.Gold;
                    intButtons[i].BackColor = Color.Gold;
                  
                   
                    //intButtons[i ].BackColor = ThongSo.clIntButton;
                    IntButton.Swap(ref intButtons[i],ref intButtons[j]);
                    Thread.Sleep(ThongSo.Sleep);
                    if(intButtons[j].Value<pivot)
                        intButtons[j].BackColor = Color.Blue;
                    else intButtons[j].BackColor = Color.Red;
                    intButtons[i].BackColor = Color.Blue;
                  
                }
                else intButtons[j].BackColor = Color.Red;

            }
            intButtons[i+1].BackColor = Color.Gold;
            intButtons[high].BackColor = Color.Gold;
            Thread.Sleep(ThongSo.Sleep);

            IntButton.Swap(ref intButtons[i + 1], ref intButtons[high]);
             for(int k = low; k <= high; k++)
            {
                intButtons[k].BackColor = ThongSo.clIntButton;
            }

            return (i + 1);
        }

      
        private void quickSort(int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[p] is now  
                at right place */
               
                int pi = partition( low, high);
               
                quickSort( low, pi - 1);
                quickSort(pi + 1, high);
                
            }
        }
        public void QuickSort()
        {
            quickSort(0, intButtons.Length - 1);
        }
        public void ShellSort()
        {
            for (int gap = intButtons.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < intButtons.Length; i += 1)
                {
                    int temp = this[i].Value;
                    intButtons[i].Location = new Point(intButtons[i].Location.X, ThongSo.Panel.Height - ThongSo.PaddingBotPanel + 2);
                    intButtons[i].BackColor = Color.Aqua;
                    intButtons[i - gap].BackColor = Color.Yellow;
                    Thread.Sleep(ThongSo.Sleep);
                    intButtons[i - gap].BackColor = ThongSo.clIntButton;
                    int j;
                    for (j = i; j >= gap && this[j - gap]> temp; j -= gap)
                    {
                        intButtons[j - gap].BackColor = Color.Red;
                        intButtons[j].BackColor = Color.Red;
                        Thread.Sleep(ThongSo.Sleep);
                        int x = intButtons[j].Location.X;
                        intButtons[j].Location = new Point(intButtons[j - gap].Location.X, ThongSo.Panel.Height - ThongSo.PaddingBotPanel + 2);

                        Thread.Sleep(ThongSo.Sleep);
                        IntButton.Set(ref intButtons[j], intButtons[j - gap].Value);
                        ThongSo.onArrayaccesses();
                        ThongSo.onArrayaccesses();
                        intButtons[j].Location = new Point(x, intButtons[j].Location.Y);
                 
                       
                        intButtons[j-gap].Location = new Point(intButtons[j-gap].Location.X, ThongSo.Panel.Height - ThongSo.PaddingBotPanel + 2);
                        intButtons[j-gap].BackColor = Color.Aqua;
                        intButtons[j-gap].Text = temp.ToString();
                        intButtons[j-gap].Size = new Size(ThongSo.WigthIntButton, temp);
                        Thread.Sleep(ThongSo.Sleep);
                        intButtons[j].BackColor = ThongSo.clIntButton;

                    }
                    Thread.Sleep(ThongSo.Sleep);
                    IntButton.Set(ref intButtons[j], temp);
                    ThongSo.onArrayaccesses();
                    intButtons[j].BackColor = ThongSo.clIntButton;
                    Thread.Sleep(ThongSo.Sleep);
                }
            }

            //isALive = false;

        }
        void merge( int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            int[] L=new int[n1], R=new int[n2];
           
            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
            {
                L[i] = this[l + i].Value;

              intButtons[l + i].BackColor = Color.Red;
              //  intButtons[l + i].Location = new Point(intButtons[l + i].Location.X, intButtons[l + i].Location.Y );
               

            }

            for (j = 0; j < n2; j++)
            {
                R[j] = this[m + 1 + j].Value;
              intButtons[m+1 + j].BackColor = Color.Blue;
               // intButtons[m + 1 + j].Location = new Point(intButtons[m + 1 + j].Location.X, intButtons[m + 1 + j].Location.Y );
          
            }
           
            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray 
            j = 0; // Initial index of second subarray 
            k = l; // Initial index of merged subarray 
            Thread.Sleep(ThongSo.Sleep);
            while (i < n1 && j < n2)
            {
                //  Thread.Sleep(ThongSo.Sleep);
                ThongSo.onComparisions();
                if (L[i] <= R[j])
                {
                   
                    IntButton.Set(ref intButtons[k], L[i]);
                    ThongSo.onArrayaccesses();
                    intButtons[k].BackColor = Color.Red;
                    // intButtons[k].BackColor = ThongSo.clIntButton;
                    intButtons[k].Location = new Point(intButtons[k].Location.X, intButtons[k].Location.Y + 50);
                   // arr[k] = L[i];
                    i++;
                }
                else
                {
                    //arr[k] = R[j];
                  
                    IntButton.Set(ref intButtons[k], R[j]);
                    ThongSo.onArrayaccesses();
                    intButtons[k].BackColor = Color.Blue;
                    intButtons[k].Location = new Point(intButtons[k].Location.X, intButtons[k].Location.Y + 50);
                 //   intButtons[k].BackColor = ThongSo.clIntButton;
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there 
               are any */
            while (i < n1)
            {
                //   Thread.Sleep(ThongSo.Sleep);
                // arr[k] = L[i];
                ThongSo.onComparisions();
                IntButton.Set(ref intButtons[k], L[i]);
                ThongSo.onArrayaccesses();
                intButtons[k].BackColor = Color.Red;
                intButtons[k].Location = new Point(intButtons[k].Location.X, intButtons[k].Location.Y + 50);
                //    intButtons[k].BackColor = ThongSo.clIntButton;
                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there 
               are any */
            while (j < n2)
            {
                //  Thread.Sleep(ThongSo.Sleep);
                //  arr[k] = R[j];
                ThongSo.onComparisions();
                IntButton.Set(ref intButtons[k], R[j]);
                ThongSo.onArrayaccesses();
                intButtons[k].BackColor = Color.Blue;
                intButtons[k].Location = new Point(intButtons[k].Location.X, intButtons[k].Location.Y + 50);
               // intButtons[k].BackColor = ThongSo.clIntButton;
             
                j++;
                k++;
            }
            for(int x = l; x <= r; x++)
            {
                Thread.Sleep(ThongSo.Sleep);
                intButtons[x].BackColor = ThongSo.clIntButton;
                intButtons[x].Location = new Point(intButtons[x].Location.X, intButtons[x].Location.Y - 50);
               
            }
        }

        /* l is for left index and r is right index of the 
           sub-array of arr to be sorted */
        void mergeSort( int l, int r)
        {
            if (l < r)
            {
                // Same as (l+r)/2, but avoids overflow for 
                // large l and h 
                int m = l + (r - l) / 2;

                // Sort first and second halves 
                mergeSort( l, m);
                mergeSort( m + 1, r);

                merge( l, m, r);
            }
        }
        public void MergeSort()
        {
            mergeSort(0, intButtons.Length-1);
        }
        private void heapify(int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            intButtons[i].BackColor = Color.Yellow;
            
            if (l < n && this[l] > this[largest])
            {

                largest = l;

            }
            if (r < n && this[r] > this[largest])
                largest = r;


            if (largest != i)
            {
                
                intButtons[largest].BackColor = Color.Yellow;
                Thread.Sleep(ThongSo.Sleep);
                IntButton.Swap(ref intButtons[i], ref intButtons[largest]);
                Thread.Sleep(ThongSo.Sleep);
                intButtons[i].BackColor = ThongSo.clIntButton;
                intButtons[largest].BackColor = ThongSo.clIntButton;
                heapify(n, largest);
            }
            intButtons[i].BackColor = ThongSo.clIntButton;


        }
        private void heapSort(int n)
        {

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(n, i);

            }

            for (int i = n - 1; i >= 0; i--)
            {
                intButtons[i].BackColor = Color.Yellow;
                intButtons[0].BackColor = Color.Yellow;
                Thread.Sleep(ThongSo.Sleep);
                IntButton.Swap(ref intButtons[0], ref intButtons[i]);
                Thread.Sleep(ThongSo.Sleep);
                intButtons[i].BackColor = ThongSo.clIntButton;
                intButtons[0].BackColor = ThongSo.clIntButton;
                heapify(i, 0);
            }
        }
        public void HeapSort()
        {
            heapSort(intButtons.Length);
           

        }
        public void selectionSort()
        {
            int i, j, min_idx;


            for (i = 0; i < intButtons.Length - 1; i++)
            {

                min_idx = i;
               
                for (j = i + 1; j < intButtons.Length; j++)
                {
                    intButtons[j].BackColor = Color.Aqua;
                    intButtons[i].BackColor = Color.Green;
                    Thread.Sleep(ThongSo.Sleep);
                  
                    if (this[j] < this[min_idx])
                    {
                        if(min_idx!=i)
                        intButtons[min_idx].BackColor=ThongSo.clIntButton;
                        min_idx = j;
                        intButtons[min_idx].BackColor = Color.Red;
                        Thread.Sleep(ThongSo.Sleep);


                    }
                    else
                    {
                        intButtons[j].BackColor = ThongSo.clIntButton;
                    }

                }
                intButtons[min_idx].BackColor = Color.Blue;
                intButtons[i].BackColor = Color.Blue;
                Thread.Sleep(ThongSo.Sleep);
                IntButton.Swap(ref intButtons[min_idx], ref intButtons[i]);
                Thread.Sleep(ThongSo.Sleep);
                intButtons[min_idx].BackColor = ThongSo.clIntButton;
                intButtons[i].BackColor =Color.Yellow;

            }

            intButtons[intButtons.Length - 1].BackColor = Color.Yellow;

        }

    }

}
