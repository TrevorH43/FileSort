using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;

namespace FileSort
{
    public partial class FileSortForm : Form
    {
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
        public static void SelectionSort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            sortedListBox.Items.Clear();
        }

        private void sortedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}