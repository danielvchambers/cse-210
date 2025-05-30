public class Activities
{
    private string _startMessage = "Welcome to this Mindful activity!";
    private string _endMessage = "Well done and have a good rest of your day!!";
    protected string _activityName;
    protected string _activityInstr;
    private int _increment;
    private Random ran = new Random();
    protected int _activityRunTime;

    public Activities(int time)
    {
        _activityRunTime = time;
    }

    protected void WaitingAnim(int _duration)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        private DateTime _startTime = DateTime.Now;
        private DateTime _endTime = _startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            int i = 0;
            string s = animation[i];
            console.Write(s);
            thread.Sleep(500);
            console.Write("\b \b");
            i++;
            if (i >= animation.Count())
            {
                i = 0;
            }
        }
    }

    protected void DisplayRandIndex(List<string> list)
    {
        int randInt = ran.Next();
        Console.WriteLine(list[randInt]);
    }

    public void DisplayStartMess()
    {
        Console.WriteLine(_startMessage)
    }

    public void DisplayEndMess()
    {
        Console.WriteLine(_endMessage)
    }
}
