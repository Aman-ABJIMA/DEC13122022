using System;
namespace EXPLICIT_INTERFACE
{
    class MAIN
    {
         public static void Main(string[] args)
        {
            Result obj = new Result();
            // obj.sum(); compiler error
            ISum obj2 = obj;
            obj2.sum();
           //((ISum)obj).sum();  //invoked the method
            //or
           
        }
    }
}