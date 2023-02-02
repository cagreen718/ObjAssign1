﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameTesting
{
    public class Employee : IPeople
    {
        public int Identifier { get; }
        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String FullName { get { return FirstName + " " + LastName; } }

        public Employee() : this("?")
        {
        }

        public Employee(String lastName) : this(lastName, "?")
        {
        }

        // Designated Constructor
        public Employee(String lastName, String firstName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        override public String ToString()
        {
            return Identifier + "-" + FullName;
        }
    }
}
