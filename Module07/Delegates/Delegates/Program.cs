using System;

delegate int NumberChanger(int n);
namespace Delegates
{
    class TestDelegate
    {

    }


    class Program
    {
        static int num = 4;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int DivNum(int d)
        {
            num /= d;
            return num;
        }
        public static int SqNum(int s)
        {
            num = Convert.ToInt16(Math.Pow(num, 2));
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            NumberChanger nc3 = new NumberChanger(DivNum);
            NumberChanger nc4 = new NumberChanger(SqNum);

            nc1(4);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(4);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc3(4);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc4(4);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
