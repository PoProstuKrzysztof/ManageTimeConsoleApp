namespace ManageTimeLibrary;

public class ActivityCategory 
{
    public static int a_Counter = 0;
    public int Id { get; set; } = 0;

    public string CategoryTitle{ get; set; }

    public TimeSpan TimeSpend { get; set; } 

    public ActivityCategory(string categoryName)
    {
        
        CategoryTitle = categoryName;
        this.Id = Interlocked.Increment(ref a_Counter);
    }

    public string ActivityTime()
    {
        var ts = TimeSpend.ToString( @"hh\:mm\:ss" );
        return ts;
    }
    public void ShowTooltip() => Console.WriteLine($"Category title: {CategoryTitle}, Time spend on category: {ActivityTime()}\nId: {Id}\n-------------------------------------------------------------");


}
