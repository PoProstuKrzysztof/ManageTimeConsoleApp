namespace ManageTimeLibrary
{
    public class MeasureTimeOperations
    {
        public static void TimerOperations()
        {

            foreach (ActivityCategory category in ApplicationData.activityCategories)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                category.ShowTooltip();
                Console.ForegroundColor = ConsoleColor.White;
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWybierz kategorie dla której odmierzać czas\n");
            Console.ForegroundColor = ConsoleColor.White;
            int categoryChoice = int.Parse(Console.ReadLine());


            foreach (ActivityCategory category in ApplicationData.activityCategories)
            {
                if (category.Id == categoryChoice)
                {
                    Console.WriteLine("\nWłącz timer klikając 1\n");

                    int startTimer = int.Parse(Console.ReadLine());

                    if (startTimer == 1)
                    {
                        MeasureTime.timer.Reset();
                        Console.WriteLine("\nKliknij 2 aby wyłączyć timer\n");
                        MeasureTime.StartTimer();
                        startTimer = int.Parse(Console.ReadLine());

                        if (startTimer == 2)
                        {
                            MeasureTime.StopTimer();

                            if (category.TimeSpent.TotalMilliseconds == 0)
                            {
                                TimeSpan timeElapsed = MeasureTime.timer.Elapsed;
                                category.TimeSpent = timeElapsed;
                            }
                            else
                            {
                                TimeSpan timeElapsed = MeasureTime.timer.Elapsed;
                                category.TimeSpent += timeElapsed;
                            }

                        }
                        else Console.WriteLine("\nŻeby zatrzymać timer musisz wpisać  \"2\" ");
                        // dodać pętle

                    }
                    else
                    {
                        Console.WriteLine("\nMusisz wpisać \"1\" żeby włączyć stoper.");

                    }


                    Console.WriteLine("\nCzas trwania " + MeasureTime.TimeElapsed());
                    Console.WriteLine("\nCzas w kategorii: " + category.TimeSpent);
                }

            }

        }

        //public static void TimeSpendOnCategory()
        //{
        //    foreach (ActivityCategory category in ApplicationData.activityCategories)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        category.ShowTooltip();
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }

        //    Console.WriteLine("Wybierz którą kategorie chcesz sprawdzić.");

        //    var categoryToFind = int.Parse(Console.ReadLine());

        //    bool categoryFound = false;

        //    foreach (ActivityCategory category in ApplicationData.activityCategories)
        //    {
        //        if (category.Id == categoryToFind)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Yellow;
        //            Console.WriteLine("\nCzas spędzony na kategorii: " + category.TimeSpent);
        //            Console.ForegroundColor = ConsoleColor.White;
        //            return;
        //        }

        //    }
        //    if (!categoryFound)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Nie znaleziono kategorii.");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
    }
}




