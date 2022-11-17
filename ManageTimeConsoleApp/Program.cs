
using ManageTimeConsoleApp;
using ManageTimeLibrary;
using System.Runtime.CompilerServices;



ApplicationData.activityCategories.AddRange(new List<ActivityCategory>
{
    //example activities
    new ActivityCategory("Reading"),
    new ActivityCategory("Running"),
    new ActivityCategory("Gym"),
    //new ActivityCategory("Programing"),
    //new ActivityCategory("Gaming"),
    //new ActivityCategory("Walk"),
    //new ActivityCategory("Work")

});

int choice = 0;



while (choice != 7)
{
    
    Console.WriteLine("Menu\n");
    Console.WriteLine("Choose option");
    Console.WriteLine("1. Add category.");
    Console.WriteLine("2. Show categories.");
    Console.WriteLine("3. Delete categories.");
    Console.WriteLine("4. Edit categories.");
    Console.WriteLine("5. Measure time.");
    Console.WriteLine("6. Show most used category.");
    Console.WriteLine("7. Exit.");

    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        // Adding categories
        case 1:
            AddCategory.AddCategoryToList();
            break;


        // Showing categories
        case 2:
            ShowCategory.ShowCategories();
            break;


        // Deleting categories 
        case 3:
            DeleteCategory.DeleteCategoryFromList();
            break;


        // Editing categories
        case 4:
            EditCategory.EditCategoryInList();
            break;


        // Time measure for specific category
        case 5:
            MeasureTimeOperations.TimerOperations();
            break;
        case 6:
            MostUsedCategory.ShowMostUsedCategory();
            break;

    }
}




