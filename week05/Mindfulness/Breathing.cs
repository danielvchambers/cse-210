public class Breathing : Activities
{
    public Breathing() : base()
    {
        base._activityName = "Breathing Exercise";
        base._activityInstr = "Clear Your mind and take deep breathes according to the Timeing in the activity.";
    }

    public void Run()
    {
        private DateTime _startTime = DateTime.Now;
        private DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        while (DateTime.Now <= _endTime)
        {
            Console.Writeline("Breathe in");
            Activities.Waitinganim(3);
            Console.Writeline("Breathe out");
        }
    }
}
