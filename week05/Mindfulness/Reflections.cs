public class Reflection : Activities
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    _questions.Add("Why was this experience meaningful to you? ");
    _questions.Add("Have you ever done anything like this before? ");
    _questions.Add("How did you get started? ");
    _questions.Add("How did you feel when it was complete? ");
    _questions.Add("What made this time different than other times when you were not as successful? ");
    _questions.Add("What is your favorite thing about this experience? ");
    _questions.Add("What could you learn from this experience that applies to other situations? ");
    _questions.Add("What did you learn about yourself through this experience? ");
    _questions.Add("How can you keep this experience in mind in the future? ");

    public Reflection() : base()
    {
        // ActivityName
        // Activity Instruction
    }

    public void run()
    {
        private DateTime _startTime = DateTime.Now;
        private DateTime _endTime = _startTime.AddSeconds(_activityRunTime);
        Activities.DisplayRandIndex(_prompts);
        while (DateTime.Now <= _endTime)
        {
            Console.Write("Relfect on ");
            Activities.DisplayRandIndex(_questions);
            Activities.WaitingAnim(5);
        }
    }

    public List<string> GetListProms()
    {
        return _prompts;
    }

    public List<string> GetListQues()
    {
        return _questions;
    }
}
