using System.Linq.Expressions;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3,4 ,5,6};
           ListInt list = new ListInt(a);
            int b = Convert.ToInt32(Console.ReadLine());
            list.Add(10);
            list.Add(20,2,3,4,5,6);
            list.print();
            list.Pop();
            Console.WriteLine(list.axtarlan_eded(a, b));
            Console.WriteLine(list.sum(a));
            Console.WriteLine(list.ToString());
           
            

        }
    }
}