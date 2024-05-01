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

var quiz = new OCP.After.Quiz(OCP.After.QuestionBank.Generate());
quiz.Print();



Console.ReadKey();