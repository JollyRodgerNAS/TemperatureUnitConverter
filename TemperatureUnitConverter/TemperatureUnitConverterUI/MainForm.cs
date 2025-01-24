using System.Runtime.InteropServices;

namespace TemperatureUnitConverterUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += formLoad;
            this.FormClosing += ExitApplication;
        }

        private void formLoad(object sender, EventArgs e)
        {
            populateListBox();
        }
        private void ExitApplication(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void populateListBox()
        {
            try
            {
                int size = 0;

                IntPtr fahrenheit = NativeMethods.retrieveFahrenheit(out size);
                IntPtr celsius = NativeMethods.convertToCelsius();
                IntPtr kelvin = NativeMethods.convertToKelvin();
                

                if (fahrenheit ==  IntPtr.Zero)
                {
                    MessageBox.Show("fahrenheit returned null pointer");
                }
                if (celsius == IntPtr.Zero)
                {
                    MessageBox.Show("celsius returned null pointer");
                }

                if (kelvin == IntPtr.Zero)
                {
                    MessageBox.Show("kelvin returned null pointer");
                }

                if (size > 0)
                {
                    double[] fahrenheitArray = new double[size];
                    double[] celsiusArray = new double[size];
                    double[] kelvinArray = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        fahrenheitArray[i] = Marshal.PtrToStructure<double>(fahrenheit + i * sizeof(double));
                        celsiusArray[i] = Marshal.PtrToStructure<double>(celsius + i * sizeof(double));
                        kelvinArray[i] = Marshal.PtrToStructure<double>(kelvin + i * sizeof(double));
                    }

                    foreach (var value in fahrenheitArray)
                    {
                        fahrenheitListBox.Items.Add($"{value:F2}");
                    }

                    foreach (var value in celsiusArray)
                    {
                        celsiusListBox.Items.Add($"{value:F2}");
                    }

                    foreach (var value in kelvinArray)
                    {
                        kelvinListBox.Items.Add($"{value:F2}");
                    }

                    if (NativeMethods.freeMemory(fahrenheit) != 0 || NativeMethods.freeMemory(celsius) != 0 || NativeMethods.freeMemory(kelvin) != 0)
                    {
                        MessageBox.Show("Error freeing memory!");
                    }
                    else
                    {
                        MessageBox.Show("Memory freed successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("No data to copy!");

                    if (NativeMethods.freeMemory(fahrenheit) != 0 || NativeMethods.freeMemory(celsius) != 0 || NativeMethods.freeMemory(kelvin) != 0)
                    {
                        MessageBox.Show("Error freeing memory!");
                    }
                    else
                    {
                        MessageBox.Show("Memory freed successfully!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
