namespace SOLIDPrinciples.SRP.Before

{
    public class EmailClient
    {
        public void Send(Account account, string transactionMessage, DateTime transactionDateTime)
        {
            // mock process for sending email
            Console.WriteLine(
             $"\n\n\t\t To: {account.Email}" +
             $"\n\t\t Subject: Fake Bank Account Activity" +
             $"\n\n\t\t Dear {account.Name}," +
             $"\n\n\t\t\t A recent activity on your account occures at {transactionDateTime}" +
             "\n\t\t\t\t ===> {0}" +
             $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
             $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
