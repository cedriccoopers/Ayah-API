using System;

namespace Ayah.Core.Models
{
    public class Employee
    {
        public int EmployeeNumber {get;set;}
        public string Name {get;set;}
        public string Surname {get;set;}
        public string IdPasswordNumber {get;set;}
        public Nationality Nationality {get;set;}
        public Gender Gender {get;set;}
        public Town Town {get;set;}
    }
}
