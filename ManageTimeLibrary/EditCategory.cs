namespace ManageTimeLibrary;

public class EditCategory
{
    public static void EditCategoryInList()
    {
        Console.WriteLine("Wpisz numer kategorii do edycji");

        int categoryToEdit = int.Parse(Console.ReadLine());

        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            if (category.Id == categoryToEdit)
            {
                Console.WriteLine($"\nEdytuj nazwe kategorii {category.CategoryName}\n");

                string editedName = category.CategoryName = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nZmieniono nazwe na {editedName}\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNie znaleziono kategorii.\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

        }

    }
}
