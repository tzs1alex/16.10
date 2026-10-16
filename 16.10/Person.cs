using System;
using System.Collections.Generic;
using System.Text;

namespace _16._10
{
    internal class Person
    {
        protected string firstName;
        protected string lastName;
        protected int libraryCardNumber;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.libraryCardNumber = 0;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public int GetLibraryCardNumber()
        {
            return libraryCardNumber;
        }

        public void SetLibraryCardNumber(int number)
        {
            libraryCardNumber = number;
        }
    }
}
