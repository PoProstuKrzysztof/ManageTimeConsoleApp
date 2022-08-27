
namespace ManageTimeLibrary;

public class ShowCategory
{
    public static void ShowCategories()
    {
        if (ApplicationData.activityCategories.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNie wprowadzono żadnych kategorii. Musisz jakąś dodać.");
            Console.ForegroundColor = ConsoleColor.White;
            AddCategory.AddCategoryToList();
            
            return;
        }

        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            category.ShowTooltip();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
