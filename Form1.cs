using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSortExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //field variable
        int[] numbers = { 136, 211, 194, 277, 231, 281, 162, 242, 348, 154, 226, 212, 368, 173, 166, 123, 241, 258, 409, 214
        , 178, 182, 323, 264, 311, 445, 290, 196, 237, 141, 231, 434, 183, 490, 159, 389, 167, 209, 222, 362, 196, 246, 198, 472,
        189, 175, 340, 210, 248, 260};

        private void nonSortedButton_Click(object sender, EventArgs e)
        {
            //display non sorted array values

            string nonSorted = "";

            foreach (int element in numbers)
            {
                nonSorted = nonSorted + element + "\n";
            }

            nonSortedLabel.Text = nonSorted.ToString();
        }

        private void sortedButton_Click(object sender, EventArgs e)
        {
            //bubble sort this array to place the values in ascending order

            int temp = 0;
            int count = 0;

            string sorted = "";

            //loop
            for (int x = 0; x < numbers.Length; x++)
            {
                for (int z = 0; z < numbers.Length - 1 - x; z++)
                {
                    if(numbers[z] > numbers[z+1])
                    {
                        temp = numbers[z];
                        numbers[z] = numbers[z + 1];
                        numbers[z + 1] = temp;
                    }

                    count++;
                }
            }

            //display the sorted array
            foreach(int element in numbers)
            {
                sorted = sorted + element + "\n";
            }

            sortedLabel.Text = sorted.ToString();

            MessageBox.Show("The count value is: " + count.ToString());
        }

    }
}
