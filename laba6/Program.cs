using System;

namespace laba6
{
    class Program
    {
        delegate int PlusOrMinus(int p1, int p2);
        static int Plus(int p1, int p2)
        {
            return p1 + p2;
        }
        static int Minus(int p1, int p2)
        {
            return p1 - p2;
        }
        PlusOrMinus pm = (int x, int y) =>  x + y;
        
        static void PlusOrMinusMethod(string str, int i1, int i2, PlusOrMinus POMParam)
        {
            int Res = POMParam(i1, i2);
            Console.WriteLine(str+' '+Res.ToString());
        }
        static void PlusOrMinusMuthodFunc(string str, int i1, int i2, Func<int,int,int> POMParam)
        {
            int Res = POMParam(i1, i2);
            Console.WriteLine("{0} {1}",str,Res.ToString());
        }
        static void Main(string[] args)
        {

            PlusOrMinusMethod("Метод", 10, 20, Plus);
            PlusOrMinusMethod("Лямбда", 100, 200, (x, y) => x + y);
            PlusOrMinusMuthodFunc("Func", 1, 2, (a, b) => a + b);
        }
    }
}
