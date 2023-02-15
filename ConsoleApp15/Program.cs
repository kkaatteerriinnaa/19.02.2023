using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            IOutput[] arr = new IOutput[10];
            IMath[] arr1 = new IMath[10];


            foreach (IOutput a in arr)
            {
                a.Show();
                a.Show(string info);
            }
            foreach (IMath a in arr)
            {
                a.Max();
                a.Min();
                a.Avg(); ;
            }


        }
    }
    interface IOutput
    {
        void Show();
        void Show(string info);

        string info { get; set; }
    }
    class Array : IOutput
    {
        string info;
        string inf;

        string Info
        {
            set
            {
                info = value;
            }
            get
            {
                return info;
            }
        }
        string Inf
        {
            set
            {
                inf = value;
            }
            get
            {
                return inf;
            }
        }
        void Show()
        {
            Console.WriteLine(inf);
        }
        void Show(string info)
        {
            Console.WriteLine(info);
        }
    }
    class Array2 : IMath
    {
       
        int Max()
        {
            return Program.arr.Max();
        }
        int Min()
        {
            return Program.arr.Min();
        }
        float Avg()
        {
            return Program.arr.Average();
        }
        bool Search(int valueToSearch)
        {
                return Program.arr.Search(valueToSearch);
        }
    }
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
}
