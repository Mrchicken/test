
#define MarshalAs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApp2
{
    internal class Class1
    {
        
        
       
        


#if MarshalAs

        
#endif
#if IntPtr
        [DllImport("nbsbRF.dll", EntryPoint = "ReadCard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadCard(int port,IntPtr rfromid,IntPtr userid,
       ref  long cardtype,ref long cardflag,[MarshalAs(UnmanagedType.LPArray)]ref double[] price,[MarshalAs(UnmanagedType.LPArray)] ref int[] stepp,ref long warn,ref long overdraft,ref long limit,ref double salemoney,ref long buycount,ref double totalusage,ref double leftmoney,ref long reed,ref long valve,ref long flash,ref long battery,  IntPtr meterdate);
#endif

        

       
    }

}
