using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] SortArray;

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            txtSort.Text = "";

            int[] MyArray = new int[dgvMas.ColumnCount];
            for (int i = 0, n = dgvMas.ColumnCount; i < n; i++)
            {
                MyArray[i] = (int)dgvMas.Rows[0].Cells[i].Value;
            }
            SortArray = QuickSort(MyArray);

            foreach (var item in SortArray)
            {
                txtSort.Text += item + " ";
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            int K = 4;
            int Size = (int)(20 + 0.6 * K);
            dgvMas.ColumnCount = Size;
            Random ran = new Random();

            for (int i = 0; i < Size; i++)
            {
                dgvMas.Rows[0].Cells[i].Value = ran.Next(10, 100);
            }
        }
        static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }

            var middle = (first + last) / 2;
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                while (middle != 0 && array[middle - 1] == searchedValue)
                    middle--;
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "" || SortArray.Length == 0)
            {
                MessageBox.Show("Введіть зачення!");
            }
            else
            {
                int N = 0;
                int search = int.Parse(tbSearch.Text);
                int res = BinarySearch(SortArray, search, 0, SortArray.Length);
                txtResult.Text = "";
                while (SortArray[res] == search)
                {
                    txtResult.Text += $"Ar[{res}] = " + SortArray[res] + "\r\n";
                    N++;
                    res++;
                }
                txtResult.Text += "\r\n" +
                    $"Кількість елиментів, що дорівнюють {search}: {N}";

            }
        }
    }
}
