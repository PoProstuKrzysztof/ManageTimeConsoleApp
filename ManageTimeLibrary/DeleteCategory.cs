namespace ManageTimeLibrary;

public class DeleteCategory
{
    public static void DeleteCategoryFromList()
    {
        Console.WriteLine("Wpisz numer kategorii");
        
        int categoryToDelete = int.Parse(Console.ReadLine());

        bool categoryFound = false;


        foreach (ActivityCategory category in ApplicationData.activityCategories)
        {
            if (category.Id == categoryToDelete)
            {
                for (int i = category.Id; i < ApplicationData.activityCategories.Count; i++)
                {
                    ApplicationData.activityCategories[i].Id--;
                }

                ApplicationData.activityCategories.Remove(category);
                categoryFound= true;


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nKategoria {category.CategoryName} została usunięta!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

        }
        
        if (!categoryFound)
        {
            Console.ForegroundColor = ConsoleColor.Red;               
            Console.WriteLine("\nNie znaleziono kategorii.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
