using System;

namespace Exercises.Level2
{
    public class Triangle
    {
        /// <summary>
        /// Note: compleete half trangle first
        /// 
        /// The program:
        ///  You must create a triangle. 
        ///  n is the number of lines a triangle will have.
        ///  Triangle body has to be made out of "*",
        ///  so result should for 3 be like:
        ///  * 
        /// ***
        ///*****
        /// 
        /// Example of 5:
        /// 
        ///    *
        ///   ***
        ///  *****
        /// *******
        ///*********
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] GetTRiangle(int n)
        {
            string star = "*";
            string[] triangle = new string[n];
            for (int i = 0; i < n; i++)
            {
                triangle[i] = star;
                star = star + "**";
            }
            for (int i = 0; i < n; i++)
            {
                for(int j=0; j<i;j++)
                {
                    triangle[n - 1 - i] = " " + triangle[n - 1 - i];
                }
            }
            return triangle;
        }
    }
}
