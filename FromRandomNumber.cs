using System.IO;
namespace RandomNumbers
{
    public partial class FromRandomNumber : Form
    {
        private Random rand = new Random();


        public FromRandomNumber()
        {
            InitializeComponent();
        }
        private void buttonGenNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(comboBoxSelection.Text);

                for (int y = 0; y <= x - 1; y++)
                {
                    listBoxNumbers.Items.Add(rand.Next(1001));
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Make sure you select a value in the combo box");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter writy;
            int y = 0;

            if (listBoxNumbers.Items.Count < 0)
            {
                MessageBox.Show("please generate some numbers first");
            }
            else
            {

                //1. create or open a file
                writy = File.CreateText("numbers.txt");
                //2. loop the list box and write the numbers to the file
                do
                {

                    writy.WriteLine(listBoxNumbers.Items[y++]);
                }
                while (y < listBoxNumbers.Items.Count);
                //3. close file
                writy.Close();
            }


        }

    }
}

