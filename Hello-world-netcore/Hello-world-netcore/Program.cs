using System;
using System.Runtime.InteropServices;

namespace Hello_world_netcore
{

    class Program
    {
        [DllImport("libhello_world_cpp.so")]
        public static extern void ImprimePalavra(String palavra);

        [DllImport("libhello_world_cpp.so")]
        public static extern  int RetornoInt(int x);

        [DllImport("libhello_world_cpp.so")]
        public static extern float RetornoFloat(float x);

        [DllImport("libhello_world_cpp.so")]
        public static extern double RetornoDouble(double x);

        [DllImport("libhello_world_cpp.so")]
        public static extern bool RetornoBool(bool x);

        static void Main(string[] args)
        {
            Console.WriteLine("Chamando RetornoInt do C++: " + RetornoInt(10));
            Console.WriteLine("Chamando RetornoFloat do C++: " + RetornoFloat(100.1f));
            Console.WriteLine("Chamando RetornoDouble do C++: " + RetornoDouble(1.7E+3));
            Console.WriteLine("Chamando RetornoBool do C++: " + RetornoBool(true));
            ImprimePalavra("Hello World!");
        }
    }
}