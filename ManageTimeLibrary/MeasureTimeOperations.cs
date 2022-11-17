namespace ManageTimeLibrary
{
    public class MeasureTimeOperations
    {
        public static void TimerOperations()
        {

            ShowCategory.ShowCategories();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( "\nChoose category to measure time. \n" );
            Console.ForegroundColor = ConsoleColor.White;
            int categoryChoice = int.Parse( Console.ReadLine() );

            //searching for category

            foreach (ActivityCategory category in ApplicationData.activityCategories)
            {
                if (category.Id == categoryChoice)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine( "\nStart the timer using 1\n" );

                    //starting timer
                    int startTimer = int.Parse( Console.ReadLine() );
                    MeasureTime.timer.Reset();
                    while (startTimer != 2)
                    {
                        
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine( "\nStop the timer using 2\n" );
                        Console.ForegroundColor = ConsoleColor.White;

                        MeasureTime.StartTimer();
                        startTimer = int.Parse( Console.ReadLine() );
      
                        if(startTimer != 2 )
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine( "\nTo stop the timer, you have to press  \"2\" " );
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                                                

                    }
                    //stopping timer
                    MeasureTime.StopTimer();

                    TimeSpan timeElapsed = MeasureTime.timer.Elapsed;
                    category.TimeSpend += timeElapsed;


                    //summary
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "\nTime elapsed: \n" + MeasureTime.TimeElapsed() );
                    Console.WriteLine( "\nTime elapsed in category: \n" + category.ActivityTime() );
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

            }

            //if category wasn't found
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( "\nCategory doesn't exist.\n" );
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}




