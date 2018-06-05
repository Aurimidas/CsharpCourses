using System;
using System.Collections.Generic;

namespace CSharpCoursesPractice
{
    public class LessonSixList
    {
        public static void Main ()
        {
            List<int> newList = new List<int>() { 3, 5, 6, 1, 66 };
            newList.Add(7);

            foreach (int item in newList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
