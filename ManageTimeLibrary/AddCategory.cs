
namespace ManageTimeLibrary;

public class AddCategory
{
    public static void AddCategoryToList()
    {
        Console.WriteLine("Wpisz kategorie");

        var categoryName = Console.ReadLine();


        // check if category exist
        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            if (category.CategoryName == categoryName)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTaka kategoria już istnieje!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }

        ApplicationData.activityCategories.Add(new ActivityCategory($"{categoryName}"));
              
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nUtworzono kategorie {categoryName}!\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}
