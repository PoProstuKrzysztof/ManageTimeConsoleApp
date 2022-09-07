namespace ManageTimeLibrary;

public class EditCategory
{
    public static void EditCategoryInList()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEnter number of category on the list to edit\n");
        Console.ForegroundColor = ConsoleColor.White;

        ShowCategory.ShowCategories();

        int categoryToEdit = int.Parse(Console.ReadLine());


        // check whether category exist
        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            if (category.Id == categoryToEdit)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nEdit title of {category.CategoryTitle} category\n");
                Console.ForegroundColor = ConsoleColor.White;

                // editing category 
                string editedTitle = Console.ReadLine();
                if (editedTitle == category.CategoryTitle)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThe title is the same.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                category.CategoryTitle = editedTitle;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nCategory {editedTitle} was renamed\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

        }
            // information if category was not found
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nCategory not found.\n");
            Console.ForegroundColor = ConsoleColor.White;
            return;
    }
}
