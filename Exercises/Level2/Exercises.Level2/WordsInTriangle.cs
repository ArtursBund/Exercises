using System;

namespace Exercises.Level2
{
    public class WordsInTriangle
    {
        /// <summary>
        /// Given array of words draw them inside a smallest possible triangle, compleeting rules. 
        /// !. Every word has to be drawn in a new line.
        /// 2. No word can touch wall of the triangle, meaning there has to a " " between a wall and word.
        /// 
        /// For example word Home:
        /// 
        ///      *
        ///     * *
        ///    *   *
        ///   *     *
        ///  * home  *
        /// ***********
        /// 
        /// a beautiful home:
        /// 
        ///         *
        ///        * *
        ///       *   *
        ///      *     *
        ///     *       *
        ///    * a       *
        ///   * beautiful *
        ///  * home        *
        /// *****************
        /// 
        /// </summary>
        /// <param name="words">Words to put in triangle</param>
        /// <returns></returns>
        public string[] GetWordInTriangle(string[] words)
        {
            int Len = words[0].Length;
            int LenP = 0;
            int P=0;
            int Len_w = words.Length;

            // Nosaka kurš ir garākais vārs, kāda ir tā pozīcija un cik lielam jābūt trīstūrim
            for (int i=0;i< Len_w - 1; i++)
            {
                LenP = Len;
                Len = Math.Max(Len, words[i + 1].Length);
                if(LenP!=Len) { P = i+1; }
            }
            int Dif = words.Length - P;
            int t_size = (Len + 5 + 2 * Dif)/2;
            string[] triangle = new string[t_size];

            // Izveido trīstūra daļu bez vārdiem
            triangle[0] = " *";
            for(int i=1; i<t_size-Len_w;i++)
            {
                triangle[0] = " " + triangle[0];
                triangle[i] = "*";
                if (words[i - t_size + Len_w + 1].Length % 2 == 0) { triangle[i] = triangle[i] + " "; }
                for (int j=0; j< t_size-i-1; j++)
                {
                    triangle[i] = " " + triangle[i];
                }
                for (int j = 0; j < 2*i-1; j++)
                {
                    triangle[i] = triangle[i] + " ";
                }
                triangle[i] = triangle[i] + "*";
            }
            
            // Izveido trīstūra daļu ar vārdiem
            string transfer = null;
            for (int i = t_size - Len_w - 1; i < t_size-1; i++)
            {
                triangle[i] = "*";
                for(int j=t_size-i-1; j>0;j--)
                {
                    triangle[i] = " " + triangle[i];
                }
                transfer = triangle[i];
                triangle[i] = triangle[i] + " " + words[i - t_size + Len_w + 1];
                if(words[i - t_size + Len_w + 1].Length % 2==0) { triangle[i] = triangle[i] + " "; }
                triangle[i] = triangle[i] + transfer;
            }

            //Izveido apakšu
            triangle[t_size-1] = "*";
            for(int i=0; i<2*t_size-2;i++ )
            {
                triangle[t_size-1] = triangle[t_size-1] + "*";
            }
                return triangle;
        }
    }
}
