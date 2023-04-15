//Data is main focus
//Encapsulation: combining together related properties and behaviour
//Abstract: hidding unneccesary details from user
//polymorphism: 1 entity multiple brhaviour



using System;
namespace MyApp
{
    public class Student{
        public string Name;
        public int RollNumber;
        public string Gender;

        private string Address;



        public void PrintStudentInfo(){
            Console.WriteLine($"{Name} {RollNumber}");
        }
        public void PrintStudentInfo(string saltutation){
            Console.WriteLine($"{saltutation}  {Name} {RollNumber}");
        } 
    }




    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student1=new Student();
            student1.Name = "varsha";
            student1.RollNumber=1;

            student1.PrintStudentInfo("amit");

            Console.ReadKey();
        }
    }
    
}