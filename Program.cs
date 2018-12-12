using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractice{
    class Program{
        /***********************************************
            Declarations 
        ************************************************/
        private string name;
        private int age;
        private string email;
        private string address;
        /**********************************
            Setters and Getters
         **********************************/
        public void SetName(string n) {
            name = n;
        }// end SetName()
        public string GetName() {
            return name;
        }// end GetName()
        public void SetAge(int a) {
            age = a;
        }// end SetAge()
        public int GetAge() {
            return age;
        }// end GetAge()

        // This is an ALTERNATE WAY to write GETTERS and SETTERS in C#. (This is much shorter than Java.)
        public string Email { get; set; }
        public string Address { get; set; }

        /*************************************************
            Constructors
         *************************************************/
        public Program() {
            SetName("");
            SetAge(0);
        }// end empty constructor
        public Program(string n, int a) {
            SetName(n);
            SetAge(a);
        }// end parameter filled constructor

        // This is an ALTERNATE WAY to write CONSTRUCTORS in C#.
        public Program
        /***************************************************
            Display() method displays Object data to the 
            console for testing.
         ***************************************************/
        public void Display() {
            Console.WriteLine("Name: "+GetName()+". ");
            Console.WriteLine("Age: "+GetAge()+". ");
            Console.WriteLine("Email: "+Email);
            Console.WriteLine("Address: "+Address);
            Console.WriteLine("");
            Console.WriteLine("Oh Yeah... ");
            Console.WriteLine("HELLO WORLD! - I am a Object Oriented Java Developer that is now learning C#!");
        }// end Display()

        /**************************************************
            Main is used for unit testing.
        ***************************************************/
        static void Main(string[] args){

            /*******************************************
                Creating an instance of this class.
            ********************************************/
            Program p1;
            p1 = new Program("Jarvis",385);
            p1.Email = "Mattwright@example.com";
            p1.Address = "777 Address Rd. SW Clayton, GA 42385";
            p1.Display();
            Console.ReadLine();

        }// end Main
    }// end Program
}// end namespace
