using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace FileSort
{
    public partial class FileSortForm : Form
    {

        string[] lines;
        public FileSortForm()
        {
            InitializeComponent();
        }
        OpenFileDialog fdlg = new OpenFileDialog();
        private void findFileButton_Click(object sender, EventArgs e)
        {
            fdlg.Filter = "txt|*.txt";
            if (fdlg.ShowDialog() == DialogResult.OK) ;
            {
                fileNameTextBox.Text = fdlg.FileName;
                fileNameTextBox.Text = fdlg.SafeFileName;
                foreach (string line in lines)
                {
                    sortedListBox.Items.Add(line);
                }
            }
        }

        private void sortFileButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(fileNameTextBox.Text);
            List<int> list = new List<int>();
            while ((line = file.ReadLine()) != null)
            {
                sortedListBox.Items.Add(line);
                list.Add(int.Parse(line));
                counter++;
            }
            int[] arr = list.ToArray();
            Array.Sort(arr);
            int n = 0;
            foreach (int item in arr)
            {
                sortedListBox.Items[n] = item;
                n++;
            }
        }

        private void selectionSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectionSort(lines);
            foreach (string line in lines)
            {
                sortedListBox.Items.Add(line);
            }
        }

        private void SelectionSort(string[] sortArray)
        {
            int minIndex;

            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (sortArray[j].CompareTo(sortArray[minIndex]) > 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Swap(ref sortArray[i], ref sortArray[minIndex]);
                }
            }
        }
        private void Swap(ref string value1, ref string value2)
        {
            string temp;
            temp = value1;
            value1 = value2;
            value2 = temp;
        }

        private void bubbleSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BubbleSort(lines);
            foreach (string line in lines)
            {
                sortedListBox.Items.Add(line);
            }
        }

        public static void BubbleSort(int[] input)
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }

        private void insertSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InsertionSort(lines);
            foreach (string line in lines)
            {
                sortedListBox.Items.Add(line);
            }
        }
        public static void InsertionSort(int[] input)
        {

            for (int i = 0; i < input.Count(); i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            sortedListBox.Items.Clear();
        }
    }
}