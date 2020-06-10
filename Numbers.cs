using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hacking
{
    public static class Numbers
    {
        public static bool isPrime(int x) //проверка на простое число
        {
            for (int i = 2; i < x / 2 + 1; i++)
                if ((x % i) == 0) return false;
            return true;
        }

        public static int GetNextPrimeAfter(int n1, int n2 ) //генерация простого случайного числа в диапазоне 
        {
           
            int x=Rand(n1, n2);
            if (isPrime(x) == true) return x; else return GetNextPrimeAfter(n1, n2);
            
        }
       
        public static int Rand(int min, int max) //Ф-я получения случайного числа
        {
            Thread.Sleep(500);
            Random random = new Random();
            return random.Next(min, max);
           
        }
        
        public static int Power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            var tmp = a;
            var sum = tmp;
            for (var i = 1; i < b; i++)
            {
                for (var j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }

                tmp = sum;
            }

            return tmp;
        }


        
        public static int Mul(int a, int b, int n) // a*b mod n - умножение a на b по модулю n
        {
            var sum = 0;
            for (var i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }

            return sum;
        }

        public static int GetPRoot(int n) //нахождение первообразного корня по модулю p
        {
            for (var i = 0; i < n; i++)
                if (IsPRoot(n, i))
                    return i;
            return 0;
        }

        private static bool IsPRoot(int n, int a) // проверка является ли число первообразным корнем по модулю p
        {
            if (a == 0 || a == 1)
                return false;
            var last = 1;
            var set = new HashSet<int>();
            for (var i = 0; i < n - 1; i++)
            {
                last = (last * a) % n;
                if (set.Contains(last))
                    return false;
                set.Add(last);
            }
            return true;
        }
    }
}
