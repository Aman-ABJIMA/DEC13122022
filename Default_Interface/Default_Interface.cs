using System;
namespace Default_Interface
{
    public interface IDefault_Interface
    {
       public void add();
       public void remove();

       public void processing() //default Interface
        {
            Console.WriteLine("Processing Method Invoked");
        }
    }

    class CHILD : IDefault_Interface
    {
        public void add()
        {
            Console.WriteLine("Add Method Invoked");
        }
        public void remove()
        {
            Console.WriteLine("Remove Method Invoked");
        }

    }

    class MAIN
    {
        public static void Main(string[] args)
        {
            CHILD obj= new CHILD();
            obj.add();
            obj.remove();
         // obj.processing();

            IDefault_Interface obj2 = obj;
            obj2.processing();
                        //or
           ((IDefault_Interface)obj).processing();

        }

    }

}