using System.Runtime.InteropServices;

namespace TemperatureUnitConverterUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int size = 0;

                MessageBox.Show($"Size before convert: {size}");

                IntPtr result = NativeMethods.ConvertToCelsius(out size);

                MessageBox.Show($"Size after convert: {size}");

                if (result == IntPtr.Zero)
                {
                    MessageBox.Show("result returned null pointer");
                }

                if (size > 0)
                {
                    int[] managedArray = new int[size];

                    Marshal.Copy(result, managedArray, 0, size);

                    string message = "Result from C DLL: ";
                    foreach (var value in managedArray)
                    {
                        message += value + " ";
                    }

                    MessageBox.Show(message);

                    if (NativeMethods.freeMemory(result) != 0)
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

                    if (NativeMethods.freeMemory(result) != 0)
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
    }
}
