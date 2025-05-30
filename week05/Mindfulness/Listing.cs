public class Listing : Activities
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private string _response;

    _prompts.Add("Who are people that you appreciate? ");
    _prompts.Add("What are personal strengths of yours? ");
    _prompts.Add("Who are people that you have helped this week? ");
    _prompts.Add("When have you felt the Holy Ghost this month? ");
    _prompts.Add("Who are some of your personal heroes? ");

    public Listing() : base()
    {
        // ToDo
    }

    public void run()
    {
        Activities.DisplayRandIndex(_prompts);
        Activities.WaitingAnim(5);
        Console.WriteLine("List as many items as you can hitting enter after each one.");
        private DateTime _startTime = DateTime.Now;
        private DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        while (DateTime.Now <= _endTime)
        {
            string _response = Console.ReadLine();
            _response.Add(_response);
        }
        Console.WriteLine(_responses.Count());
    }

}
