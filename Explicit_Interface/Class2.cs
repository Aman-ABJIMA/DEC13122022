using System;
namespace EXPLICIT_INTERFACE
{
    class Result : ISum
    {
        void ISum.sum()
        {
            int a = 10;
            int b=20;
            Console.WriteLine(a + b);
        }
    }
}