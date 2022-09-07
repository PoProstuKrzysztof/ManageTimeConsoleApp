
namespace ManageTimeLibrary;

public class ShowCategory
{
    public static void ShowCategories()
    {
        if (ApplicationData.activityCategories.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThere is not categories added to the list. You have to add some.\n");
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
