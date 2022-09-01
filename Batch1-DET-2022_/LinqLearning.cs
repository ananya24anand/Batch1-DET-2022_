using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022_
{
    internal class LinqLearning
    {
        
        private static void SampleIntList()
        {
            //The three parts of LINQ: deffered execution
            //1. Data Source
            List<int> list = new List<int>();
            list.Add(6);
            list.Add(2);
            list.Add(9);
            list.Add(4);
            list.Add(6);
            list.Add(2);

            List<int> list2 = new List<int>() { 6, 2, 4 };

            List<int> list3 = new List<int>() { 1 };


            //2. Query creation sql type
            //var numQuery = from num in list
            //select num;

            //early execution
            //var numQuery = (from num in list
            //select num).ToList();

            //var numQuery = from num in list
            //where num > 2
            //select num;

            //lambda exp
            //var numQuery = list.Select(x => x);

            //var numQuery = list.Where(x => x>2);

            //AGGREGATE
            //var numQuery = list.Aggregate((a, b) => a * b);

            //var numQuery = list.Aggregate(10, (a, b) => a + b);

            //AVERAGE
            //var numQuery = list.Average();

            //ORDERBY
            //var numQuery = list.OrderBy(x => x);

            //ORDERBY DESCENDING
            //var numQuery = list.OrderByDescending(x => x);

            //MAX
            //var numQuery = list.Max();
            //Console.Write(numQuery);

            //MIN
            //var numQuery = list.Min();
            //Console.Write(numQuery);

            //SUM
            //var numQuery = list.Sum();
            //Console.Write(numQuery);

            //ELEMENTAT
            //var numQuery = list.ElementAt(3);
            //Console.Write(numQuery);

            //ELEMENTATORDEFAULT
            //var numQuery = list.ElementAtOrDefault(3);
            //var numQuery = list.ElementAtOrDefault(10);
            //Console.Write(numQuery);

            //FIRST
            //var numQuery = list.First();
            //Console.Write(numQuery);

            //FIRST CONDITIONAL
            //var numQuery = list.First(c => c>2);
            //Console.Write(numQuery);

            //var numQuery = list.FirstOrDefault();
            //var numQuery = list3.FirstOrDefault();
            //Console.Write(numQuery);

            //LAST
            //var numQuery = list.Last();
            //Console.Write(numQuery);

            //LASTORDEFAULT
            //var numQuery = list.LastOrDefault();
            //var numQuery = list3.LastOrDefault();
            //Console.Write(numQuery);

            //LASTORDEFAULT CONDITIONAL
            //var numQuery = list.LastOrDefault(c => c==10);
            //var numQuery = list.LastOrDefault(c => c == 6);
            //Console.Write(numQuery);

            //SINGLE
            //var numQuery = list3.Single();
            //Console.Write(numQuery);

            //SINGLEORDEFAULT
            //var numQuery = list3.Single();
            //var numQuery = list.Single();
            //Console.Write(numQuery);

            //ALL
            //var numQuery = list.All(c => c > 0);
            //Console.Write(numQuery);

            //ANY
            //var numQuery = list.Any(c => c > 5);
            //Console.Write(numQuery);

            //CONTAINS
            //var numQuery = list.Contains(4);
            //Console.Write(numQuery);

            //DISTINCT
            //var numQuery = list.Distinct();

            //EXCEPT
            //var numQuery = list.Except(list2);

            //INTERSECT
            //var numQuery = list.Intersect(list2);

            //UNION
            //var numQuery = list.Union(list2);

            /*foreach (int num in numQuery)
            {
                Console.WriteLine(num);
            }*/




            //string[] names = { "Monica", "Rachel", "Pheobe", "Joey", "Chandler", "Ross" };

            //var result = names.OrderBy(c => c.Length).ThenBy(c => c);

            //REVERSE
            // var result = names.Reverse();

            //var result = names.OrderByDescending(d => d.Length).ThenByDescending(d => d);

            //SKIP
            //var result = names.Skip(3);

            //SKIPWHILE
            //var result = names.SkipWhile(w => w.Length == 6);

            //TAKE
            //var result = names.Take(5);

            //TAKEWHILE
            //var result = names.TakeWhile(w => w.Length > 4);

            //COUNT
            //var result = names.Count();
            //Console.WriteLine(result);


            //3. Query execution

            /*foreach (string name in result)
            {
                 Console.WriteLine(name);
            }*/

            //ASSIGNMENT 1
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
            /*var result = from name in names
                         where name.Contains("o")
                         select name;
            foreach (string item in result)
                Console.WriteLine(item);

            //ASSIGNMENT 2
            var result = names.OrderBy(c => c.Length).Last();
            Console.WriteLine(result);

            //ASSIGNMENT 3
            string[] words1 = { "believe", "relief", "receipt", "field" };
            var words = from word in words1
                        select word;

            foreach (var word in words)
                Console.WriteLine($"{word} -- {word.Length}");*/

            //ASSIGNMENT 4
            /*string[] words = { "blueberry", "blackberry", "abacus" };
            var result = words.OrderBy(x => x);
            foreach (var item in result)
                Console.WriteLine(item.Reverse().ToArray());

            //ASSIGNMENT 5
            int[] numbers = { 1, 3, 2, 0 };
            string[] lang = { "C#", "SQL", "LINQ", "Java" };*/

            //GROUPBY
            List<string> list4 = new List<string>() { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            /*var wordGroups = list4.GroupBy(x => x[0]).Select
                (y => new { FirstLetter = y.Key, Words = y });
            foreach(var group in wordGroups)
            {
                Console.WriteLine("Words that starts with the" + " letter '{0}': ", group.FirstLetter);
                
                foreach (var word in group.Words)
                {
                    Console.WriteLine(word);
                   
                }
                Console.WriteLine();
            }*/

            var wordGroups = list4.GroupBy(x => x.Length).Select
                (y => new { lengthOfWord = y.Key, Words = y });
            foreach (var group in wordGroups)
            {
                Console.WriteLine("Words with" + "  {0} characters: ", group.lengthOfWord);

                foreach (var word in group.Words)
                {
                    Console.WriteLine(word);

                }
                Console.WriteLine();
            }


        }


        public static void Main()
        {
            SampleIntList();
        }

    }
}
