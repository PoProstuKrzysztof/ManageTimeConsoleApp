
using ManageTimeConsoleApp;
using ManageTimeLibrary;

//ApplicationData.activityCategories.AddRange(new List<ActivityCategory>
//{
//    new ActivityCategory("Czytanie"),
//    new ActivityCategory("Bieganie"),
//    new ActivityCategory("Siłownia"),
//    new ActivityCategory("Programowanie"),
//    new ActivityCategory("Granie"),
//    new ActivityCategory("Spacer"),
//    new ActivityCategory("Praca")

//});

int choice = 0;
while (choice != 6)
{
    Console.WriteLine("Menu\n");
    Console.WriteLine("Co chcesz zrobić?");
    Console.WriteLine("1. Dodaj kategorie.");
    Console.WriteLine("2. Pokaż kategorie.");
    Console.WriteLine("3. Usuń kategorie.");
    Console.WriteLine("4. Edytuj kategorie.");
    Console.WriteLine("5. Odmierzaj czas.");
    Console.WriteLine("6. Wyjście.");
    try
    {
        choice = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("\nProsze wpisać cyfre 1-6.\n");
    }
    
    

    switch (choice)
    {



        // Dodaje kategorie
        case 1:
            AddCategory.AddCategoryToList();
            break;



        // Pokazuje kategorie
        case 2:
            ShowCategory.ShowCategories();
            break;


        // Usuwa kategorie   
        case 3:
            DeleteCategory.DeleteCategoryFromList();
            break;



        // Edytuje kategorie
        case 4:
            EditCategory.EditCategoryInList();
            break;



        // Odmierzanie czasu spędzonego na danej kategorii 
        case 5:
            MeasureTimeOperations.TimerOperations();
            break;

    }
}




