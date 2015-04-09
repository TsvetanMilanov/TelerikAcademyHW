using System;

/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types
and descriptive names.*/

class BankAccountData
{
    static void Main(string[] args)
    {

        string firstName = "Filip";
        string middleName = "Gonzalez";
        string lastName = "Rodrigues";

        long balance = 775783061125L;

        string bankName = "Private Bank in Aruba";

        string IBAN= "BG80 PBAG 9661 1020 3456 78";

        ulong firstCreditCardNumber = 4012888888881881L;
        ulong secondCreditCardNumber = 4012888562571881L;
        ulong thirdCreditCardNumber = 4012836858881881L;

        Console.WriteLine("Bank account data:\n");
        Console.WriteLine("Holder name: {0} {1} {2}\n", firstName, middleName, lastName);
        Console.WriteLine("Available amount of money: {0}\n", balance);
        Console.WriteLine("Bank name: {0}\n", bankName);
        Console.WriteLine("IBAN: {0}\n", IBAN);
        Console.WriteLine("Credit card numbers associated with this account:\n{0}\n{1}\n{2}\n", firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
    }
}