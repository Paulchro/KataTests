using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Diagnostics;
using System.Numerics;

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
            ////Kata.PipeFix(numbers).ForEach(Console.WriteLine);
            //Console.WriteLine(Kata.WordsToMarks("hello"));
            //Console.WriteLine(Kata.SharedBits(7, 15));
            //Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
            ////Console.WriteLine(Kata.HighAndLow("4 1 32 56 5 2"));
            //Console.WriteLine(Kata.Range(6, 8));
            //Console.WriteLine(Kata.Hero(100, 51));
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
            //List<object> list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            //Console.WriteLine(Kata.GetIntegersFromList(list));
            //Console.WriteLine(Kata.listSquared(1, 250));
            //Console.WriteLine(Kata.Longest("aretheyhere", "yestheyarehere"));

            //var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
            //foreach (var item in pp)
            //{
            //    Console.WriteLine(Kata.IsPerfectPower(item));
            //}
            //Console.WriteLine(Kata.findNb(4183059834009));
            //Console.WriteLine(Kata.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
            //Console.WriteLine(Kata.DescendingOrder(123124));
            ////Console.WriteLine(Kata.Solve("catchphrase"));
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
            //Console.WriteLine(Kata.overTheRoad(7, 11));
            //Console.WriteLine(Kata.OddOrEven(new int[] { -1023, 1, -2 }));
            //Console.WriteLine(Kata.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 }));
            //Console.WriteLine(Kata.NumberFormat(123124));
            ////Console.WriteLine(Kata.AlphabetWar("*rd"));
            ////Console.WriteLine(Kata.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray());
            //Console.WriteLine(Kata.WhatIsTheTime("10:00"));
            //Console.WriteLine(Kata.calculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
            //Console.WriteLine(Kata.Doubleton(1234));
            //Console.WriteLine(Kata.ComputeDepth(42));
            //Console.WriteLine(Kata.WhatTimeIsIt(191.87d));
            //Console.WriteLine(Kata.Solve2(new int[] { 4, 7, 10 }));
            //Console.WriteLine(Kata.SumCubes(10));
            //Console.WriteLine(Kata.Stars(5));
            //Console.WriteLine(Kata.Order(""));
            //Console.WriteLine(Kata.TitleCase("a clash of KINGS", "a an the of"));
            //Console.WriteLine(Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            //Console.WriteLine(Kata.EvenOrOdd("124326546547649683563465"));
            //Console.WriteLine(Kata.DateNbDays(3525, 4822, 3));
            //Console.WriteLine(Kata.DataReverse(new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 }));
            //Console.WriteLine(Kata.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
            //Console.WriteLine(Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            //Console.WriteLine(Kata.HasSubpattern("abbaabbaabba"));
            //Console.WriteLine(Kata.Count("aabb"));
            //Console.WriteLine(Kata.Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" }));
            //Console.WriteLine(Kata.heron(3, 4, 5));
            //Console.WriteLine(Kata.FindDifference(new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 }));
            //Console.WriteLine(Kata.Pattern(8));
            //Console.WriteLine(Kata.Disemvowel("This website is for losers LOL!"));
            //Console.WriteLine(Kata.FindDeletedNumber(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new List<int>() { 5, 7, 1, 9, 4, 8, 2, 3 }));
            //Console.WriteLine(Kata.GetNumber("1234567890"));
            //Console.WriteLine(Kata.MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
            //Console.WriteLine(Kata.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
            //Console.WriteLine(Kata.FindRoot(273409989789784.88, 43));
            //Console.WriteLine(Pow(-4, -2));
            //Console.WriteLine(Kata.evaporator(10, 10, 10));
            //Dinglemouse dinglemouse = new Dinglemouse("Clint", "Eastwood");
            //Console.WriteLine(dinglemouse.FullName);
            //Console.WriteLine(Kata.HasUniqueChars("abcdef"));
            //Console.WriteLine(Kata.Bald("--/--/---/-/---"));
            //Console.WriteLine(Kata.MoveVowel("maker"));
            //Console.WriteLine(Kata.sqInRect(5, 3));
            //Console.WriteLine(Kata.Scramble("cedewaraaossoqqyt", "codewars"));
            //Console.WriteLine(Kata.MultiplicationTable(5));
            //Console.WriteLine(Kata.Epidemic(12, 288, 1007, 2, 0.00206, 0.46));
            //Console.WriteLine(Kata.IsVow(new object[] { 118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106 }));
            //Console.WriteLine(Kata.WallPaper(6.3, 4.5, 3.29));
            //Console.WriteLine(Kata.MaxSumDig(50000, 150));
            //Console.WriteLine(Kata.SortTransform(new[] { 111, 112, 113, 114, 115, 113, 114, 110 }));
            //Console.WriteLine(Kata.MaxRot(38458215));
            //Console.WriteLine(Kata.NbDig(11011, 2));
            //Console.WriteLine(Kata.SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107));
            //Console.WriteLine(Kata.EasyLine(7));
            //Console.WriteLine(Kata.binaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
            //Console.WriteLine(Kata.Gordon("What feck damn cake"));
            //Console.WriteLine(Kata.ReverseNumber(-123));
            //Console.WriteLine(Kata.AdjacentElementsProduct(new int[] { 21, 3, 6, -2, -5, 7, 3 }));
            ////Console.WriteLine(Kata.ReverseLetter("ultr53o?n"));
            //Console.WriteLine(Kata.MaxRedigit(123));
            //Console.WriteLine(Kata.CountSalutes(">>>>>>>>>>>>>>>>>>>>>----<->"));
            //Console.WriteLine(Kata.RemoveExclamationMarks("!!"));
            //Console.WriteLine(Kata.Digitize(1234));
            //Console.WriteLine(Kata.Fortune(100000, 1, 2000, 15, 1));
            //Console.WriteLine(Kata.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1));
            //Console.WriteLine(Kata.Table(new[]
            //  {
            //    "6:0 FC Bayern Muenchen - Werder Bremen",
            //    "1:0 Eintracht Frankfurt - Schalke 04",
            //    "0:2 FC Augsburg - VfL Wolfsburg",
            //    "1:1 Hamburger SV - FC Ingolstadt",
            //    "2:0 1. FC Koeln - SV Darmstadt",
            //    "2:1 Borussia Dortmund - FSV Mainz 05",
            //    "2:1 Borussia Moenchengladbach - Bayer Leverkusen",
            //    "-:- Hertha BSC Berlin - SC Freiburg",
            //    "-:- TSG 1899 Hoffenheim - RasenBall Leipzig"
            //  }));
            //Console.WriteLine(Kata.Check(new object[] { 66, 101 }, 66));
            //Console.WriteLine(Kata.Movie(100, 10, 0.95));
            //Console.WriteLine(Kata.ReverseSeq(5));
            //Console.WriteLine(Kata.Divisors(4));
            //Console.WriteLine(Kata.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 1, 1));
            //Console.WriteLine(Kata.howmuch(1, 100));
            //Console.WriteLine(Kata.ValidateString(new[] { "code", "wars" }, "codewar"));
            //Console.WriteLine(Kata.Averages(new int[] { 10}));
            //Console.WriteLine(Kata.Gps(14, new double[] { }));
            //Console.WriteLine(Kata.PartsSums(new int[] { 0, 1, 3, 6, 10 }));
            //Console.WriteLine(Kata.PowerSumDigTerm(2));
            //Console.WriteLine(Kata.ToTime(323500));
            //Console.WriteLine(Kata.game(1));
            //Console.WriteLine(Kata.Maskify("ewqeqweqw"));
            //Console.WriteLine(Kata.Divisions(2450,5));
            //Console.WriteLine(Kata.Solution(10));
            //Console.WriteLine(Kata.Correct("001122"));
            //Console.WriteLine(Kata.isAValidMessage("3hey5hello2hi"));
            //Console.WriteLine(Kata.CatMouse("C..m"));
            //Console.WriteLine(Kata.Bump("_nnnnnnn_n__n______nn__nn_nnn"));
            //Console.WriteLine(Kata.PosAverage("444996, 699990, 666690, 096904, 600644, 640646, 606469, 409694, 666094, 606490"));
            //Console.WriteLine(Kata.PaintLetterBoxes(125,132));
            //Console.WriteLine(Kata.nbMonths(2000, 8000, 1000, 1.5));
            //Console.WriteLine(Kata.Solution(5));
            //Console.WriteLine(Kata.Gcd(30,12));
            //Console.WriteLine(Kata.IsDuoDigit(2020));
            //Console.WriteLine(Kata.Count1(4));
            //Console.WriteLine(Kata.Solveint(160,70,70,10));
            //Console.WriteLine(Kata.SolutionInt(10));
            //Console.WriteLine(Kata.SolutionStr("abcdefz"));
            //Console.WriteLine(Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            //Console.WriteLine(Kata.Task("Monday", 4, 3));
            //List<int> ts = new List<int> { 50 };
            //Console.WriteLine(Kata.chooseBestSum(163,3,ts));
            //Console.WriteLine(Kata.SpinWords("Just kidding there is still one more"));
            //Console.WriteLine(Kata.Unlock("Nokia"));
            Console.WriteLine(Kata.digitize(8675309));
            

        }
        public class Dinglemouse
        {
            private string firstName;
            private string lastName;
            public string FullName
            {
                get
                {
                    return $"{firstName} {lastName}".Trim();
                }
            }

            public Dinglemouse(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
        }
        public static double Pow(double num, int pow)
        {
            double result = 1;

            if (pow > 0)
            {
                for (int i = 1; i <= pow; ++i)
                {
                    result *= num;
                }
            }
            else if (pow < 0)
            {
                for (int i = -1; i >= pow; --i)
                {
                    result /= num;
                }
            }

            return result;
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
                    if (numbers[i] + numbers[y] == target)
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
            int minute = (60 - Convert.ToInt32(timeInMirror.Substring(3, 2))) % 60;


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
                if (u >= 10)
                    break;
            }
            return count;
        }

        public static string WhatTimeIsIt(double angle)
        {
            int x = (int)(angle / 30);
            double m = Math.Floor((angle % 30) * 2);
            if (angle < 30)
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

        public static long SumCubes(int n)
        {
            double x = 0;
            for (int i = 1; i <= n; i++)
            {
                x += Math.Pow(i, 3);
            }
            return (long)x;
        }

        public static string Stars(int n)
        {
            string result = "";
            if (n < 0 || n % 2 == 0)
                return null;
            else
                for (int i = 1; i <= n; i += 2)
                {
                    result += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
                }
            for (int y = n - 2; y > 0; y -= 2)
            {
                result += new string(' ', (n - y) / 2) + new string('*', y) + "\n";
            }
            return result;
        }

        public static string Order(string words)
        {
            if (words == "")
                return "";
            else
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();

                string[] split = words.Split(' ');

                foreach (var item in split)
                {
                    Match match = Regex.Match(item, @"(\d+)");
                    dict.Add(item, Convert.ToInt32(match.Value));
                }
                var sorted = dict.OrderBy(a => a.Value).ToList();

                List<string> list = sorted.Select(a => a.Key).ToList();

                return String.Join(" ", list);
            }
        }

        public static string TitleCase(string title, string minorWords)
        {
            if (minorWords == null)
                minorWords = "";

            string Nuovo = "";


            foreach (string word in title.Split())
            {
                if (minorWords.ToLower().Split().Contains(word.ToLower()))
                    Nuovo += word.ToLower() + " ";
                else
                    Nuovo += word.First().ToString().ToUpper() + word.Substring(1).ToLower() + " ";
            }
            return (Nuovo.First().ToString().ToUpper() + Nuovo.Substring(1)).Trim();
        }

        public static int SumMix(object[] x)
        {
            int[] array = Array.ConvertAll(x, i => Convert.ToInt32(i));
            return array.Sum();
        }
        public static string EvenOrOdd(string str)
        {
            long odd = 0;
            long even = 0;
            foreach (var item in str)
            {
                if (item % 2 == 0)
                {
                    even += int.Parse(item.ToString());
                }
                if (item % 2 != 0)
                {
                    odd += int.Parse(item.ToString());
                }
            }
            if (even > odd)
            {
                return "Even is greater than Odd";
            }
            if (even < odd)
            {
                return "Odd is greater than Even";
            }
            else
                return "Even and Odd are the same";
        }

        public static String DateNbDays(double a0, double a, double p)
        {
            string toFormat = "yyyy-MM-dd";
            DateTime today = new DateTime(2016, 1, 1);
            int count = 0;
            while (a > a0)
            {
                a0 += a0 * (p / 36000);
                count++;
            }
            DateTime result = today.AddDays(count);
            return result.ToString(toFormat);
        }

        public static int[] DataReverse(int[] data)
        {
            int x = data.Count() / 8;
            string result = "";
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < data.Length; i += 8)
            {
                list.Add(data.Skip(i).Take(8).ToArray());
            }
            list.Reverse();

            foreach (var item in list)
            {
                result += string.Join("", item);
            }
            int[] newArr = result.Where(y => char.IsNumber(y)).Select(y => y - 48).ToArray();
            return newArr;
        }

        public static string PrinterError(String s)
        {

            return $"{Regex.Matches(s, @"[n-zN-Z]").Count} / {s.Length}";
        }

        public static int[] SortArray(int[] array)
        {
            var sortedOdds = new List<int>(array.Length);
            var oddsIndexes = new List<int>(array.Length);
            var newArray = new int[array.Length];

            for (var i = 0; i < array.Length; i++) // O(n)
            {
                var value = array[i];
                if (value % 2 == 1)
                {
                    sortedOdds.Add(value);
                    oddsIndexes.Add(i);
                }
                else
                {
                    newArray[i] = value;
                }
            }

            sortedOdds.Sort(); // average complexity O(n log n)

            for (var j = 0; j < sortedOdds.Count; j++) // O(n)
            {
                var value = sortedOdds[j];
                var index = oddsIndexes[j];
                newArray[index] = value;
            }

            return newArray;
        }

        public static bool HasSubpattern(string str)
        {

            //StringBuilder result = new StringBuilder();
            //string pattern = "";
            //int i = 1;
            //for (i = 1; i < str.Length; i++)
            //{
            //    result.Append(string.Concat(Enumerable.Repeat(str.Substring(0, i), str.Length / i)));
            //    if (result.ToString() == str)
            //    {
            //        pattern = str.Substring(0, i);
            //        break;
            //    }
            //    result.Clear();
            //}
            //var matches = Regex.Matches(str, pattern).Count;

            //if (i * matches == str.Length)
            //    return true;
            //else
            //    return false;

            return Regex.IsMatch(str, @"^(.+)\1+$");
        }

        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(c => c).OrderBy(c => c.Key).ToDictionary(grp => grp.Key, grp => grp.Count());
        }

        public static string Switcher(string[] x)
        {
            string result = "";
            foreach (var item in x)
            {
                switch (item)
                {
                    case "26":
                        result += "a";
                        break;
                    case "25":
                        result += "b";
                        break;
                    case "24":
                        result += "c";
                        break;
                    case "23":
                        result += "d";
                        break;
                    case "22":
                        result += "e";
                        break;
                    case "21":
                        result += "f";
                        break;
                    case "20":
                        result += "g";
                        break;
                    case "19":
                        result += "h";
                        break;
                    case "18":
                        result += "i";
                        break;
                    case "17":
                        result += "j";
                        break;
                    case "16":
                        result += "k";
                        break;
                    case "15":
                        result += "l";
                        break;
                    case "14":
                        result += "m";
                        break;
                    case "13":
                        result += "n";
                        break;
                    case "12":
                        result += "o";
                        break;
                    case "11":
                        result += "p";
                        break;
                    case "10":
                        result += "q";
                        break;
                    case "9":
                        result += "r";
                        break;
                    case "8":
                        result += "s";
                        break;
                    case "7":
                        result += "t";
                        break;
                    case "6":
                        result += "u";
                        break;
                    case "5":
                        result += "v";
                        break;
                    case "4":
                        result += "w";
                        break;
                    case "3":
                        result += "x";
                        break;
                    case "2":
                        result += "y";
                        break;
                    case "1":
                        result += "z";
                        break;
                    case "27":
                        result += "!";
                        break;
                    case "28":
                        result += "?";
                        break;
                    case "29":
                        result += " ";
                        break;
                }
            }
            return result;
        }

        public static double heron(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double g = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return g;
        }

        public static int FindDifference(int[] a, int[] b)
        {
            int x = 1;
            int y = 1;
            for (int i = 0; i < a.Length; i++)
            {
                x *= a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                y *= b[i];
            }
            return Math.Abs(x - y);
        }

        public static string Pattern(int n)
        {
            var result = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                var forw = string.Concat(Enumerable.Range(1, i).Select(x => (x % 10).ToString()));
                var back = string.Concat(forw.Reverse().Skip(1));
                var pad = string.Concat(Enumerable.Repeat(' ', n - i));
                result.Add(pad + forw + back + pad);
            }
            return string.Join("\n", result);
        }

        public static string Disemvowel(string str)
        {
            string vowels = "aeiouyAEIOUY";
            return new string(str.Where(c => !vowels.Contains(c)).ToArray());
        }

        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            var missing = startingList.Except(mixedList).ToList();
            return missing.Count > 0 ? missing[0] : 0;
        }

        public static int GetNumber(string str)
        {

            string[] n = new string[str.Length - 4];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = str.Substring(i, 5);
            }
            return int.Parse(n.Max());
        }

        public static int MinimumNumber(int[] numbers)
        {
            for (int i = numbers.Sum(); ; i++)
                if (!Enumerable.Range(2, (int)Math.Sqrt(i)).Where(divisor => i % divisor == 0).Any())
                    return i - numbers.Sum();
        }

        public static int[] NoOdds(int[] values)
        {
            foreach (var item in values)
            {
                if (item % 2 != 0)
                    values = values.Where(val => val != item).ToArray();
            }

            return values;
        }

        public static double FindRoot(double x, int n)
        {
            return Math.Pow(x, 1.0 / n);
        }

        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            int count = 0;
            double newcontent = content;
            int i;
            for (i = 0; newcontent > content * (threshold / 100); i++)
            {
                newcontent -= newcontent * (evap_per_day / 100);
            }
            return i;
        }

        public static bool HasUniqueChars(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                for (int y = str.IndexOf(item) + 1; y < str.Length; y++)
                {
                    if (item == str[y])
                    {
                        count++;
                    }
                }
            }
            return count > 0 ? false : true;

        }

        public static string[] Bald(string x)
        {
            string[] arr = new string[2];
            int count = 0;
            foreach (var item in x)
            {
                if (item == '/')
                {
                    count++;
                }
            }
            arr[0] = x.Replace("/", "-");
            switch (count)
            {
                case 0:
                    arr[1] = "Clean!";
                    break;
                case 1:
                    arr[1] = "Unicorn!";
                    break;
                case 2:
                    arr[1] = "Homer!";
                    break;
                case 3:
                case 4:
                case 5:
                    arr[1] = "Careless!";
                    break;
                default:
                    arr[1] = "Hobo!";
                    break;

            }
            return arr;
        }
        public static string MoveVowel(string input)
        {

            string vowels = "aeiou";
            int i = 0;
            int y = 0;
            char[] array = new char[input.Length];
            foreach (var item in input)
            {
                if (vowels.Contains(item))
                {
                    i++;
                }

            }
            foreach (var item in input)
            {
                if (vowels.Contains(item))
                {
                    array[input.Length - i] = item;
                    i--;
                }
                else
                {
                    array[y] = item;
                    y++;
                }
            }

            return new string(array);
        }
        public static List<int> sqInRect(int lng, int wdth)
        {
            int min = 0;
            int max = 0;
            int temp;
            List<int> list = new List<int>();
            List<int> newlist = new List<int>();
            int total = 0;
            if (lng == wdth)
            {
                return null;
            }
            if (lng > wdth)
            {
                max = lng;
                min = wdth;
            }
            else
            {
                max = wdth;
                min = lng;
            }
            while (total < lng * wdth)
            {

                list.Add(min * min);
                total += min * min;
                max -= min;
                if (max < min)
                {
                    temp = max;
                    max = min;
                    min = temp;

                }
            }

            foreach (var item in list)
            {
                newlist.Add((int)Math.Sqrt(item));
            }
            newlist.ForEach(Console.WriteLine);
            return newlist;

        }
        public static bool Scramble(string str1, string str2)
        {
            if (str1.Length < str2.Length) return false;
            foreach (char item in str1.ToCharArray())
            {
                if (str2.Contains(item))
                {
                    str2 = str2.Remove(str2.IndexOf(item), 1);
                }
            }
            return str2.Length == 0 ? true : false;
        }

        public static int[,] MultiplicationTable(int size)
        {
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }

        public static int Epidemic(int tm, int n, int s0, int i0, double b, double a)
        {
            var s = (double)s0;
            var i = (double)i0;
            var r = (double)0;
            var t = (double)0;
            var dt = (double)tm / n;
            var imax = 0;
            while (t < tm)
            {
                var sd = dt * (-b * s * i);
                var id = dt * (b * s * i - a * i);
                var rd = dt * (a * i);
                s += sd;
                i += id;
                r += rd;
                t += dt;
                imax = Math.Max(imax, (int)Math.Floor(i));
            }
            return imax;
        }

        public static object[] IsVow(object[] a)
        {
            string vow = "aeiou";
            for (int i = 0; i < a.Length; i++)
            {
                if (vow.Contains(Convert.ToChar(a[i])))
                {
                    a[i] = (Convert.ToChar(a[i])).ToString();
                }
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            return a;
        }
        public static string WallPaper(double l, double w, double h)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1,"one" },
                {2,"two" },
                {3, "three" },
                {4,"four" },
                {5,"five" },
                {6,"six"},
                {7,"seven" },
                {8,"eight" },
                {9,"nine" },
                {10,"ten" },
                {11,"eleven" },
                {12,"twelve" },
                {13,"thirteen" },
                {14,"fourteen" },
                {15,"fifteen" },
                {16,"sixteen" },
                {17,"seventeen" },
                {18,"eighteen" },
                {19,"nineteen" },
                {20,"twenty" }

            };
            if (l == 0 || w == 0 || h == 0)
            {
                return "zero";
            }
            double total = (int)Math.Ceiling((((l + w) * 2 * h) / 5.2) * 1.15);

            var myKey = dict.FirstOrDefault(x => x.Key == Convert.ToInt32(total)).Value;

            return myKey.ToString();
        }

        public static long[] MaxSumDig(long nmax, int maxsm)
        {
            int sum = 0;
            int countsum = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            long[] arr = new long[3];
            for (int i = 1000; i <= nmax; i++)
            {
                sum = 0;
                int u = i;
                while (u != 0)
                {
                    sum += u % 10;
                    u /= 10;

                }
                dict.Add(i, sum);
            }
            foreach (var item in dict.Values)
            {
                if (item <= maxsm)
                {
                    countsum++;
                }
            }
            var values = dict.Where(item => item.Value <= maxsm).Select(item => item.Key).ToList();
            var avg = values.Average();
            //int closest = values.Aggregate((x, y) => Math.Abs(x - avg) < Math.Abs(y - avg) ? x : y);
            long closest = values.OrderBy(n => Math.Abs(avg - n)).First();


            arr[0] = countsum;
            arr[1] = closest;
            arr[2] = values.Sum();
            return arr;
        }

        public static string SortTransform(int[] arr)
        {
            int lenght = arr.Length;
            string result = Convert.ToChar(arr[0]).ToString() + Convert.ToChar(arr[1]).ToString() + Convert.ToChar(arr[lenght - 2]).ToString() + Convert.ToChar(arr[lenght - 1]).ToString() + "-";
            Array.Sort(arr);
            result += Convert.ToChar(arr[0]).ToString() + Convert.ToChar(arr[1]).ToString() + Convert.ToChar(arr[lenght - 2]).ToString() + Convert.ToChar(arr[lenght - 1]).ToString() + "-";
            Array.Reverse(arr);
            result += Convert.ToChar(arr[0]).ToString() + Convert.ToChar(arr[1]).ToString() + Convert.ToChar(arr[lenght - 2]).ToString() + Convert.ToChar(arr[lenght - 1]).ToString() + "-";
            Array.Reverse(arr);
            result += Convert.ToChar(arr[0]).ToString() + Convert.ToChar(arr[1]).ToString() + Convert.ToChar(arr[lenght - 2]).ToString() + Convert.ToChar(arr[lenght - 1]).ToString();
            return result;
        }

        public static long MaxRot(long n)
        {
            List<long> list = new List<long>();
            string result = n.ToString();
            int x = result.Length;
            list.Add(n);
            result = result.Substring(1, x - 1) + result.Substring(0, 1);
            list.Add(Convert.ToInt64(result));
            for (int i = 1; i < x - 1; i++)
            {
                result = result.Substring(0, i) + result.Substring(i + 1, x - (i + 1)) + result.Substring(i, 1);
                list.Add(Convert.ToInt64(result));
            }
            return list.Max();
        }

        public static int NbDig(int n, int d)
        {
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                list.Add((int)Math.Pow(i, 2));
            }
            string data = string.Join("", list);
            var array = data.ToCharArray();
            foreach (var item in array)
            {
                if (item == d + 48)
                {
                    count++;
                }
            }
            return count;

            //return Enumerable.Range(0, n + 1).Sum(i => (i * i).ToString().Count(c => c == d.ToString().First()));
        }
        public static bool SmallEnough(int[] a, int limit)
        {
            bool bol = false;
            int count = 0;
            foreach (var item in a)
            {
                if (item <= limit)
                {
                    count++;
                }
                if (count == a.Length)
                {
                    bol = true;
                }
            }
            return bol;

        }

        public static BigInteger EasyLine(int n)
        {
            BigInteger sum = 1;
            for (var i = 1; i <= n; i++)
            {
                sum = sum * (n + i) / i;
            }

            return sum;
        }

        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return Convert.ToInt32(string.Join("", BinaryArray),2);
        }

        public static string Gordon(string a)
        {
            string[] arr = a.ToLower().Split(' ');
           
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Contains("a"))
                {
                    arr[i] = arr[i].Replace("a", "@");
                }
                if(arr[i].Contains("e"))
                {
                    arr[i] = arr[i].Replace("e", "*");
                }
                if (arr[i].Contains("i"))
                {
                    arr[i] = arr[i].Replace("i", "*");
                }
                if (arr[i].Contains("o"))
                {
                    arr[i] = arr[i].Replace("o", "*");
                }
                if (arr[i].Contains("u"))
                {
                    arr[i] = arr[i].Replace("u", "*");
                }
                arr[i] += "!!!!";
               
            }
            return string.Join(" ", arr).ToUpper();
        }

        public static int ReverseNumber(int n)
        {
            int reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }

            return reverse;
        }

        public static int AdjacentElementsProduct(int[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length -1; i++)
            {
                list.Add(array[i] * array[i + 1]);
            }
            return list.Max();
        }

        public static string ReverseLetter(string str)
        {
            var result = new string(str.Where(c => Char.IsLetter(c)).ToArray()).Reverse();
            return string.Concat(result);
        }
        public static int? MaxRedigit(int num)
        {
            if (num > 99 && num < 1000)
                return int.Parse(string.Concat($"{num}".OrderByDescending(e => e)));
            return null;
        }

        public static int CountSalutes(string hallway)
        {
            int ns = 0, nr = 0;
            foreach (char c in hallway)
            {
                switch (c)
                {
                    case '>': nr++; break;
                    case '<': ns += nr; break;
                }
            }
            return ns * 2;
        }
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", "");
        }
        public static long[] Digitize(long n)
        {
            var digits = new List<long>();

            for (; n != 0; n /= 10)
                digits.Add((int)(n % 10));

            var arr = digits.ToArray();
            
            return arr;
        }

        public static Boolean Fortune(int f0, double p, int c0, int n, double i)
        {
            
            for (int y = 0; y <= n; y++)
            {
                f0 = (int)(f0 + (f0 * (p / 100)) - c0);
                c0 = (int)(c0 + (c0 * (i / 100)));
            }

            return f0 > 0;
        }

        public static String LongestConsec(string[] strarr, int k)
        {
            if (k == 0 || k > strarr.Length)
            {
                return "";
            }
            string s = "";
            List<string> list = new List<string>();
            for (int i = 0; i < strarr.Length - k + 1; i++)
            {
                for (int y = 0; y < k; y++)
                {
                    s += strarr[i+y];

                }
                list.Add(s);
                s = "";
            }
            return list.OrderByDescending(x => x.Length).First();

            //return s.Length == 0 || s.Length < k || k <= 0 ? ""
            //: Enumerable.Range(0, s.Length - k + 1)
            //            .Select(x => string.Join("", s.Skip(x).Take(k)))
            //            .OrderByDescending(x => x.Length)
            //            .First();
        }

        public static string Table(string[] results)
        {
            List<string[]> tablePlaces = new List<string[]>();
            foreach (var resultMatch in results)
            {
                var result = resultMatch.Substring(0, resultMatch.IndexOf(" "));
                var match = resultMatch.Substring(resultMatch.IndexOf(" ") + 1);
                var played = !result.Contains("-");
                var goals = result.Split(':').Select(g => played ? int.Parse(g) : 0).ToArray();
                var teams = match.Split('-');
                tablePlaces.Add(new string[]
                {
        "0",
        teams[0].Trim(),
        played ? "1" : "0",
        goals[0] > goals[1] ? "1" : "0",
        played ? (goals[0] == goals[1] ? "1" : "0") : "0",
        goals[0] < goals[1] ? "1" : "0",
        goals[0] + ":" + goals[1],
        (goals[0] - goals[1]).ToString(),
        played ? (goals[0] > goals[1] ? "3" : goals[0] == goals[1] ? "1" : "0") : "0",
                });
                tablePlaces.Add(new string[]
                {
        "0",
        teams[1].Trim(),
        played ? "1" : "0",
        goals[1] > goals[0] ? "1" : "0",
        played ? (goals[1] == goals[0] ? "1" : "0") : "0",
        goals[1] < goals[0] ? "1" : "0",
        goals[1] + ":" + goals[0],
        (goals[1] - goals[0]).ToString(),
        played ? (goals[1] > goals[0] ? "3" : goals[1] == goals[0] ? "1" : "0") : "0",
                });
            }

            tablePlaces = tablePlaces.OrderByDescending(tp => int.Parse(tp[8]))
                          .ThenByDescending(tp => int.Parse(tp[7]))
                          .ThenByDescending(tp => int.Parse(tp[6].Split(':')[0]))
                          .ThenBy(tp => tp[1]).ToList();

            tablePlaces[0][0] = "1";

            for (int i = 2; i <= 18; i++)
            {
                var line = tablePlaces[i - 1];

                if (line[6] == tablePlaces[i - 2][6] && line[8] == tablePlaces[i - 2][8])
                {
                    line[0] = tablePlaces[i - 2][0];
                }
                else
                {
                    line[0] = i.ToString();
                }
            }

            return string.Join("\n", tablePlaces.Select(tp => tp[0].PadLeft(2, ' ') + ". " + tp[1].PadRight(30, ' ') + tp[2] + "  " + tp[3] + "  " + tp[4] + "  " + tp[5] + "  " + tp[6] + "  " + tp[8]));
        }

        public static bool Check(object[] a, object x)
        {
            return a.Intersect(new object[] { x }).Any();
        }

        public static int Movie(int card, int ticket, double perc)
        {
            int result = 0;
            double cardticket = 0;
            double y = ticket;

            for (int i = 0; i < int.MaxValue; i++)
            {
                
                cardticket += y * perc;
                y *= perc;
                double h = cardticket + card;
                if (ticket * i > Math.Ceiling(h))
                {
                    result = i;
                    break;
                }
                
            }
            return result;
        }

        public static int[] ReverseSeq(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = n - i;
            }
            return arr;
        }
        public static int Divisors(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static string Crap(char[,] x, int bags, int cap)
        {
            int count = 0;
            foreach (var item in x)
            {
                if(item == 'D')
                {
                    return "Dog!!";
                }
                if(item == '@')
                {
                    count++;
                }
            }
            return count <= bags * cap ? "Clean" : "Cr@p";
        }

        public static string howmuch(int m, int n)
        {
            int max = Math.Max(m, n);
            int min = Math.Min(m, n);
            List<string> list = new List<string>();
            if(n == m)
            {
                return "[]";
            }
            for (int i = min; i <= max; i++)
            {
                for (int y = 1; y < max - min; y++)
                {
                    if (i % (7 * y) == 2 )
                    {
                        for (int h = y; h > 0; h--)
                        {
                            if(i % (9 * h) == 1)
                            {
                                list.Add($"[M: {i}, B: {i / 7}, C: {i / 9}]");
                            }
                        }
                        break;
                    }
                    
                }
            }
            return "[" + string.Join("", list) + "]";
        }

        public static bool ValidateString(string[] dictionary, string word)
        {
            string open = word;
            foreach (var w in dictionary)
            {
                if (word.Contains(w))
                {
                    foreach (var a in w)
                    {
                        open = open.Replace(new string(a, 1), "");
                    }
                }
            }
            if (open.Length == 0)
            {
                return true;
            }
            return false;
        }

        public static double[] Averages(int[] numbers)
        {
            if (numbers.Length < 2) return new double[0];
            double[] arr = new double[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                arr[i] = (numbers[i] + numbers[i + 1]) / 2f;
            }
            return arr;
        }

        public static int Gps(int s, double[] x)
        {
            if (s == 0 || x.Sum() == 0)
            {
                return 0;
            }
            List<double> list = new List<double>();
            for (int i = 0; i < x.Length - 1; i++)
            {
                list.Add(3600 * (x[i + 1] - x[i]) / s);
            }
            return (int)Math.Floor(list.Max());
        }

        public static int[] PartsSums(int[] ls)
        {
            //int l = ls.Length;
            //int[] arr = new int[l + 1];
            //List<int[]> list = new List<int[]>();
            //for (int y = 0; y < l; y++)
            //{
            //    list.Add(ls);
            //    ls = ls.Where(val => val != ls[0]).ToArray();
            //}
            //list.Add(new int[] { });
            //int i = 0;
            //for (i = 0; i < list.Count - 1; i++)
            //{
            //    arr[i] = list[i].Sum();
            //}
            //arr[i] = 0;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //return arr;
            var arr = new int[ls.Length + 1];

            for (int i = ls.Length - 1; i >= 0; i--)
            {
                arr[i] = ls[i] + arr[i + 1];
            }

            return arr;
        }

        public static long PowerSumDigTerm(int n)
        {
            List<long> powers = new List<long>();
            for (int i = 3; i < 500; i++)
            {
                for (int k = 2; k < 50; k++)
                {
                    long sum = 0;
                    long pow = (long)Math.Pow(i, k);
                    long powCopy = pow;
                    while (powCopy > 0)
                    {
                        sum += powCopy % 10;
                        powCopy = powCopy / 10;
                    }
                    if (sum == i)
                    {
                        powers.Add(pow);
                        
                    }
                }
            }
            powers.Sort();
            return powers[n - 1];
        }

        public static string ToTime(int seconds)
        {
            int min = seconds / 60;
           
            if(min > 59)
            {
                int hr = min / 60;
                min %= (hr * 60);
                return $"{hr} hour(s) and {min} minute(s)";
            }
            return $"0 hour(s) and {min} minute(s)";
        }

        public static string game(long n)
        {
            if (n % 2 == 0)
            {
                return string.Format("[{0}]", (n * n) / 2);
            }
            return string.Format("[{0}, 2]", n * n);
        }

        public static string Maskify(string cc)
        {
            if (cc.Length > 4)
            {
                var sb = new StringBuilder(cc);
                sb.Remove(0, cc.Length - 4);
                sb.Insert(0, "#", cc.Length - 4);
                return sb.ToString();
            }
            else
                return cc;
        }
        public static int Divisions(int n, int divisor)
        {
            int count = 0;
            while(n >= divisor)
            {
                n /= divisor;
                count++;
            }
            return count;
        }
        public static long Solution(long n)
        {
            string numbers = "";
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                numbers += i.ToString();
            }
            var ch = numbers.ToCharArray();
            foreach (var item in ch)
            {
                result += char.GetNumericValue(item);
            }
            return (long)result;
        }
        public static string Correct(string timeString)
        {
            if (string.IsNullOrEmpty(timeString))
            {
                return timeString;
            }

            var m = Regex.Match(timeString, @"^(\d\d):(\d\d):(\d\d)$");
            if (!m.Success)
            {
                return null;
            }

            var ts = new TimeSpan(
              int.Parse(m.Groups[1].Value),
              int.Parse(m.Groups[2].Value),
              int.Parse(m.Groups[3].Value));

            return ts.ToString(@"hh\:mm\:ss");
        }

        public static bool isAValidMessage(string message)
        {
            //int count = 0;
            //List<int> ints = new List<int>();
            //List<string> strings = new List<string>();
            //var matches = Regex.Matches(message, "([a-z]+)|([0-9]+)");
            //if(matches.Count % 2 != 0)
            //{
            //    return false;
            //}
            //for (int i = 0; i < matches.Count; i+=2)
            //{
            //    if(matches[i].Value == matches[i+1].Value.Length.ToString())
            //    {
            //        count++;
            //    }
            //}

            //return count == matches.Count / 2;
            MatchCollection reg = Regex.Matches(message, @"(\d+)([A-z]*)");

            bool res = true;
            for (int i = 0; i < reg.Count; i++)
            {
                if (reg[i].Groups[1].Value != reg[i].Groups[2].Length.ToString())
                {
                    res = false;
                }
            }
            return res;
        }
        public static string CatMouse(string x)
        { 
            return Regex.Matches(x, "([.])").Count > 3 ? "Escaped!" : "Caught!";
        }
        public static string Bump(string input)
        {
            return Regex.Matches(input, "([n])").Count > 15 ? "Car dead" : "Woohoo!";
        }
        public static double PosAverage(string s)
        {
            double index = 0;
            double count = 0;
            var list = s.Replace(" ", "").Split(',').ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int x = i+1; x < list.Count; x++)
                {
                    for (int y = 0; y < list[i].Length; y++)
                    {
                        if (list[i][y] == list[x][y])
                        {
                            index++;
                        }
                    }
                    count++;
                }
            }
            double countr = count * list[0].Length;
            double result = (index / countr) * 100 ;
            return result;
        }

        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            int[] arr = new int[10];
            List<int> list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                int x = i;
                while (x > 0)
                {
                    var digit = x % 10;
                    list.Add(digit);
                    x /= 10;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                foreach (var item in list)
                {
                    
                    if(item == i)
                    {
                        count++;
                    }
                }
                arr[i] = count;
            }
            return arr;
        }

        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            int month = 0;
            double priceNew = startPriceNew;
            double priceOld = startPriceOld;
            double savings = priceOld;
            while (savings < priceNew)
            {
                month++;
                if (month % 2 == 0) percentLossByMonth += 0.5;
                priceOld -= priceOld * (percentLossByMonth / 100);
                priceNew -= priceNew * (percentLossByMonth / 100);
                savings = month * savingPerMonth + priceOld;
            }
            return new int[] { month, (int)(Math.Round(savings - priceNew)) };

        }
        public static string Solution(int value)
        {
            return "Value is " + value.ToString("00000");
        }
        public static int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        public static int IsDuoDigit(int number)
        {
            var digits = new List<int>();

            for (; number != 0; number /= 10)
                digits.Add(number % 10);

            var arr = digits.ToArray();
            if(arr.Distinct().Count() > 2)
            {
                return 0;
            }

            return 1;
        }
        public static int Count1(int n)
        {
            List<int[]> pairs = new List<int[]>();
            int count = 0;
            for (int x = 0; x < n - 1; x++)
            {
                for (int y = x + 1; y < n; y++)
                {
                    count++;
                }
            }
            return count;
        }
        public static string Solveint(int width, int height, int length, int mass)
        {
            string result = "";
            if (width * height * length < 1000000 && width < 150 && height < 150 && length < 150 && mass < 20)
            {
                result =  "STANDARD";
            }
            else if (width * height * length < 1000000 && (width > 150 || height > 150 || length > 150) || mass < 20)
            {
                result = "SPECIAL";
            }
            else if ((width * height * length > 1000000 || width > 150 || height > 150 || length > 150) && mass > 20)
            {
                result = "REJECTED";
            }
            return result;
              
        }
        public static int SolutionInt(int value)
        {
            return Enumerable.Range(0, value).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
        public static string[] SolutionStr(string str)
        {
            int move = 0;
            if(str.Length % 2 != 0)
            {
                str += "_";
            }
            string[] arr = new string[str.Length/2];
            for (int i = 0; i < str.Length / 2; i++)
            {
                arr[i] = str.Substring(move, 2);
                move += 2;
            }
            return arr;
        }

        public static int[] MoveZeroes(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            int y = 0;
            foreach (var item in arr)
            {
                if(item != 0)
                {
                    arr2[y] = item;
                    y++;
                }
            }
            for (int i = arr.Where(x=> x != 0).Count(); i < arr.Length; i++)
            {
                arr2[i] = 0;
            }
            return arr2;
        }
        public static string Task(string w, int n, int c)
        {
            string name;
            switch (w)
            {
                case "Monday":
                    name = "James";
                    break;
                case "Tuesday":
                    name = "John";
                    break;
                case "Wednesday":
                    name = "Robert";
                    break;
                case "Thursday":
                    name = "Michael";
                    break;
                default:
                    name = "William";
                    break;

            }
            return $"It is {w} today, {name}, you have to work, you must spray {n} trees and you need {n*c} dollars to buy liquid";
        }
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            return ls.Combinations(k).Select(x => (int?)x.Sum()).Where(x => x <= t).Max();
        }
        public static IEnumerable<IEnumerable<int>> Combinations(this IEnumerable<int> input, int size)
        {
            return size == 0 ? new[] { new int[0] } :
              input.SelectMany((e, i) =>
                input.Skip(i + 1).Combinations(size - 1).Select(c => (new[] { e }).Concat(c)));
        }

        public static string SpinWords(string sentence)
        {
            var arr = sentence.Split(' ').ToArray();
            var arr2 = new string[arr.Length];
            int i = 0;
            foreach (var item in arr)
            {
                if(item.Length > 5)
                {
                    var charitem = item.ToCharArray();
                    Array.Reverse(charitem);
                    arr2[i] = string.Join("", charitem);
                }
                else
                {
                    arr2[i] = item;
                }
                i++;
            }
            return string.Join(" ", arr2);
            //return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
        public static string Unlock(string str)
        {
            var chararr = str.ToLower().ToCharArray();
            string result = "";
            foreach (var item in chararr)
            {
                switch(item)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        result += "2";
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        result += "3";
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        result += "4";
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        result += "5";
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        result += "6";
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        result += "7";
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        result += "8";
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        result += "9";
                        break;
                }
            }
            return result;
        }
        public static int[] digitize(int n)
        {
            var arr = n.ToString().ToCharArray();
            int[] arr2 = new int[arr.Length];
            int i = 0;
            foreach (var item in arr)
            {
                arr2[i] = Convert.ToInt32(item - 48);
                i++;
            }
            return arr2;
            //n.ToString().Select(c => (int)char.GetNumericValue(c)).ToArray();
        }
    }
    

}

    




   

