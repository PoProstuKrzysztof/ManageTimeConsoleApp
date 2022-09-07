namespace ManageTimeLibrary
{
    public class MeasureTimeOperations
    {
        public static void TimerOperations()
        {

            ShowCategory.ShowCategories();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nChoose category to measure time. \n");
            Console.ForegroundColor = ConsoleColor.White;
            int categoryChoice = int.Parse(Console.ReadLine());


            foreach (ActivityCategory category in ApplicationData.activityCategories)
            {
                if (category.Id == categoryChoice)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nStart the timer using 1\n");


                    int startTimer = int.Parse(Console.ReadLine());

                    if (startTimer == 1)
                    {
                        MeasureTime.timer.Reset();
                        Console.WriteLine("\nStop the timer using 2\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        MeasureTime.StartTimer();
                        startTimer = int.Parse(Console.ReadLine());

                        if (startTimer == 2)
                        {
                            MeasureTime.StopTimer();

                            if (category.TimeSpend.TotalMilliseconds == 0)
                            {
                                TimeSpan timeElapsed = MeasureTime.timer.Elapsed;
                                category.TimeSpend = timeElapsed;
                            }
                            else
                            {
                                TimeSpan timeElapsed = MeasureTime.timer.Elapsed;
                                category.TimeSpend += timeElapsed;
                            }

                        }
                        else Console.WriteLine("\nTo stop the timer, you have to press  \"2\" ");
                        // dodać pętle

                    }
                    else   
                        Console.WriteLine("\nYou have to press \"1\" to start the timer.");

                    
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTime elapsed " + MeasureTime.TimeElapsed());
                    Console.WriteLine("\nTime elapsed in category: " + category.TimeSpend);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

        }
    }
}




