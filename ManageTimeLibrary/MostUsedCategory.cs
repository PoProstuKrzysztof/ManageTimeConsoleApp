using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageTimeLibrary
{
    public class MostUsedCategory
    {
        public static void ShowMostUsedCategory()
        {
            TimeSpan max = new TimeSpan(0);
            string mostUsedCategoryTitle = "";
            if (ApplicationData.activityCategories != null)
            {
                for (int i = 0; i < ApplicationData.activityCategories.Count; i++)
                {

                    if (ApplicationData.activityCategories[i].TimeSpend > max)
                    {
                        max = ApplicationData.activityCategories[i].TimeSpend;
                        mostUsedCategoryTitle = ApplicationData.activityCategories[i].CategoryTitle;
                    }
                    else
                        continue;

                }

                string timeofMostUsedCategory = String.Format("{0:00}:{1:00}:{2:00}.{1:00}",
                    max.Hours, max.Minutes, max.Seconds,
                    max.Milliseconds / 10);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The most used category is {mostUsedCategoryTitle} with the time of {timeofMostUsedCategory}!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}

