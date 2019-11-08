using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace DoAnOOP
{
    class IntRectangles
    {
        IntRectangle[] intRectangles;
        private bool isALive;
        private static Label label;
        private Color quickColor = Color.Green;
        private static Color selecColor = Color.Green;

        public bool IsALive { get => isALive; set => isALive = value; }

        public IntRectangles(int[] A)
        {
            IntRectangle.Comparisons = 0;
            IntRectangle.Arrayaccesses = 0;
            intRectangles = new IntRectangle[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                intRectangles[i] = new IntRectangle(A[i], i);
            }
        }
        public void FillIntRectangles()
        {
            IntRectangle.Graphics.Clear(IntRectangle.IrbackgourdColor);
            for(int i = 0; i < intRectangles.Length; i++)
            {
                intRectangles[i].Fill();
            }
        }
        public void FinishFill()
        {
            for (int i = 0; i < intRectangles.Length; i++)
            {
               
                intRectangles[i].Fill(Color.Yellow,1);
            }
        }
        public IntRectangle this[int index]
        {
            get
            {
                IntRectangle.Arrayaccesses++;
                IntRectangle.Label.Text = IntRectangle.Comparisons + " comparisons, " + IntRectangle.Arrayaccesses + " array accesses";
                Color color = intRectangles[index].IsColor;
                intRectangles[index].Fill(Color.White);
                Thread.Sleep(IntRectangle.Sleep);
                intRectangles[index].Fill(color);
                return intRectangles[index];
            }

        }
        public void BubbleSort()
        {

            for (int i = 0; i < intRectangles.Length; i++)
            {
                for (int j = 0; j < intRectangles.Length - 1; j++)
                {
                    if (this[j] > this[j + 1])
                    {
                        IntRectangle.Swap(ref intRectangles[j],ref intRectangles[j + 1]);
                    }

                }
            }
            FinishFill();
            isALive = false;
            
        }
        public void InsertionSort()
        {
            insertionSort(0, intRectangles.Length - 1);
            FinishFill();
            isALive = false;
            
        }
        private void insertionSort(int left, int right)
        {
            int  j;
            IntRectangle t;
            for (int i = left + 1; i <= right; i++)
            {
                j = i - 1;
                t = this[i];
                while (j >= 0 && t < this[j])
                {
                   // intRectangles[j].Fill(Color.White);
                    IntRectangle.Set(ref intRectangles[j+1],ref intRectangles[j]);
                    
                    j--;
                }
                IntRectangle.Set(ref intRectangles[j+1], ref t);
                IntRectangle.Arrayaccesses--;

            }

        }
        public void QuickSort()
        {
            quickSort(0, intRectangles.Length - 1);
            FinishFill();
            isALive = false;
            
        }
        private void quickSort(int low, int high)
        {
            if (low < high)
            {

                intRectangles[low].Fill(quickColor);
                intRectangles[high].Fill(quickColor);
                int pi = partition(low, high);

                quickSort(low, pi - 1);
                quickSort(pi + 1, high);
                intRectangles[low].Fill(IntRectangle.IrColor);
                intRectangles[high].Fill(IntRectangle.IrColor);
            }
        }
        private int partition(int low, int high)
        {

            IntRectangle pivot = this[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {


                if (this[j] < pivot)
                {
                    i++;
                   IntRectangle.Swap(ref intRectangles[i],ref intRectangles[j]);
                }
                intRectangles[low].Fill(quickColor);

                intRectangles[high].Fill(quickColor);
            }
            IntRectangle.Swap(ref intRectangles[i+1], ref intRectangles[high]);
            intRectangles[low].Fill(quickColor);
            intRectangles[high].Fill(quickColor);
            return (i + 1);
        }
        private void merge(int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            IntRectangle[] L = new IntRectangle[n1];

            IntRectangle[] R = new IntRectangle[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = this[l + i];

            }
            for (j = 0; j < n2; j++)
            {
                R[j] = this[m + 1 + j];

            }


            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {

                if (L[i] <= R[j])
                {

                   IntRectangle.Set(ref intRectangles[k], ref L[i]);
                    IntRectangle.Arrayaccesses--;

                    i++;
                }
                else
                {
                    IntRectangle.Set(ref intRectangles[k],ref R[j]);
                    IntRectangle.Arrayaccesses--;
                    j++;
                }
                k++;
            }


            while (i < n1)
            {

                IntRectangle.Set(ref intRectangles[k], ref L[i]);
                IntRectangle.Arrayaccesses--;
                i++;
                k++;
            }


            while (j < n2)
            {

                IntRectangle.Set(ref intRectangles[k], ref R[j]);
                IntRectangle.Arrayaccesses--;
                j++;
                k++;
            }
        }
        private void mergeSort(int l, int r)
        {
            if (l < r)
            {

                int m = l + (r - l) / 2;


                mergeSort(l, m);
                mergeSort(m + 1, r);

                merge(l, m, r);
            }
        }
        public void MergeSort()
        {
            mergeSort(0, intRectangles.Length - 1);

            FinishFill();
            isALive = false;
        }

        private void heapify(int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;


            if (l < n && this[l] > this[largest])
                largest = l;

            if (r < n && this[r] > this[largest])
                largest = r;


            if (largest != i)
            {
                IntRectangle.Swap(ref intRectangles[i], ref intRectangles[largest]);


                heapify(n, largest);
            }

        }
        private void heapSort(int n)
        {

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(n, i);

            }

            for (int i = n - 1; i >= 0; i--)
            {

                IntRectangle.Swap(ref intRectangles[0], ref intRectangles[i]);

                heapify(i, 0);
            }
        }
        public void HeapSort()
        {
            heapSort(intRectangles.Length);
            FinishFill();
            isALive = false;
            
        }



        public void shellSort()
        {
            for (int gap = intRectangles.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < intRectangles.Length; i += 1)
                {
                    IntRectangle temp = this[i];


                    int j;
                    for (j = i; j >= gap && this[j - gap] > temp; j -= gap)
                    {

                       IntRectangle.Set(ref intRectangles[j],ref intRectangles[j - gap]);



                    }
                    IntRectangle.Set(ref intRectangles[j],ref temp);
                    IntRectangle.Arrayaccesses--;
                }
            }
            FinishFill();
            isALive = false;
           
        }


        public void selectionSort()
        {
            int i, j, min_idx;


            for (i = 0; i < intRectangles.Length - 1; i++)
            {

                min_idx = i;
                intRectangles[min_idx].Fill(selecColor);
                for (j = i + 1; j < intRectangles.Length; j++)
                {

                    if (this[j] < this[min_idx])
                    {
                        intRectangles[min_idx].Fill();
                        min_idx = j;
                        Thread.Sleep(IntRectangle.Sleep/2);
                        intRectangles[min_idx].Fill(selecColor);
                        

                    }

                }

                
                IntRectangle.Swap(ref intRectangles[min_idx], ref intRectangles[i]);
            }
            FinishFill();
            isALive = false;
            
        }

    }
}

    
