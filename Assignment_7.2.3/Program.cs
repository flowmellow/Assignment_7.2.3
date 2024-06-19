/*
3. Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
Example 1:
Input: s = "anagram", t = "nagaram"
Output: true
Example 2:
Input: s = "rat", t = "car"
Output: false
*/

using System.Reflection.Metadata.Ecma335;

namespace Assignment_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "anagram";
            //string t = "nagaram";

            string s = "rat";
            string t = "car";

            SolveAnagram solveAnagram = new SolveAnagram();

            bool result = solveAnagram.IsAnagram(s, t);

            Console.WriteLine(result);

        }

        public class SolveAnagram
        {
            public bool IsAnagram(string s, string t) // set up a bool method 
            {
                if (s.Length != t.Length)  //Checks the lengths of both string arguments to ensure they match. if not the result is false and the strings are not anagrams
                {
                    return false;
                }
            
                
                Dictionary<char, int> countS = new Dictionary<char, int>(); // using 2 dictionaries to later compare the key: characters and character counts to look for a match.
                Dictionary<char, int> countT = new Dictionary<char, int>();

                foreach (char c in s) // iterating over each character in the string to add it to the dictionary or increase the dictionary value 
                {
                    
                    if (countS.ContainsKey(c)) // if the dictionary already contains the key then the value will be incremented
                    {
                        countS[c]++;
                    }
                    else // if the dictionary does not contain the key or value by assigning the charater a value the dictionary will link the key to the value.
                         // There is no need to execute a count.Add(). before assigning te value.
                    {
                        countS[c] = 1;
                    }
                }

                foreach (char c in t) // same as above
                {

                    if (countT.ContainsKey(c))
                    {
                        countT[c]++;
                    }
                    else
                    {
                        countT[c] = 1;
                    }
                }

                foreach (var keyPair in countS) // used var because cant convert <char,int> to char variable. 
                {
                    if (!countT.ContainsKey(keyPair.Key) || countT[keyPair.Key] != keyPair.Value) // as countS is eterated through if countT does not have a matching key(character) or matching value for the key
                                                                                                  // it returns false.
                    {
                        return false;
                    }
                }

                return true;           
            }
        }

    }
}
