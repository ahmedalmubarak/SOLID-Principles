namespace OCP.After
{
    public class MultiChoiceQuestion : Question
    {
        public List<string> Choices { get; set; } = new List<string>();


        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"  {choice}");
            }
        }
    }
}
