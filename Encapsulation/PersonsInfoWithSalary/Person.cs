﻿namespace PersonsInfoWithSalary
{
    public class Person
    {
        public Person(string fistName, string lastName, int Age, decimal salary)
        {
            this.FirstName = fistName;
            this.LastName = lastName;
            this.Age = Age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if(this.Age < 30)
            {
                percentage /= 2;
            }

            this.Salary = this.Salary + this.Salary * percentage / 100;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }

    }
}
