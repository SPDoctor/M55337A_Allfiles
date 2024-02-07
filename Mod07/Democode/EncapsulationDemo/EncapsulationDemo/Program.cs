namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // this statement is legal because the constructor permits access to the
            // member variables and in the class definition above, you see how the
            // constructor assigns the values passed in, to the member variables


            Person personOne = new Person("Cheryl", 68F, 189F);

            // this statement will generate an error in the compiler and Visual Studio
            // will underline _weight with a red squiggly telling you that _weight is
            // inaccessible due to its protection level.  This is because the variable 
            // is declared as private in the class

            personOne._weight = 155F;

            // these statements are fine because they are calling the public properties to assign 
            // and get the values as oppsoed to accessing the member variable directly

            personOne.Weight = 155F;
            personOne.Height = 69F;
        }
    }
}
