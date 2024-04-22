//an obkject is an instance of a class 
// so for ex dog is a class and the  Bulldog, German sheperd breeds are objects in the class 

// how to create an object of a class

//Now, let us create an object from the Dog class.

Dog buldog = new Dog(); //new key word to delcare new obj as bulldog 
//Now, the bullDog object can access the fields and methods of the Dog class


//Access Class Members using Object

using system;
namespace ClassObject{

    class Dog{
        string breed;

        public void bark() {
            Console.Writeline("hello");
        }

        static void Main(string[] args){
            // create dog obj
            Dog bulldog = new Dog();

            //access breed of class(dog)
            bulldog.breed="Bull Dog";
            //run console
            Console.Writeline(bulldog.breed);
            bulldog.bark;

            //read console
            Console.Readline();
        }
    }
}


using system;
namespace ClassObject{
    class Employee{
        string department;

          static void Main(string[] args) {
            //create employee
           Employee sheran=new Employee();
           //set department for sheran
           sheran.department ="IT";
           Console.WriteLine("Sheeran: " + sheeran.department);

           //second object for emplyee
           Employee taylor= new Employee();
           taylor.department= "ICT";
           Console.WriteLine("taylor: "+ taylor.department);

           // another one for employee

           Employee sarah = new Employee();
           sarah.department = "Copywriting";
           Console.WriteLine("sarah "+ sarah.department);

           Console.ReadLine();
           
          }

    }
}
