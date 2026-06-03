using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Texas_älskar_saker_upp_i_röven__sorterings_algoritmer_
{
    public partial class Form1 : Form
    {
        static int ArraySize = 20;
        Random BBC = new Random();
        int[] NummerArray = new int[ArraySize];
        List<int> Numberos = new List<int>();
        int RndInt;

        int sortedIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        public async Task Listmaker()
        {
            ItemBox.Items.Clear();
            Numberos.Clear();

            while (Numberos.Count < ArraySize)
            {
                RndInt = BBC.Next(1, ArraySize);
                Numberos.Add(RndInt);
            }

            NummerArray = Numberos.ToArray();
            await Listfiller();
        }

        async Task Listfiller(int i1 = -1, int i2 = -1)
        {
            ItemBox.Items.Clear();

            for (int i = 0; i < NummerArray.Length; i++)
            {
                ItemBox.Items.Add(NummerArray[i]);
            }

            ItemBox.Refresh();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
        }

        // 🔵 Bubble Sort
        private async void SortBtn_Click(object sender, EventArgs e)
        {
            await Listmaker();
            await Task.Delay(2500);

            int temp;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 0; i < NummerArray.Length - 1; i++)
                {
                    if (NummerArray[i] > NummerArray[i + 1])
                    {
                        temp = NummerArray[i];
                        NummerArray[i] = NummerArray[i + 1];
                        NummerArray[i + 1] = temp;

                        sorted = false;
                    }

                    await Listfiller(i, i + 1);
                    await Task.Delay(50);
                }

                sortedIndex++;
            }
        }

        // 🟢 Counting Sort (ersätter Selection Sort)
        private async void CountingSortBtn_Click(object sender, EventArgs e)
        {
            await Listmaker();
            await Task.Delay(2500);

            sortedIndex = -1;

            int max = NummerArray.Max();
            int min = NummerArray.Min();
            int range = max - min + 1;

            int[] count = new int[range];

            // 🔹 Räkna
            for (int i = 0; i < NummerArray.Length; i++)
            {
                count[NummerArray[i] - min]++;

                await Listfiller(i);
                await Task.Delay(50);
            }

            // 🔹 Skriv tillbaka
            int index = 0;

            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    NummerArray[index] = i + min;

                    await Listfiller(index);
                    await Task.Delay(100);

                    index++;
                    count[i]--;
                }
            }
        }

        // 🔴 Quick Sort (async)
        private async Task QuickSortAsync(int left, int right)
        {
            if (left >= right)
                return;

            int pivot = NummerArray[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (NummerArray[j] < pivot)
                {
                    int temp = NummerArray[i];
                    NummerArray[i] = NummerArray[j];
                    NummerArray[j] = temp;

                    await Listfiller(i, j);
                    await Task.Delay(50);

                    i++;
                }

                await Listfiller(i, j);
                await Task.Delay(20);
            }

            int temp2 = NummerArray[i];
            NummerArray[i] = NummerArray[right];
            NummerArray[right] = temp2;

            await Listfiller(i, right);
            await Task.Delay(100);

            await QuickSortAsync(left, i - 1);
            await QuickSortAsync(i + 1, right);
        }

        // 🔘 QuickSort knapp
        private async void SortingButton_Click(object sender, EventArgs e)
        {
            await Listmaker();
            await Task.Delay(2500);

            sortedIndex = -1;

            await QuickSortAsync(0, NummerArray.Length - 1);

            // Visa slutet snyggt
            for (int i = 0; i < NummerArray.Length; i++)
            {
                sortedIndex = i;
                await Listfiller(i);
                await Task.Delay(30);
            }
        }
    }
}