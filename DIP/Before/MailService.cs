namespace DIP.Before
{
    public class MailService
    {
        public string Address { get; set; }


        public void Send()
        {
            Console.WriteLine($"e-mail is sent to {Address}");
        }
    }
}
