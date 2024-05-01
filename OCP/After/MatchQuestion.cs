namespace OCP.After
{
    public class MatchQuestion : Question
    {
        public Dictionary<string, string> Rows = new Dictionary<string, string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var (key, value) in Rows)
            {
                Console.WriteLine($"{key}            {value}");
            }

        }

    }
}
