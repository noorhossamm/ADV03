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




        }
    }
}
