namespace ManageTimeLibrary;

public class AddCategory
{
    public static void AddCategoryToList()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enter title of the category.");
        Console.ForegroundColor = ConsoleColor.White;

        var categoryTitle = Console.ReadLine();


        // check if category already exist
        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            if (category.CategoryTitle == categoryTitle)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCategory already exits!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }

        // adds category
        ApplicationData.activityCategories.Add(new ActivityCategory($"{categoryTitle}"));
              
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nCategory {categoryTitle} was created!\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}
