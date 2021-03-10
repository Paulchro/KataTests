using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
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
            //Console.WriteLine(Kata.GetUnique(new[] { 1, 2, 2, 2 }));
            //Console.WriteLine(Kata.ValidParentheses("hi)("));
            //List<object> list = new List<object>(){ 1,2,"aasf","1","123",123};
            //Console.WriteLine(Kata.GetIntegersFromList(list));
            //Console.WriteLine(Kata.listSquared(1,250));
            //Console.WriteLine(Kata.Longest("aretheyhere", "yestheyarehere"));

            //var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
            //foreach (var item in pp)
            //{
            //    Console.WriteLine(Kata.IsPerfectPower(item));
            //}
            //Console.WriteLine(Kata.findNb(4183059834009));
            //Console.WriteLine(Kata.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
            //Console.WriteLine(Kata.DescendingOrder(123124));
            //Console.WriteLine(Kata.Solve("catchphrase"));
            //Console.WriteLine(Kata.Test("1 2 1 1"));
            //Console.WriteLine(Kata.EncryptThis("Thank you Piotr for all your help"));
            //Console.WriteLine(Kata.WhoLikedMe(new string[] { })); // must be "no one likes this"
            //Console.WriteLine(Kata.WhoLikedMe(new string[] { "John" })); // must be "John likes this"
            //Console.WriteLine(Kata.WhoLikedMe(new string[] { "John", "Alicia" })); // must be "John and Alicia like this"
            //Console.WriteLine(Kata.WhoLikedMe(new string[] { "John", "Alicia", "Mark" })); // must be "John, Alicia and Mark like this"
            //Console.WriteLine(Kata.WhoLikedMe(new string[] { "John", "Alicia", "Mark", "Alex" }));
            //Console.WriteLine(Kata.ComplexId(454)); // 811164
            //Console.WriteLine(Kata.ComplexId(2233)); // 811164
            //Console.WriteLine(Kata.ComplexId(9118)); // 811164
            //Console.WriteLine(Kata.IsValid(new char[] { 'n', 'e', 'w', 's' })); // false
            //Console.WriteLine(Kata.IsValid(new char[] { 'n', 's', 'n', 's', 'n', 's', 'n', 's', 'n', 's' })); // true
            //Console.WriteLine(Kata.IsValid(new char[] { 'n', 's', 'n', 's', 'n', 's', 'n', 's', 'n', 'n' })); // false
            //Console.WriteLine(Kata.IsValid(new char[] { 'n', 'e', 'w', 's', 'n', 'e', 'w', 's', 'n', 's' })); // true
            //Console.WriteLine(Kata.wave("two words"));
            //string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            //string[] reel2 = new string[] { "Bar", "Wild", "Queen", "Bell", "King", "Seven", "Cherry", "Jack", "Star", "Shell" };
            //string[] reel3 = new string[] { "Bell", "King", "Wild", "Bar", "Seven", "Jack", "Shell", "Cherry", "Queen", "Star" };
            //Console.WriteLine(Kata.Fruit(new List<string[]> { reel1, reel2, reel3 }, new int[] { 5, 4, 3 }));
            //Console.WriteLine(Kata.NbYear(1500, 5, 100, 5000));
            //Console.WriteLine(Kata.ToDoubleArray(new string[] { "1.1", "2.2", "3.3" }));
            //Console.WriteLine(Kata.Tickets(new int[] { 25, 25, 50, 50 }));
            //Console.WriteLine(Kata.overTheRoad(7,11));
            //Console.WriteLine(Kata.OddOrEven(new int[] { -1023, 1, -2 }));
            //Console.WriteLine(Kata.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 }));
            //Console.WriteLine(Kata.NumberFormat(123124));
            //Console.WriteLine(Kata.AlphabetWar("*rd"));
            //Console.WriteLine(Kata.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray());
            //Console.WriteLine(Kata.WhatIsTheTime("10:00"));
            //Console.WriteLine(Kata.calculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
            //Console.WriteLine(Kata.Doubleton(1234));
            //Console.WriteLine(Kata.ComputeDepth(42));
            //Console.WriteLine(Kata.WhatTimeIsIt(191.87d));
            Console.WriteLine(Kata.Solve2(new int[] { 4,7,10}));
            



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
                list.Add(arr[arr.Count / 2]);
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
            switch (op)
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
                if (numbers.ElementAt(i) == numbers.ElementAt(i + 1))
                {
                    numbers = numbers.Where(u => u != numbers.ElementAt(i + 1)).ToList();

                }

            }
            return numbers.ElementAt(0);
        }
        public static bool ValidParentheses(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    count++;
                }
                if (input[i] == ')')
                {
                    count--;
                }
                if (count < 0)
                    return false;
            }
            return (count == 0);


            //WRONG: BECAUSE DOESNT CHECK FOR VALID PARENTHESES BUT ONLY COUNTING OPENING AND CLOSING TAGS

            //char[] words = input.ToCharArray();
            //if (words == null /*|| !(words.Contains(')')) || !(words.Contains('('))*/)
            //{
            //    return false;
            //}
            //List<int> arr1 = new List<int>();
            //List<int> arr2 = new List<int>();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words.ElementAt(i) == '(')
            //    {
            //        arr1.Add(1);
            //    }
            //    if (words.ElementAt(i) == ')')
            //    {
            //        arr2.Add(1);
            //    }
            //}
            //if (arr1.Count() == arr2.Count() && arr1.Count() != 0)
            //{
            //    return true;
            //}
            //else
            //    return false;

        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (listOfItems[i].GetType() == typeof(int))
                {
                    list.Add((int)listOfItems[i]);
                }
            }

            return list;
        }

        public static string listSquared(long m, long n)
        {
            long dif = n - m;
            long[] arr = new long[dif + 1];
            var result = new List<string>();

            for (int i = 0; i < dif + 1; i++)
            {
                arr[i] = i + (int)m;
            }

            foreach (var item in arr)
            {
                List<int> list2 = new List<int>();
                for (int i = 1; i < item + 1; i++)
                {
                    if (item % i == 0)
                    {
                        list2.Add(i * i);
                    }
                }
                int sumi = list2.Sum();
                int sumsqrt = (int)(Math.Sqrt(sumi) * Math.Sqrt(sumi));
                if (sumsqrt == sumi && Math.Sqrt(sumi) % 2 == 0 || Math.Sqrt(sumi) % 2 == 1)
                {
                    result.Add(string.Format("[{0}, {1}]", item, sumi));
                    list2.Clear();
                }
            }
            return string.Format("[{0}]", string.Join(", ", result));
        }

        public static string Longest(string s1, string s2)
        {
            string result = new string(s1.Concat(s2).Distinct().OrderBy(c => c).ToArray());
            return result;
        }

        public static (int, int)? IsPerfectPower(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                for (int j = 2; Math.Pow(i, j) <= n; j++)
                {
                    if (Math.Pow(i, j) == n)
                    {

                        return (i, j);
                    }

                }
            }
            return null;
        }

        public static long findNb(long m)
        {
            long count = 0;
            int i;
            for (i = 0; count < m; i++)
            {
                count += (long)Math.Pow(i, 3);

            }
            return count == m ? i - 1 : -1;

        }

        public static string GetOrder(string input)
        {
            var result = new List<string>();
            new string[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" }
                .ToList().ForEach(o => result.AddRange(Enumerable.Repeat(o, Regex.Matches(input, o, RegexOptions.IgnoreCase).Count)));

            return string.Join(" ", result);
        }
        public static double Solution(double n)
        {
            double x = Math.Round(n * 2);
            return x / 2;
        }

        public static int DescendingOrder(int num)
        {
            return Convert.ToInt32(String.Join("", num.ToString().ToCharArray().OrderByDescending(x => x)));
        }

        //public static int Solve(string s)
        //{
        //    char[] arr = s.ToCharArray();
        //    int[] arr2 = new int[arr.Length];
        //    List<int> list = new List<int>();

        //    for (int y = 0; y < arr.Length; y++)
        //    {
        //        if (arr[y] == 'a' || arr[y] == 'e' || arr[y] == 'i' || arr[y] == 'o' || arr[y] == 'u')
        //        {
        //            arr2[y] = 0;
        //        }
        //        else arr2[y] = arr[y] % 32;


        //    }
        //    int value = 0;
        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        if(arr2[i] > 0)
        //        {
        //            list.Add(arr2[i]);
        //        }
        //    }
        //    return 1;
        //}

        public static int Test(string numbers)
        {
            string[] arr = numbers.Split(' ').ToArray();

            List<string> one = new List<string>();
            List<string> two = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    if (Convert.ToInt32(arr[i]) % 2 == 0)
                    {
                        one.Add(arr[i]);
                    }
                    else
                        two.Add(arr[i]);
                }
            }
            if (one.Count() > two.Count())
            {
                return Array.IndexOf(arr, two[0]) + 1;
            }

            return Array.IndexOf(arr, one[0]) + 1;
        }

        public static string EncryptThis(string s)
           => string.Join(" ", s.Split(' ').Select(Encrypt));

        private static string Encrypt(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            else if (s.Length == 1) return $"{(int)s[0]}";
            else if (s.Length == 2) return $"{(int)s[0]}{s[1]}";
            return $"{(int)s[0]}{s.Last()}{s.Substring(2, s.Length - 3)}{s[1]}";
        }
        //string[] arr = input.Split(' ').ToArray();
        //string result = "";
        //foreach (var item in arr)
        //{
        //    result += (int)item[0] + item.Substring(item.Length - 1) + item.Substring(1, item.Length - 2) + " ";
        //}
        //return result;

        public static string WhoLikedMe(string[] names)
        {
            string result = "";
            switch (names.Length)
            {
                case 0:
                    result = "No one likes this";
                    break;
                case 1:
                    result = $"{names[0]} likes this";
                    break;
                case 2:
                    result = $"{names[0]} and {names[1]} likes this";
                    break;
                case 3:
                    result = $"{names[0]}, {names[1]} and {names[2]} likes this";
                    break;
                case 4:
                    result = $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
                    break;
            }
            return result;
        }

        public static int ComplexId(int postId)
        {
            postId = Math.Abs(postId);
            int length = postId.ToString().Length;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = postId % 10;
                postId /= 10;
            }
            string result = "";
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                result += (array[i] * array[i]).ToString();
            }

            return Convert.ToInt32(result);
        }

        public static bool IsValid(char[] steps)
        {
            if (steps.Length != 10) return false;
            var x = 0;
            var y = 0;
            foreach (var dir in steps)
            {
                if (dir == 'n') x++;
                else if (dir == 's') x--;
                else if (dir == 'e') y++;
                else if (dir == 'w') y--;
            }

            return x == 0 && y == 0;
        }

        public static List<string> wave(string str)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    list.Add(str.Substring(0, i) + str.Substring(i, 1).ToUpper() + str.Substring(i + 1, str.Length - 1 - i));
                }
            }
            return list;

        }

        public static int Fruit(List<string[]> reels, int[] spins)
        {

            var table = new Dictionary<string, int[]>()
            {
            {"Wild",new []{100,10,100}},
            {"Star",new []{90,9,18}},
            {"Bell",new []{80,8,16}},
            {"Shell",new []{70,7,14}},
            {"Seven",new []{60,6,12}},
            {"Cherry",new []{50,5,10}},
            {"Bar",new []{40,4,8}},
            {"King",new []{30,3,6}},
            {"Queen",new []{20,2,4}},
            {"Jack",new []{10,1,2}}
            };
            var results = reels.Select(x => x[spins[reels.IndexOf(x)]]).ToList();
            if (results.Distinct().Count() == 1)
                return table[results[0]][0];
            if (results.Distinct().Count() == 2 && results.Count(x => x == "Wild") == 1)
                return table[results.First(x => x != "Wild")][2];
            if (results.Distinct().Count() == 2)
                return table[results[0] == results[1] ? results[0] : results[2]][1];
            return 0;
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int count = 0;
            double p1 = p0;
            double newper = percent / 100;
            for (int i = 0; i < Int32.MaxValue; i++)
            {
                p0 += (int)(p0 * percent / 100) + aug;
                count += 1;
                if (p0 >= p)
                {
                    break;
                }

            }
            return count;
        }

        public static double[] ToDoubleArray(string[] stringArray)
        {

            return stringArray.Select(double.Parse).ToArray();
        }

        public static long overTheRoad(long address, long n)
        {
            // List<int> list = new List<int>();
            // for (int i = 1; i < n*2 +1; i++)
            // {
            //     list.Add(i);
            // }
            // List<int> list2 = new List<int>();
            // for (int i = 1; i < n*2 +1; i+=2)
            // {
            //     list.Remove(i);
            //     list2.Add(i);
            // }
            // list2.Reverse();
            //if(address % 2 == 0)
            // {
            //     return list2[list.IndexOf((int)address)];
            // }
            // return list[list2.IndexOf((int)address)];

            return n * 2 - address + 1;
        }

        public static string Tickets(int[] peopleInLine)
        {
            //int count = 0;
            //int resta = 0;
            //int price = 25;
            //string result = "";
            //for (int i = 0; i < peopleInLine.Length; i++)
            //{
            //    if (peopleInLine[i] == price)
            //    {
            //        resta += peopleInLine[i];
            //        count++;
            //    }
            //    else if
            //        (peopleInLine[i] > price)
            //    {
            //        if (resta > peopleInLine[i] - 25)
            //        {
            //            resta += peopleInLine[i] - 25;
            //            count++;
            //        }
            //        else
            //        {
            //            result = "NO";
            //        }
            //    }
            //}
            //if (count == peopleInLine.Length)
            //{
            //    result = "YES";
            //}
            //else
            //    result = "NO";
            //return result;

            int d25 = 0;
            int d50 = 0;
            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25) d25++;
                if (peopleInLine[i] == 50)
                {
                    d25--;
                    d50++;
                }
                if (peopleInLine[i] == 100)
                {
                    if (d50 > 0)
                    {
                        d50--;
                        d25--;
                    }
                    else
                    {
                        d25 -= 3;
                    }
                }
                if (d25 < 0) return "NO";
            }
            return "YES";
        }
        public static string OddOrEven(int[] array)
        {
            string result = "";
            if (Math.Abs(array.Sum()) % 2 == 0)
            {
                result = "EVEN";
            }
            else
                result = "ODD";
            return result;
        }
        public static int HighestRank(int[] arr)
        {
            return arr
                     .GroupBy(i => i)
                     .OrderByDescending(gr => gr.Count())
                     .ThenByDescending(gr => gr.Key)
                     .Select(gr => gr.Key)
                     .First();
        }

       
        public static string NumberFormat(int number)
        {
            return number.ToString("N0", CultureInfo.InvariantCulture);
        }

        //public static string AlphabetWar(string fight)
        //{
        //    int count = 0;
        //    List<int> left = new List<int>();
        //    List<int> right = new List<int>();
        //    foreach (var item in fight)
        //    {
        //        if (item != '*')
        //        {
        //            if (item == 'w')
        //                left.Add(4);
        //            else if (item == 'p')
        //                left.Add(3);
        //            else if (item == 'b')
        //                left.Add(2);
        //            else if (item == 's')
        //                left.Add(1);
        //        }
        //        else
        //        {
        //            if (item == 'm')
        //                left.Add(4);
        //            else if (item == 'q')
        //                left.Add(3);
        //            else if (item == 'd')
        //                left.Add(2);
        //            else if (item == 'z')
        //                left.Add(1);
        //        }
        //    }
        //    return "";
        //}

        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] arr = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int y = 1; y < numbers.Length; y++)
                {
                    if(numbers[i] + numbers[y] == target)
                    {
                        arr[0] = Array.IndexOf(numbers, numbers[i]);
                        arr[1] = Array.LastIndexOf(numbers, numbers[y]);
                        goto SkipToEnd;
                    }
                }
            }
            SkipToEnd:
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }

        public static string WhatIsTheTime(string timeInMirror)
        {
            int hour = (12 - Convert.ToInt32(timeInMirror.Substring(0, 2)));
            int minute = (60 - Convert.ToInt32(timeInMirror.Substring(3,2))) % 60;


            if (minute != 0) hour -= 1;
            if (hour <= 0) hour += 12;
            return $"{hour:00}:{minute:00}";


            var h = 12 - int.Parse(timeInMirror.Substring(0, 2));
            var m = (60 - int.Parse(timeInMirror.Substring(3))) % 60;
            if (m != 0) h -= 1;
            if (h <= 0) h += 12;
            return $"{h:00}:{m:00}";

        }
        public static string calculateString(string calcIt)
        {
            var match = Regex.Match(calcIt, @"[\*\+\-\/]");
            decimal result = 0;
            int index = match.Index;
            //for (int i = 0; i < calcIt.Length; i++)
            //{
            //    if(calcIt[i] == '/' || calcIt[i] == '+' || calcIt[i] == '-' || calcIt[i] == '*')
            //    {
            //        index = calcIt.IndexOf(calcIt[i]);
            //    }

            //}
            int x = calcIt.Length;
            string start = Regex.Replace(calcIt.Substring(0, index), "[^0-9.]", "").Replace('.', ',');
            string end = Regex.Replace(calcIt.Substring(index + 1, x - (index + 1)), "[^0-9.]", "").Replace('.', ',');
            switch (calcIt[index])
            {
                case '+':
                    result = Convert.ToDecimal(start) + Convert.ToDecimal(end);
                    break;
                case '/':
                    result = Convert.ToDecimal(start) / Convert.ToDecimal(end);
                    break;
                case '-':
                    result = Convert.ToDecimal(start) - Convert.ToDecimal(end);
                    break;
                case '*':
                    result = Convert.ToDecimal(start) * Convert.ToDecimal(end);
                    break;

            }

            return Math.Round(result).ToString();

        }

        public static int Doubleton(int num)
        {
            num++;
            while (num.ToString().Distinct().Count() != 2)
            {
                num++;
            }
            
            return num;
        }

        public static int ComputeDepth(int n)
        {
            int count = 0;
            int x = n;
            List<int> list = new List<int>();
            
                for (int i = 1; i < 100; i++)
                {
                     x = n * i;
                while (x > 0)
                {
                    list.Add(x % 10);
                    x = x / 10;
                
                }
                int u = list.Distinct().Count();
                    count++;
                    if(u >= 10)
                    break;   
                }
            return count;
        }

        public static string WhatTimeIsIt(double angle)
        {
            int x = (int)(angle / 30);
            double m = Math.Floor((angle % 30) *2);
            if(angle < 30)
            {
                x = 12;
            }
            return angle == 0 || angle == 360 ? "12:00" : $"{x:00}:{m:00}";
        }

        public static int Solve2(int[] arr)
        {
            int count = 0;
            Array.Sort(arr);
            while (arr[1] > 0)
            {
                arr[2]--;
                arr[1]--;
                count++;
                Array.Sort(arr);
            }

            return count;
        }
    }

    

}


   

