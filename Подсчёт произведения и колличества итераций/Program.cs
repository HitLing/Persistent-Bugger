using System;
using System.Linq;

class Persist
{ 
     static int Length(long source) {
        int length = Convert.ToString(source).Length;
        return length;
    }

    static Boolean check(long source) {
        char[] a = new char[Convert.ToString(source).Length];
        a = Convert.ToString(source).ToCharArray();
        Boolean checker = true;
        for (int i = 0; (i < a.Length) && (checker == true); i++) {
            if (a[i] == Convert.ToChar("0")) {
                checker = false;
            }
        }
        return checker;
    }

    static long mult(long source) {
        if (source < 0) {
            source = -source;
        }
            int maxlength = Length(source) - 1;
            if (maxlength == 0)
            {
                return source;
            }
            Int64 s1 = source / Convert.ToInt64(Math.Pow(10, maxlength));
            source = source - s1 * Convert.ToInt64(Math.Pow(10, maxlength));
            long i = mult(source);
            return s1 * i;
        
    }
    public static int Persistence(long souce) {
        int count=0;
        Boolean checker = true; 
        while (((souce/10)!=0) && (checker==true)) {
            checker = check(souce);
            souce = mult(souce);
            count++;
        }
        return count;
    }
   

    }     









namespace Подсчёт_произведения_и_колличества_итераций
{
    class Program
    {
        static void Main(string[] args)
        {
            long abv = 9999999999999999;
            Persist.Persistence(abv);
           
        }
    }
}
