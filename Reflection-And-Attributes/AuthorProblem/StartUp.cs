namespace AuthorProblem
{
    [Author("Me")]
    [Author("You")]

    public class StartUp
    {
        [Author("Me again")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodByAuthor();
        }
    }

}


