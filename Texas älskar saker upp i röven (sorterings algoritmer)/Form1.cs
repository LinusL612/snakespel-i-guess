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
        static int ArraySize = 20; // Ändra här för att ändra storleken på arrayen (och därmed antalet element som sorteras)
        Random BBC = new Random(); // Random generator för att skapa slumpmässiga tal
        int[] NummerArray = new int[ArraySize]; // Array som ska sorteras
        List<int> Numberos = new List<int>();// Lista som används för att skapa unika slumpmässiga tal innan de kopieras till arrayen
        int RndInt; // Variabel för att hålla det slumpmässiga talet som genereras

        int sortedIndex = -1; // Håller reda på det index som är sorterat i vissa algoritmer (för visuell feedback)

        public Form1()
        {
            InitializeComponent();
        }

        public async Task Listmaker() // skapar randomised listan som ska sorteras
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

        async Task Listfiller(int i1 = -1, int i2 = -1) // fyller listboxen efter den sorterats
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

        // Bubble Sort 
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

        //Counting Sort
        private async void CountingSortBtn_Click(object sender, EventArgs e)
        {
            await Listmaker();
            await Task.Delay(2500);

            sortedIndex = -1;

            int max = NummerArray.Max();
            int min = NummerArray.Min();
            int range = max - min + 1;

            int[] count = new int[range];

            //  Räkna antalet av varje element
            for (int i = 0; i < NummerArray.Length; i++)
            {
                count[NummerArray[i] - min]++;

                await Listfiller(i);
                await Task.Delay(50);
            }

            // Skriv tillbaka de sorterade elementen i NummerArray
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

        // Quick Sort funktion
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

        // QuickSort knapp för funktionen
        private async void SortingButton_Click(object sender, EventArgs e)
        {
            await Listmaker();
            await Task.Delay(2500);

            sortedIndex = -1;

            await QuickSortAsync(0, NummerArray.Length - 1);

            // Visar slutet snyggt
            for (int i = 0; i < NummerArray.Length; i++)
            {
                sortedIndex = i;
                await Listfiller(i);
                await Task.Delay(30);
            }
        }
    }
}
