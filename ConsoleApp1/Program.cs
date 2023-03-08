using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region fizzBuzz
            /*
            Console.WriteLine("bir reqm girin");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.fizzBuzz(n);
            */
            #endregion

            #region PlusMinusDecimal
            /* 
            List<int> arr = new List<int>()
            {
                -2,-1,0,1,2
            };

            Result.plusMinus(arr);
            */
            #endregion

            #region MiniMuxSum
            /*
            List<int> arr = new List<int>
            {
                -11,-5,-9,1,3,5,2,4
            };

            Result.MiniMaxSum(arr);
            */
            #endregion

            #region TimeConversion
            /*
            string result = Result.TimeConversion("07:16:59PM");

            Console.WriteLine(result);
            */
            #endregion

            #region FindMedian
            /*
            List<int> arr = new List<int>()
            {
                9,6,5,3,7,2,0,1,4,8
            };

            Result.findMedian(arr);
            */
            #endregion

            #region LonelyInteger

            //List<int> arr = new List<int>()
            //{
            //    1,2,3,4,3,2,1,6,5,9,8,7,9,6,5,8,7
            //};

            //int result = Result.LonelyInteger(arr);
            //Console.WriteLine(result);

            #endregion

            #region IsPermitation
            //Console.WriteLine(Result.IsPermitation("asa","saa"));
            #endregion

            #region FindUpperCaseWord
            /*
            Result.FindUpperCaseLetter("DDD example CQRS Event Sourcing");
            */
            #endregion

            #region CountWords
            //var result = Result.CountWords("Hello.How are you?Fine thank you.That is good");
            //Console.WriteLine(result);
            #endregion

            #region Factorial numbers
            //var result = Result.Factorial(4);
            //Console.WriteLine(result);
            #endregion

            #region Unique string
            //var result = Result.IsUniqueChars("NeetCode");
            //Console.WriteLine(result);
            #endregion

            #region Fibonacci numbers
            //var result = Result.Fib(5);
            //Console.WriteLine(result);
            #endregion

            #region Diagonal Difference
            //List<List<int>> arr = new List<List<int>>()
            //{
            //    new List<int> { 11, 2, 4 },
            //    new List<int> { 4, 5, 6 },
            //    new List<int> { 10, 8, -12 }
            //};

            //Console.WriteLine(Result.DiagonalDifference(arr));

            #endregion

            #region Counting Sort

            //List<int> arr = new List<int>()
            //{ 
            //    1,1,3,2,1
            //};
            //List<int> result = Result.CountingSort(arr);
            #endregion

            #region Stair case
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //Result.StairCase(n);
            #endregion

            #region Birthday Cake Candles


            //List<int> candles = new List<int>() { 3,1,2,3,3,3,5};

            //int result = Result.BirthdayCakeCandle(candles);

            //Console.WriteLine(result);

            #endregion

            #region Grading Students

            //List<int> grades = new List<int>()
            //{
            //    73,
            //    67,
            //    38,
            //    33
            //};

            //Result.GradingStudents(grades);

            #endregion

            #region Number Line Jumps Kangaroo

            //int x1 = 0;
            //int v1 = 3;
            //int x2 = 4;
            //int v2 = 2;

            //Console.WriteLine(Result.Kangaroo(x1, v1, x2, v2));

            #endregion

            #region Apple and Orange

            //Console.WriteLine("Zehmet olmasa sira ile Evin start pointini ve end pointini daxil edin:");
            //int s = Convert.ToInt32(Console.ReadLine().Trim());
            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Zehmet olmasa sira ile alma ve portagal agacinin location-ni daxil edin:");
            //int a = Convert.ToInt32(Console.ReadLine().Trim());
            //int b = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Zehmet olmasa sira ile dusen alma ve portagal sayini daxil edin:");
            //int m = Convert.ToInt32(Console.ReadLine().Trim());
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Zehmet olmasa dusen almalarin agacdan olan mesafesini daxil edin:");
            //List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            //Console.WriteLine("Zehmet olmasa dusen portagallarin agacdan olan mesafesini daxil edin:");
            //List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            //Result.CountApplesAndOranges(s, t, a, b, apples, oranges);

            #endregion

            #region Breaking the Records

            //Console.WriteLine("Zehmet olmasa oynanilan oyunlarin sayini daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Zehmet olmasa qazanilan xallari daxil edin:");
            //List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            //List<int> result = Result.BreakingTheRecords(scores);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Subarray Division

            //Console.WriteLine("Zehmet olmasa shokoladin kvadratlarinin sayini daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Zehmet olmasa kvadratlarin uzerindeki reqemleri daxil edin:");
            //List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            //Console.WriteLine("Zehmet olmasa sirasi ile dogum gununu sonra ise dogum ayini daxil edin:");

            //int d = Convert.ToInt32(Console.ReadLine().Trim());

            //int m = Convert.ToInt32(Console.ReadLine().Trim());

            //int result = Result.Birthday(s, d, m);
            //Console.WriteLine(result);

            #endregion

            #region Divisible Sum Pairs

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int n = Convert.ToInt32(firstMultipleInput[0]);

            //int k = Convert.ToInt32(firstMultipleInput[1]);

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //int result = Result.DivisibleSumPairs(n, k, arr);

            //Console.WriteLine(result);

            #endregion

            #region Migratory Birds

            //Console.WriteLine("Enter number of birds: ");
            //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Enter birds' IDs:");
            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //int result = Result.MigratoryBirds(arr);
            //Console.WriteLine(result);

            #endregion

            #region Day of the Programmer
            /*
            Marie invented a Time Machine and wants to test it by time-traveling
            to visit Russia on the Day of the Programmer (the 256th day of the year)
            during a year in the inclusive range from 1700 to 2700.

            From 1700 to 1917, Russia's official calendar was the Julian calendar;
            since 1919 they used the Gregorian calendar system. The transition from 
            the Julian to Gregorian calendar system occurred in 1918, when the next day 
            after January 31st was February 14th. This means that in 1918, February 14th was the 32nd day
            of the year in Russia.

            In both calendar systems, February is the only month with a variable amount of days;
            it has 29 days during a leap year, and 28 days during all other years. 
            In the Julian calendar, leap years are divisible by 4; in the Gregorian calendar,
            leap years are either of the following:

            Divisible by 400.
            Divisible by 4 and not divisible by 100.
            Given a year, , find the date of the 256th day of that year according to the official
            Russian calendar during that year. Then print it in the format dd.mm.yyyy, 
            where dd is the two-digit day, mm is the two-digit month, and yyyy is .

            For example, the given  = 1984. 1984 is divisible by 4, so it is a leap year.
            The 256th day of a leap year after 1918 is September 12, so the answer is .
             */


            //Console.WriteLine("Enter Year:");
            //int year = Convert.ToInt32(Console.ReadLine().Trim());

            //string result = Result.DayOfProgrammer(year);
            //Console.WriteLine(result);

            #endregion

            // not solved
            #region Between two sets

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int n = Convert.ToInt32(firstMultipleInput[0]);

            //int m = Convert.ToInt32(firstMultipleInput[1]);

            //List<int> arrA = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //List<int> arrB = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //int total = Result.getTotalX(arrA, arrB);

            //Console.WriteLine(total);
            #endregion
        }
    }

    #region fizzbuzz
    //class Result
    //{
    //    public static void fizzBuzz(int n)
    //    {
    //        for (int i = 0; i <= n; i++)
    //        {
    //            if(i % 3 == 0 && i % 5 == 0)
    //            {
    //                Console.WriteLine("FizzBuzz");
    //            }
    //            else if(i % 3 == 0)
    //            {
    //                Console.WriteLine("Fizz");
    //            }
    //            else if(i % 5 == 0)
    //            {
    //                Console.WriteLine("Buzz");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i);
    //            }

    //        }
    //    }
    //}
    #endregion


    #region PlusMinusDecimal
    //class Result
    //{
    //    public static void plusMinus(List<int> arr)
    //    {
    //        decimal positiveCount = 0;
    //        decimal negativeCount = 0;
    //        decimal zeroCount = 0;



    //        for (int i = 0; i < arr.Count; i++)
    //        {
    //            if (arr[i] > 0)
    //            {
    //                positiveCount++;
    //            }
    //            else if (arr[i] < 0)
    //            {
    //                negativeCount++;
    //            }
    //            else
    //            {
    //                zeroCount++;
    //            }

    //        }

    //        decimal positiveRatio = positiveCount/ arr.Count;
    //        decimal negativeRatio = negativeCount / arr.Count;
    //        decimal zeroRatio = zeroCount / arr.Count;

    //        Console.WriteLine(string.Format("{0:N6}", positiveRatio));
    //        Console.WriteLine(string.Format("{0:N6}", negativeRatio));
    //        Console.WriteLine(string.Format("{0:N6}", zeroRatio));
    //    }
    //}
    #endregion


    #region MiniMaxSum

    //class Result
    //{
    //    public static void MiniMaxSum(List<int> arr)
    //    {
    //        long minimumtotal = 0;
    //        long maximumtotal = 0;

    //        arr.Sort();

    //        arr = arr.Where(x => x > 0).ToList();
    //        for (int i = 0; i < arr.Count - 1; i++)
    //        {
    //            minimumtotal += arr[i];
    //        }

    //        for (int i = 1; i < arr.Count; i++)
    //        {
    //            maximumtotal += arr[i];
    //        }

    //        Console.WriteLine(minimumtotal + " " + maximumtotal);
    //    }
    //}
    #endregion


    #region TimeConversion
    //class Result
    //{
    //    public static string TimeConversion(string s)
    //    {
    //        var dateTime = DateTime.Parse(s);


    //        var format24hr = dateTime.ToString("HH:mm:ss");

    //        return format24hr;

    //    }
    //}
    #endregion


    #region FindMedian
    //class Result
    //{
    //    public static void findMedian(List<int> arr)
    //    {
    //        int midArrElmnt = 0;
    //        arr.Sort();
    //        if(arr.Count % 2 == 1)
    //        {
    //            midArrElmnt = arr[arr.Count - 1]/2;
    //            Console.WriteLine(midArrElmnt);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Array is not with an odd number of element");
    //        }           

    //    }
    //}

    #endregion


    #region LonelyInteger
    //class Result
    //{
    //    public static int LonelyInteger(List<int> arr)
    //    {
    //        List<int> secondArr = new List<int>();
    //        for (int i = 0; i < arr.Count; i++)
    //        {
    //            if (secondArr.Contains(arr[i]))
    //            {
    //                secondArr.Remove(arr[i]);
    //            }
    //            else
    //            {
    //                secondArr.Add(arr[i]);
    //            }
    //        }
    //        return secondArr[0];
    //    }
    //}
    #endregion


    #region IsPermitation
    //class Result
    //{
    //    public static bool IsPermitation(string s, string t)
    //    {
    //        if(s.Length != t.Length)
    //            return false;

    //        int[] letters = new int[128];

    //        char[] s_arr = s.ToCharArray();
    //        foreach (char c in s_arr)
    //        {
    //            letters[c]++;
    //        }

    //        for (int i = 0; i < t.Length; i++)
    //        {
    //            int c = t[i];
    //            letters[c]--;
    //            if (letters[c] < 0)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //}
    #endregion


    #region FindUpperCaseWord
    //class Result
    //{
    //    public static void FindUpperCaseLetter(string sentence)
    //    {
    //        var upperWord = sentence.Split(' ').Where(x => string.Equals(x, x.ToUpper()));

    //        foreach (var item in upperWord)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    #endregion


    #region CountWordInSentence
    //class Result
    //{
    //    public static int CountWords(string sentence)
    //    {
    //        int wordCount = 0;
    //        string[] result = sentence.Split(new char[] { ',', '.', ' ', '?', '!' });

    //        for (int i = 0; i < result.Length; i++)
    //        {
    //            wordCount++;
    //        }
    //        return wordCount;
    //    }
    //}
    #endregion


    #region FactorialNumbers
    //class Result
    //{
    //    public static int Factorial(int num)
    //    {
    //        if (num == 0 || num == 1)
    //            return 1;
    //        return num * Factorial(num - 1);
    //    }
    //}
    #endregion


    #region Unique string
    //class Result
    //{
    //    public static bool IsUniqueChars(string str)
    //    {
    //        if (str.Length > 128)
    //            return false;

    //        bool[] chars_set = new bool[128];

    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            int val = str[i];
    //            if (chars_set[val])
    //                return false;

    //            chars_set[val] = true;
    //        }
    //        return true;
    //    }
    //}
    #endregion


    #region Fibonacci Numbers
    //class Result
    //{
    //    public static int Fib(int num)
    //    {
    //        if (num == 0 || num == 1)
    //            return 1;

    //        return Fib(num - 2) + Fib(num - 1);
    //    }
    //}
    #endregion


    #region Diagonal Difference
    //class Result
    //{
    //    public static int DiagonalDifference(List<List<int>> arr)
    //    {
    //        int leftToRight = 0;
    //        int rightToLeft = 0;

    //        for (int i = 0; i < arr.Count; i++)
    //        {
    //            for (int j = 0; j < arr.Count; j++)
    //            {
    //                if(i == j)
    //                {
    //                    leftToRight += arr[i][j];
    //                }     
    //            }
    //        }

    //        for (int i = 0; i < arr.Count; i++)
    //        {
    //            arr[i].Reverse();
    //            for (int j = 0; j < arr.Count; j++)
    //            {
    //                if(i == j)
    //                {
    //                    rightToLeft += arr[i][j];
    //                }
    //            }
    //        }
    //        return Math.Abs(leftToRight - rightToLeft);
    //    }
    //}
    #endregion


    #region Counting sorting
    //class Result
    //{
    //    public static List<int> CountingSort(List<int> arr)
    //    {
    //        arr.Sort();
    //        var secondArrSize = arr.Max(x => x) + 1;

    //        List<int> secondArr = new List<int>(secondArrSize);



    //    }
    //}
    #endregion


    #region Stair Case
    //class Result
    //{
    //    public static void StairCase(int n)
    //    {
    //        string diyez = "";
    //        string space = "";

    //        List<string> strArr = new List<string>();


    //        for (int i = 0; i < n; i++)
    //        {

    //            strArr.Add(space);
    //            space += " ";
    //        }


    //        for (int i = n; i > 0; i--)
    //        {
    //            diyez += "#";
    //            strArr[i-1] += diyez;


    //        }

    //        strArr.Reverse();
    //        foreach (var item in strArr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    #endregion


    #region Birthday Cake Candle
    //class Result
    //{
    //    public static int BirthdayCakeCandle(List<int> candles)
    //    {
    //        int counter = 1;

    //        candles.Sort();
    //        candles.Reverse();


    //        for (int i = 1; i < candles.Count; i++)
    //        {
    //            if (candles[0] == candles[i])
    //            {
    //                counter++;
    //            }
    //        }
    //        return counter;
    //    }
    //}
    #endregion


    #region Grading Students
    //class Result
    //{
    //    public static List<int> GradingStudents(List<int> grades)
    //    {
    //        List<int> secondList = new List<int>();
    //        for (int i = 0; i < grades.Count; i++)
    //        {
    //            if (grades[i] >= 38)
    //            {
    //                if (grades[i] % 5 < 3)
    //                {
    //                    grades[i] = grades[i];
    //                }
    //                else
    //                {
    //                    grades[i] = grades[i] + (5-(grades[i] % 5));
    //                }
    //            }
    //            else
    //            {
    //                grades[i] = grades[i];
    //            }

    //            secondList.Add(grades[i]);
    //        }


    //        foreach (var item in secondList)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        return secondList;
    //    }
    //}

    #endregion


    #region Number Line Jumps Kangaroo
    //class Result
    //{
    //    public static string Kangaroo(int x1,int v1,int x2,int v2)
    //    {
    //        while (true)
    //        {
    //            if (x1 == x2)
    //            {
    //                return "YES";
    //            }
    //            if ((x1 > x2 && v1 > v2) || (x1 < x2 && v1 < v2)  || (v2 == v1 && x1 != x2))
    //            {
    //                return "NO";
    //            }
    //            x1 += v1;
    //            x2 += v2;
    //        }

    //        return "NO";

    //    }
    //}
    #endregion


    #region Apple and Orange
    //class Result
    //{
    //    public static void CountApplesAndOranges(int s,int t,int a,int b,List<int> apples,List<int> oranges)
    //    {
    //        List<int> secondApples = new List<int>();
    //        List<int> secondOranges = new List<int>();

    //        int applesCount = 0;
    //        int orangesCount = 0;

    //        for (int i = 0; i < apples.Count; i++)
    //        {
    //            secondApples.Add(a + apples[i]);
    //        }

    //        for (int i = 0; i < oranges.Count; i++)
    //        {
    //            secondOranges.Add(b + oranges[i]);
    //        }

    //        for (int i = 0; i < secondApples.Count; i++)
    //        {
    //            if (secondApples[i] >= s && secondApples[i] <= t)
    //            {
    //                applesCount++;
    //            }
    //        }

    //        for (int i = 0; i < secondOranges.Count; i++)
    //        {
    //            if (secondOranges[i] >= s && secondOranges[i] <= t)
    //            {
    //                orangesCount++;
    //            }
    //        }

    //        Console.WriteLine(applesCount);
    //        Console.WriteLine(orangesCount);
    //    }
    //}
    #endregion


    #region Breaking the Records
    //class Result
    //{
    //    public static List<int> BreakingTheRecords(List<int> scores)
    //    {
    //        int maximumRecord = scores[0];
    //        int minimumRecord = scores[0];

    //        int maximumCount = 0;
    //        int minimumCount = 0;

    //        List<int> records = new List<int>();

    //        if(scores.Count == 1)
    //        {
    //            records.Add(minimumCount);
    //            records.Add(maximumCount);
    //        }

    //        for (int i = 1; i < scores.Count; i++)
    //        {
    //            if (scores[i] > maximumRecord)
    //            {
    //                maximumRecord = scores[i];
    //                maximumCount++;
    //            }
    //            else if (scores[i] < minimumRecord)
    //            {
    //                minimumRecord = scores[i];
    //                minimumCount++;
    //            }
    //            else
    //            {
    //                minimumRecord = minimumRecord;
    //                maximumRecord = maximumRecord;
    //            }
    //            records = new List<int> { maximumCount, minimumCount };
    //        }

    //        return records;
    //    }
    //}
    #endregion


    #region Subarray Division
    //class Result
    //{
    //    public static int Birthday(List<int> s, int d, int m)
    //    {

    //        int segment = 1;
    //        int ways = 0;
    //        int totalElement = s[0];
    //        if (d < 1 && d > 31)
    //        {
    //            Console.WriteLine("Please enter valid birth day");
    //        }

    //        if (m < 1 && m > 12)
    //        {
    //            Console.WriteLine("Please enter valid birth month");
    //        }

    //        if (s.Count == 1)
    //        {
    //            if (s[0] == d)
    //            {
    //                if (segment == m)
    //                {
    //                    return segment;
    //                }
    //            }
    //        }

    //        for (int i = 0; i < s.Count; i++)
    //        {
    //            totalElement = s[i];
    //            for (int j = i+1; j < s.Count; j++)
    //            {
    //                totalElement += s[j];
    //                segment++;
    //                if(totalElement == d && segment == m)
    //                {
    //                    ways++;
    //                }
    //            }

    //            segment = 1;
    //        }

    //        return ways;
    //    }
    //}
    #endregion


    #region Divisible Sum Pairs
    //class Result
    //{
    //    public static int DivisibleSumPairs(int n,int k,List<int> arr)
    //    {
    //        int counter = 0;
    //        arr.Sort();
    //        for (int i = 0; i < arr.Count; i++)
    //        {
    //            for (int j = i + 1; j < arr.Count; j++)
    //            {
    //                if ((arr[i] + arr[j]) % k == 0)
    //                {
    //                    counter++;
    //                }
    //            }
    //        }
    //        return counter;
    //    }
    //}
    #endregion


    #region Migratory Birds
    //class Result
    //{
    //    public static int MigratoryBirds(List<int> arr)
    //    {
    //        int countBird = 1;
    //        Dictionary<int, int> sameId = new Dictionary<int, int>();

    //        for (int i = 0; i < arr.Count; i++)
    //        {
    //            if (!sameId.ContainsKey(arr[i]))
    //            {
    //                sameId.Add(arr[i], countBird);
    //            }
    //            else
    //            {
    //                sameId[arr[i]] += countBird;
    //                countBird++;
    //            }
    //            countBird = 1;
    //        }

    //         var dictionary = sameId.OrderByDescending(x => x.Value).Select(x => x.Key).First();

    //        return dictionary;

    //    }
    //}

    #endregion


    #region Day Of The Programmer
    //class Result
    //{
    //    public static string DayOfProgrammer(int year)
    //    {
    //        if(year < 1918 && year > 1699)
    //        {
    //            if(year % 4 == 0)
    //            {
    //                return "12.09." + year.ToString();
    //            }
    //        }
    //        else if(year == 1918)
    //        {
    //            return "26.09." + year.ToString();
    //        }

    //        if(year % 4 == 0 && year % 100 !=0)
    //        {
    //            return "12.09." + year.ToString();
                
    //        }
    //        else if (year % 400 == 0)
    //        {
    //            return "12.09." + year.ToString();
    //        }

    //        return "13.09." + year.ToString();
    //    }
    //}

    #endregion

    // not solved
    #region Between two sets
    //class Result
    //{
    //    public static int getTotalX(List<int> a,List<int> b)
    //    {
    //        a.Sort();
    //        b.Sort();

    //        int total = 0;
    //        int biggestCommonDivider = 0;
    //        int smallestCommonDivide = 0;


    //        if(total > a.Count || total > b.Count)
    //        {
    //            return 0;
    //        }


    //    }
    //}
    #endregion

}
