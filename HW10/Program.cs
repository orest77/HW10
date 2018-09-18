using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    
    class Program
    {
        #region HW10.1
        //public delegate double RealDelegate(double x);

        //public static void Tabulation(double a, double b, double n, RealDelegate callback)
        //{
        //    for (int k = 0; k < n; k++)
        //    {
        //        double x = a + k * (b - a) / n;
        //        Console.WriteLine($"Tabulation = {x} : {callback(x)}");
        //    }
        //}
        //public static double Sinus(double x)
        //{
        //    return Math.Sin(x);
        //}
        //public static double GraphFunction(double x)
        //{
        //    return Math.Pow(2 * x, 2) + 3 * x * Math.Cos(Math.Pow(x, 3));
        //}
        #endregion
        static void Main(string[] args)
        {
            #region HW10.1
            //RealDelegate op = new RealDelegate(Sinus);
            //double sinus = op(8);
            //Console.WriteLine("Sinus = {0}", sinus);

            //op = new RealDelegate(GraphFunction);
            //double graph = op(4);
            //Console.WriteLine("Graph of Function = {0}", graph);

            //Tabulation(1, 5, 10, Sinus);
            //Console.WriteLine("______________");
            //Tabulation(1, 5, 10, GraphFunction);
            //Console.ReadKey();
            #endregion

            #region HW10.2
            Student student = new Student();
            Parent perent = new Parent();
            Accounting accounting = new Accounting();
            student.MarkChange += new MyDel(perent.OnMarkChange);
            student.MarkChange += new MyDel(accounting.ScholarshipPayment);

            student.AddMark(7);
            student.AddMark(24);
            student.AddMark(15);

            Console.ReadKey();
            #endregion
        }
        public delegate void MyDel(int m);

    }
}
