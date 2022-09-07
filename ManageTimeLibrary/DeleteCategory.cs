namespace ManageTimeLibrary;

public class DeleteCategory
{
    public static void DeleteCategoryFromList()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enter id of category to delete.");
        Console.ForegroundColor = ConsoleColor.White;

        int categoryToDelete = int.Parse(Console.ReadLine());

        bool categoryFound = false;

        // check for category
        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            if (category.Id == categoryToDelete)
            {
                // delete category
                for (int i = category.Id; i < ApplicationData.activityCategories.Count; i++)
                {
                    ApplicationData.activityCategories[i].Id--;
                    ActivityCategory.a_Counter--;
                }

                ApplicationData.activityCategories.Remove(category);
                categoryFound= true;


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nCategory {category.CategoryTitle} was successfully deleted!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

        }
        
       
        if (!categoryFound)
        {
            Console.ForegroundColor = ConsoleColor.Red;               
            Console.WriteLine("\nCategory not found.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
