﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _482
{
    class Pet:INameAndBirthDate
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public Pet(string name,string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }
    }
}