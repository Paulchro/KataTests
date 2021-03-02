using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 20, 10, 30, 10, 10, 15, 35 };
            //string result = string.Join("", arr);
            //Console.WriteLine(result);
            //Console.WriteLine(Kata.FindEvenIndex(arr));

            //Console.WriteLine(Kata.sumTwoSmallestNumbers(arr));
            //Console.WriteLine(Kata.IsSquare(25));
            //Console.WriteLine(Kata.ExpandedForm(132123));
            //Console.WriteLine(Kata.DuplicateCount("hello"));
            //Console.WriteLine(Kata.RentalCarCost(7));

            //Kata.PipeFix(numbers).ForEach(Console.WriteLine);
            //Console.WriteLine(Kata.WordsToMarks("hello"));
            //Console.WriteLine(Kata.SharedBits(7,15));
            //Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
            //Console.WriteLine(Kata.HighAndLow("4 1 32 56 5 2"));
            //Console.WriteLine(Kata.Range(6, 8));
            //Console.WriteLine(Kata.Hero(100,51));
            //Console.WriteLine(Kata.High("Hello worrld"));
            //int[] a = new int[] { 144, 121, 19, 161, 19, 144, 19, 11 };
            //int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            //Console.WriteLine(Kata.comp(a, b));
            //Console.WriteLine(Kata.Persistence(999));
            //Console.WriteLine(Kata.GetSum(0, -1));
            //Console.WriteLine(Kata.Accum("ZpglnRxqenU"));
            //List<int> numbers = new List<int> { 78, 79, 52, 87, 16, 74, 31, 63, 80 };
            //Console.WriteLine(Kata.Solve(numbers));
            //Console.WriteLine(Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            //Console.WriteLine(Kata.Arithmetic(1, 2, "add"));
            Console.WriteLine(Kata.GetUnique(new[] { 1, 2, 2, 2 }));


        }

    }
    public static class Kata
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }



        public static string CreatePhoneNumber(int[] numbers)
        {
            string result = string.Join("", numbers);
            string modified = result.Insert(0, "(").Insert(4, ") ").Insert(9, "-");

            return modified;
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) where T : IEquatable<T>
        {
            T previous = default(T);
            foreach (var t in iterable)
            {
                if (!t.Equals(previous))
                    yield return t;
                previous = t;
            }
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);

            return (numbers[0] + numbers[1]);
        }


        public class Triangle
        {
            public static bool IsTriangle(int a, int b, int c)
            {
                if (a <= 0 || b <= 0 || c <= 0)
                    return false;

                if (a + b > c && a + c > b && c + b > a)
                    return true;
                else
                    return false;
            }
        }
        public static int FindEvenIndex(int[] arr)
        {
            if (arr.Length < 3)
            {
                return -1;
            }

            int leftVal = 0, rightVal = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                rightVal += arr[i];
            }

            for (int i = 1; i < arr.Length - 1; i++)
            {
                leftVal += arr[i - 1];
                rightVal -= arr[i];
                if (leftVal == rightVal)
                {
                    return i;
                }
            }

            return -1;
        }

        public static string ExpandedForm(long num)
        {
            var str = num.ToString();
            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));

        }

        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();

        }

        public static int RentalCarCost(int d)
        {
            int x = 0;
            if (d < 3)
            {
                x = d * 40;
            }
            else if (d >= 3 && d <= 6)
            {
                x = d * 40 - 20;
            }
            else if (d >= 7)
            {
                x = d * 40 - 50;
            }

            return x;

        }
        public static List<int> PipeFix(List<int> numbers)
        {
            List<int> newlist = new List<int>();
            int newC = numbers.Max() - numbers.Min() + 1;
            if (newC != 0)
            {
                for (int i = numbers.Min(); i < numbers.Max() + 1; i++)
                {
                    newlist.Add(i);

                }

            }
            return newlist;
        }

        public static int WordsToMarks(string str)
        {
            //char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n','o','p','q','r','s','t','u','v','w','x','y','z' };
            //char[] array2 = str.ToCharArray();
            //int[] array3 = array2.Select(n => Array.IndexOf(array, n)).ToArray();
            //int sum = array3.Sum() + array3.Length ;
            //return sum;
            int sum = 0;
            foreach (char c in str) sum += Convert.ToInt32(c) - 96;
            return sum;

        }

        public static bool SharedBits(int a, int b)
        {

            return ((a &= b) & (a - 1)) > 0;
        }

        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            string result = "";
            if (scores[0] > scores[1])
            {
                result = $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
            }
            else if (scores[0] < scores[1])
            {
                result = $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
            }
            else if (scores[0] == scores[1])
            {
                result = $"At match {teams[0]} - {teams[1]}, teams played draw.";
            }
            return result;
        }

        public static string AlphabetPosition(string text)
        {
            char[] phrase = text.ToCharArray();
            List<int> numbers = new List<int>();
            foreach (char c in phrase)
            {
                int index = (int)c % 32;
                if (index > 0)
                {
                    numbers.Add(index);
                }

            }
            string result = string.Join(" ", numbers);
            return result;

            //        return string.Join(" ", text
            //.ToLower()
            //.Where(c => char.IsLetter(c))
            //.Select(c => (c - 'a') + 1)
            //.ToList());
        }

        public static string FireFight(string s)
        {
            if (s.Contains("Fire"))
            {
                s = s.Replace("Fire", "~~");
            }

            return s;
        }

        public static int[] Range(int startNum, int endNum)
        {
            int dif = endNum - startNum;
            if (dif <= 0)
                return new int[0];
            else
            {
                int[] arr = new int[dif - 1];
                int x = startNum + 1;
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    arr[i] = x;
                    x++;
                }
                return arr;
            }


        }

        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
        }

        public static string Switcheroo(string x)
        {
            return x.Replace("a", "d").Replace("b", "a").Replace("d", "b");
        }

        public static bool Hero(int bullets, int dragons)
        {
            return bullets >= 2 * dragons ? true : false;
        }

        public static string High(string s)
        {
            return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
        }

        public static string CamelCase(this string str)
        {
            string[] arr = str.Split(' ');
            string camel = "";
            for (int i = 0; i < arr.Length; i++)
            {
                camel += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(arr[i]);
            }
            return camel;

        }

        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            var bList = new List<int>(b);
            foreach (int x in a)
            {
                if (bList.Contains(x * x))
                {
                    bList.Remove(x * x);
                }
                else
                {
                    return false;
                }
            }
            return bList.Count == 0 ? true : false;

        }

        public static int Persistence(long n)
        {
            var count = 0;
            long g = 1;
            Stack<long> digits = new Stack<long>();

            while (n > 0)
            {
                while (n > 0)
                {
                    var digit = n % 10;
                    n /= 10;
                    digits.Push(digit);
                }
                if (digits.Count > 1)
                {
                    for (int i = 0; i < digits.Count; i++)
                    {
                        g *= digits.ElementAt(i);
                    }
                    n = g;
                    g = 1;
                    digits.Clear();
                    count += 1;
                }
            }
            return count;
        }

        public static int GetSum(int a, int b)
        {
            int dif = b - a;
            if (dif == 0)
                return a;
            else
            {
                int[] arr = new int[Math.Abs(dif) + 1];
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if (a < b)
                    {
                        arr[i] = a++;
                    }
                    else
                    {
                        arr[i] = b++;
                    }
                }
                int sum = arr.Sum();
                return sum;
            }

        }

        public static String Accum(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            { 
                result += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(new String((char)(s[i]), i + 1).ToLower());
                result += @"-";
            }
            return result.Remove(result.Length - 1);
        }

        public static List<int> Solve(List<int> arr)
        {

            List<int> list = new List<int>();
            arr.Sort();
            for (int i = 0; i < (arr.Count() / 2); i++)
            {
                list.Add(arr[arr.Count - 1 - i]);
                list.Add(arr[i]);

            }
            if (arr.Count % 2 == 1)
            {
                list.Add(arr[arr.Count / 2 ]);
            }
            list.ForEach(Console.WriteLine);
            return list;

        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }

        public static double Arithmetic(double a, double b, string op)
        {
            double result = 0;
            switch(op)
            {
                case "subtract":
                    return result = a - b;
                    break;
                case "add":
                    return result = a + b;
                    break;
                case "divide":
                    return result = a / b;
                    break;
                case "multiply":
                    return result = a * b;
                    break;

            }
            return result;
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Count(); i++)
            {
                if(numbers.ElementAt(i) == numbers.ElementAt(i+1))
                {
                    numbers = numbers.Where(u => u != numbers.ElementAt(i + 1)).ToList();
                    
                }
                
            }
            return numbers.ElementAt(0);
        }
    }
}
   

