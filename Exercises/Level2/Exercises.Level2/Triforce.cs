using System;

namespace Exercises.Level2
{
    public class Triforce
    {
        /// <summary>
        /// !!! COMPLETE TRIANGLE BEFORE ATTEMPTING THIS !!!
        /// 
        /// 
        /// The program:
        ///  You must create a program that echoes a Triforce of a given size N.       
        /// - A triforce is made of 3 identical triangles
        /// - A triangle of size N should be made of N lines
        /// - A triangle's line starts from 1 star, and earns 2 stars each line
        /// 
        /// For example, a Triforce of size 3 will look like:
        ///        
        ///     *
        ///    ***
        ///   *****
        ///  *     *
        /// ***   ***
        ///***** *****
        ///
        /// Another example, a Triforce of size 5 will look like:
        ///
        ///         *
        ///        ***
        ///       *****
        ///      *******
        ///     *********
        ///    *         *
        ///   ***       ***
        ///  *****     *****
        /// *******   *******
        ///********* *********
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>


        public string[] GetTriforce(int n)
        {
            //Izveido references trīstūri

            string star = "*";
            string[] triangle = new string[n];
            for (int i = 0; i < n; i++)
            {
                triangle[i] = star;
                star = star + "**";
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    triangle[n - 1 - i] = " " + triangle[n - 1 - i];
                }
            }

            // Izveido pilno trīstūri
            string[] triangleF = new string[2 * n];
            for (int i = 0; i < n; i++)
            {
                triangleF[i] = triangle[i];
                triangleF[n+i] = triangle[i];
                for (int j = 0; j < n; j++)
                {
                    triangleF[i] = " " + triangleF[i];
                }
                for (int j = 0; j <= n-1-i; j++)
                {
                    triangleF[n+i] = triangleF[n + i] + " ";
                }
                triangleF[n + i] = triangleF[n + i]+ triangle[i];
            }
            return triangleF;
        }
    }
}
