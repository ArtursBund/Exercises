using System;

namespace Exercises.Level2
{
    public class AsciiTextArt
    {
        /// <summary>
        /// You are givven letters in ASCII art format, now you must draw the art of ASCII.
        /// Using ASCII letters you must convert them and create the word using theese letters.
        /// To gain better understanding go to the tests project inside folder AsciiFiles
        /// to see format of letters and expected output of words.
        /// 
        /// </summary>
        /// <param name="letters">ASCII art letters in range ABCDEFGHIJKLMNOPQRSTUVWXYZ?</param>
        /// <param name="word">Word to output in ascii art</param>
        /// <param name="h">Height of letters</param>
        /// <param name="l">Length of letters</param>
        /// <returns></returns>
        public string[] GetArt(string[] letters, string word , int h, int l)
        {
            int Len = word.Length;
            char[] let = new char[Len];
            char[] let_2 = new char[letters[0].Length];
            int i = 0;
            int t = 0;
            int[] Pos = new int[Len];
            string[] rez = new string[h];
            
            foreach (char c in word)
            {
                Pos[i] = char.ToUpper(c) - 64;
                if(Pos[i]==0) { Pos[i] = 27; }
                i++;
            }

            for (int j=0;j<h;j++)
            {
                rez[j] = null;
                t = 0;
                foreach(char c in letters[j])
                {
                    let_2[t] = c;
                    t++;
                }
                foreach(int n in Pos)
                {
                    for (int k = 1; k <= l; k++)
                    {
                        rez[j] = rez[j]+let_2[l*(n-1)-1+k];
                    }
                }
            }
            return rez;
        }
    }
}
