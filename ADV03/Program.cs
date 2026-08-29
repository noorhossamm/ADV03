using System.Runtime.ExceptionServices;

namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Excercise01
            ////1.
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };

            ////2.
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade);
            //    Console.Write(" ");
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Count :{grades.Count}");
            //Console.WriteLine($"First grade:{grades[0]}");
            //Console.WriteLine($"Last grade:{grades[^1]}");

            ////3.
            //grades.Sort();

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade);
            //    Console.Write(" ");
            //}

            //Console.WriteLine();

            ////4.
            //Console.WriteLine($"First grade above 90 :{grades.Find(x => x > 90)}");


            ////5.
            //List<int> failing = grades.FindAll(x => x < 75);
            //foreach (int grade in failing)
            //{
            //    Console.Write(grade);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();

            ////6.
            //grades.RemoveAll(x => x < 75);
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();

            ////7.
            //bool found = grades.Contains(100);
            //Console.WriteLine($"Is number 100 found? {found}");

            ////8.
            //List<string> stringGrades = new List<string>();

            //foreach (int grade in grades)
            //{
            //    stringGrades.Add($"Grade: {grade}");
            //}

            //foreach (string grade in stringGrades)
            //{
            //    Console.Write(grade);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();
            #endregion

            #region Excercise02
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();
            ////1.
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800,"Ali");
            //leaderboard.Add(350,"Mona");

            ////2.
            //foreach(KeyValuePair<int, string> pair in leaderboard)
            //{
            //    Console.WriteLine($"Key:{ pair.Key} , Value: {pair.Value}");
            //}

            //Console.WriteLine("---------------------------");

            ////3.
            //Console.WriteLine($"First pair is : {leaderboard.First()}");
            ////4.
            //Console.WriteLine($"Does the value 500 exist ?{leaderboard.ContainsKey(500)}");

            ////5.
            //string value;
            //bool found = leaderboard.TryGetValue(999, out value);
            //if (found)
            //{
            //    Console.WriteLine($"Player with score 999 is {value}");
            //}
            //else
            //{
            //    Console.WriteLine("No player found with score 999.");
            //}

            ////6.
            //leaderboard.Remove(200);
            //foreach (KeyValuePair<int, string> pair in leaderboard)
            //{
            //    Console.WriteLine($"Key:{pair.Key} , Value: {pair.Value}");
            //}


            #endregion

            #region Exercise03
            ////1.
            //Dictionary<string, string> contacts = new()
            //{
            //    ["Ahmed"] = "01089897829",
            //    ["Sara"] = "01090457868",
            //    ["Ali"] = "01134678900",
            //    ["Mariam"] = "01255768970"

            //};
            ////2.
            //contacts["Samir"] = "01558977789";

            ////3.
            //try
            //{
            //    contacts.Add("Samir", "01558977789");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            ////4.
            //bool canAdd = contacts.TryAdd("Samir", "01558977789");
            //Console.WriteLine($"TryAdd succeeded: {canAdd}");

            ////5.
            //bool contactFound = contacts.ContainsKey("Mahmoud");
            //if (!contactFound)
            //{
            //    Console.WriteLine("No contact found ");
            //}
            ////6.
            //string phone = contacts.GetValueOrDefault("Mahmoud", "Not Found");

            //Console.WriteLine($"Mahmoud: {phone}");
            ////7.
            //foreach (KeyValuePair<string, string> pair in contacts)
            //{
            //    Console.Write($"{pair.Key}   ");

            //}
            //Console.WriteLine();
            //foreach (KeyValuePair<string, string> pair in contacts)
            //{
            //    Console.Write($"{pair.Value}   ");

            //}

            #endregion

            #region Excercise04
            //1.
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            ////2.
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            ////3.
            //Console.WriteLine($"Count : {emails.Count}");
            // 2 is printed because we made the hashset case isensitive
            // so the first 2 elements are considered the same and the last 2 are the same.

            //4.
            //HashSet<int> A = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new HashSet<int>() { 4, 5, 6, 7, 8 };

            //HashSet<int> union = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Union:");
            //union.UnionWith(B) ;
            //foreach (int i in union)
            //    Console.Write($"{i} ");

            //Console.WriteLine();


            //HashSet<int> intersection = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //intersection.IntersectWith(B);

            //Console.WriteLine("Intersection:");
            //foreach (int i in intersection)
            //    Console.Write($"{i} ");


            //Console.WriteLine();

            //HashSet<int> except = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //except.ExceptWith(B);

            //Console.WriteLine("Except:");
            //foreach (int i in except)
            //    Console.Write($"{i} ");

            //Console.WriteLine();
            //HashSet<int> subset = new HashSet<int>() { 1, 2};
            //bool IsSubset = subset.IsSubsetOf(A);
            //Console.WriteLine($"IS [1,2] SUBSET OF A ? {IsSubset}");



            #endregion


        }
    }
}
