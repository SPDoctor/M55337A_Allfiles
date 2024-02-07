﻿namespace PolymorphismDemo
{
    class Person
    {
        private float height;
        private float weight;
        private string gender;
        private int age;
        private string firstName;
        private string lastName;

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        // public methods
        public virtual void eat()
        {
            Console.WriteLine("slurping");
        }

        public void sleep()
        {
            Console.WriteLine("Snoring");
        }

        public virtual void move()
        {

        }
        

        public void communicate()
        {

        }
    }
}