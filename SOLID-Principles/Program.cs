#region SRP-RUN-EXAMPLE
//TestWithoutSRP();
//TestWithSRP();
//static void TestWithoutSRP()
//{
//    var account =
//        new SOLIDPrinciples.SRP.After.Account("Reem", "reem@example.com", 10000m);
//    account.MakeTransaction(500);
//    account.MakeTransaction(-11000);
//}

//static void TestWithSRP()
//{
//    var account =
//        new SOLIDPrinciples.SRP.Before.Account("Reem", "reem@example.com", 10000m);

//    var accountService = new SOLIDPrinciples.SRP.Before.AccountService();
//    accountService.Deposit(account, 500);
//    accountService.WithDraw(account, 11000);
//}
#endregion

#region OCP_RUN_EXAMPLE
//var quiz = new OCP.After.Quiz(OCP.After.QuestionBank.Generate());
//quiz.Print(); 
#endregion

#region LSP-RUN-EXAMPLE
//var account = new LSP.After.FixedDepositAccount("Issam", 10_000);
//account.Deposit(1000);
//Console.ReadKey(); 
#endregion

#region ISP-RUN-EXAMPLE
//var employees = ISP.After.Repository.LoadEmployees();

//foreach (var e in employees)
//{
//    Console.WriteLine(e.PrintSalarySlip());
//    Console.WriteLine();
//}
#endregion
#region DIP-RUN-EXAMPLE
using DIP.After;

var customers = DIP.After.Repository.Customers;

foreach (var customer in customers)
{
    var notificationService = new DIP.After.NotificationService(new List<IMessageService>
    { new DIP.After.EmailService(){EmailAddress=customer.EmailAddress}, new DIP.After.SMSService(){ MobileNo=customer.MobileNo } });
    notificationService.Notify();
}
#endregion
Console.ReadKey();