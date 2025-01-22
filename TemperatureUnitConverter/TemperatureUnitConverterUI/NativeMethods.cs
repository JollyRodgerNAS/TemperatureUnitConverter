using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUnitConverterUI
{
    public static class NativeMethods
    {
        [DllImport("TemperatureUnitConverter.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConvertToCelsius(out int returnSize);

        [DllImport("TemperatureUnitConverter.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int freeMemory(IntPtr ptr);
    }

}
