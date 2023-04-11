using System;

namespace UMLToCode
{
    internal class Program
    {
        public abstract class Person
        {
            public int ID;
            public int Name;
            protected String Phone;
            public String Email;
            public Adress adress;
        }

        public struct Adress
        {
            public String Street;
            public String City;
            public String State;
            public int Postal_Code;
            public String Country;

            public bool Validate()
            {
                return true;
            }
        }

        public class Customer : Person
        {
            public DateTime Registration;
            private int CreditScore;
            public Account Account;
        }

        public class Employee : Person
        {
            public Enum Departament;
            private float Salary;
        }

        public struct Transaction
        {
            public String From;
            public String To;
            public float Amount;
            public DateTime Request;
        }
        public class Account
        {
            public String IBAN;
            protected float Amount;
            public Transaction transaction;

            public bool Transaction(String input)
            {
                return true;
            }
        }

        public class Investing : Account
        {
            public float Interest;

            public void ApplyInterest()
            {

            }
        }

        public class Savings : Account
        {
            private float ProtectedAmount;

            public void LiberateSavings()
            {

            }
        }
    }
}