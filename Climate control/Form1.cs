namespace Climate_control
{
    public partial class Form1 : Form
    {
        double[,,] temperatures;
        int index;

        public Form1()
        {
            InitializeComponent();
            temperatures = new double[2, 2, 2];
            index = 0;
        }

        private void btnSaveTemperature_Click(object sender, EventArgs e)
        {
            if (index < 8)
            {
                if (double.TryParse(txtTemperature.Text, out double temperatura))
                {
                    int i = index / 4;
                    int j = (index / 2) % 2;
                    int k = index % 2;
                    temperatures[i, j, k] = temperatura;
                    index++;

                    txtTemperature.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid temperature.");
                }
            }
            else
            {
                MessageBox.Show("All temperatures have already been entered.");
            }
        }

        private void btnAverageTemp_Click(object sender, EventArgs e)
        {
            double addition = 0;
            foreach (double temp in temperatures)
            {
                addition += temp;
            }
            double average = addition / 8;
            MessageBox.Show("The average temperatures are: " + average.ToString("0.00"));
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            index = 0;
            Array.Clear(temperatures, 0, temperatures.Length);
            txtTemperature.Clear();

            MessageBox.Show("The data has been cleared correctly.");
        }
    }
}
