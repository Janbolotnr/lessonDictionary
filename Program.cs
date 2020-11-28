using System;
using System.Collections.Generic;

namespace DictionaryLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new string[] { "A", "B", "J", "I", "K", "L", "B", "B", "I", "K" };

            foreach (var kvPair in CountGradesLinear(grades))
            {
                Console.WriteLine($"Grade '{kvPair.Key}' : {kvPair.Value} student(s)");
            }
        }
        static Dictionary<string, int> CountGradesLinear(IEnumerable<string> grades)
        {
            var dictionary = new Dictionary<string, int>(); // associative array, map, dictionary

            foreach (var grade in grades)
            {
                dictionary[grade] = dictionary.ContainsKey(grade)
                    ? dictionary[grade] + 1
                    : 1;
                /*  if (dictionary.ContainsKey(grade)) dictionary[grade] += 1;
                  else dictionary[grade] = 1;*/ // можно и так писать код
            }
            return dictionary;

        }
    }
}
