using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class ListInt
    {
        int[] arr;
        public ListInt()
        { 
            arr = new int[0];
        }
        public ListInt(int lenght)
        { arr = new int[lenght]; }
        public ListInt(int[] arr)
        { this.arr = arr; }
        public int this[int index]
        { get { return arr[index]; } }
        public void Add(int num)
        {
            Array.Resize(ref arr,arr.Length+1);
            arr[arr.Length-1]=num;
        }
        


        public bool axtarlan_eded(int[] arr ,int num)
        {
            for(int i=0 ; i<arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    Console.WriteLine(arr[i]);
                    return true;
                }
               
            }
            return false;
        }
        public void Add(params int[] num)
        {
            Array.Resize(ref arr, arr.Length + num.Length);
            for (int i = arr.Length - num.Length; i < arr.Length; i++)
            {
                arr[i] = num[i - num.Length - 1];
            }

         }
            public int sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            return sum;
           
        }
        public string ToString()
        {
            StringBuilder stringg = new StringBuilder();
            foreach (var item in arr)
            {
                stringg.Append(item);
            }
            return stringg.ToString();

        }

        public void Pop()
        {
            Array.Resize(ref arr, arr.Length - 1);
            Console.WriteLine(arr[arr.Length - 1]);
        }
        public void print()
        {
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
