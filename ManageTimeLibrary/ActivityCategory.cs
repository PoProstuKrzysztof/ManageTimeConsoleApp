namespace ManageTimeLibrary;

public class ActivityCategory 
{
    private static int a_Counter = 0;
    public int Id { get; set; } = 0;
    
    public string CategoryName { get; set; }

    public TimeSpan TimeSpent { get; set; }


    public ActivityCategory(string categoryName)
    {
        CategoryName = categoryName;
        this.Id = Interlocked.Increment(ref a_Counter);
    }

    public void ShowTooltip() => Console.WriteLine($"Nazwa kategorii: {CategoryName}, Czas spędzony na kategorii: {TimeSpent}\nId: {Id}\n-------------------------------------------------------------");


}
