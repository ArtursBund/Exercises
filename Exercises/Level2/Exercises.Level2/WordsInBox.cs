using System;

namespace Exercises.Level2
{
    public class WordsInBox
    {
        /// <summary>
        /// Draw a box made out of stars (*) and put the word inide of them.
        /// So that a word Home makes:
        /// 
        /// ********
        /// * Home *
        /// ********
        /// 
        /// If you need more examples go to the tests project.
        /// </summary>
        /// <param name="word">Word to put in a box</param>
        /// <returns></returns>
        public string[] GetBox(string word)
        {
            string[] box = new string[3];
            int Len = word.Length;
            for (int i = 0; i < Len + 4; i++)
            {
                box[0] = box[0] + "*";
                box[2] = box[2] + "*";
            }
            box[1] = "* " + word + " *";
            return box;
        }
    }
}
