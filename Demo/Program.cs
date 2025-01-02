namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            // Struct : Value types : Stack

            // Employee
            // Id , Name , Salary 

            // Point 

            // Point P01;
            // Declare for object from type 'Point'
            // P01 : Object
            // Allocate 8 bytes at stack

            // Console.WriteLine(P01.X);
            // Console.WriteLine(P01.Y);

            // P01.X = 12;
            // P01.Y = 12;
            // Console.WriteLine(P01.X);
            // Console.WriteLine(P01.Y);

            // P01 = new Point(1,2);
            // new : used for selecting the constructor
            // Console.WriteLine(P01.X);
            // Console.WriteLine(P01.Y);
            // Console.WriteLine(P01); // Demo.Point

            // P01.PrintPoint();
            // Console.WriteLine(P01.ToString()); // Demo.Point
            // Console.WriteLine(P01); // Demo.Point
            // Point[] Points = new Point[10]; 
            #endregion

            #region OOP Overview
            // OOP : Object Oriented Programming
            // Programming Paradigm
            // OOP : Paradigm used to build any business

            // Class : Blueprint of the object
            // Object : Specific instance from class

            // 4 Pillars
            // =============
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction 
            #endregion

            #region Encapsulation 
            // 1. Encapsulation
            // Class or Struct
            // Separate the data (Attributes) definition from its use
            // [Setter Getter methods - Properties]

            // Employee
            // Id , Name  , Salary

            // 1. End user access data itself
            // 2. No data validation
            // 3. There is no read only field

            // Apply Encapsulation
            // 1. Make all data (Attributes) private
            // 2. Access data through
            // 2.1. Setter Getter methods
            // 2.2. Properties


            // Employee E01 = new Employee(1,"Ahmed",-12000);
            // Console.WriteLine(E01);

            // Id : Read only attribute

            // E01.GetId(); 

            // E01.id = 1;
            // E01.name = "Ahmed";
            // E01.salary = 12000;

            // Console.WriteLine(E01.id);
            // Console.WriteLine(E01.name);
            // Console.WriteLine(E01.salary);

            // E01.SetId(1);
            // E01.SetName("Ahmed");
            // E01.SetSalary(12000);

            // Console.WriteLine(E01.GetId());
            // Console.WriteLine(E01.GetName());
            // Console.WriteLine(E01.GetSalary());

            // Console.WriteLine(E01);

            // Employee E01 = new Employee();

            // E01.Id = 12;
            // E01.Name = "Ahmed Amin";
            // E01.Salary = 12000;
            // E01.Address = "Cairo";

            // Console.WriteLine(E01.Id);
            // Console.WriteLine(E01.Name);
            // Console.WriteLine(E01.Salary);
            // Console.WriteLine(E01.Address);
            #endregion

            #region  Indexer
            // Indexer : Special property
            //          1.Named this
            // Phonebook : 

            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed",111,0);
            //phoneBook.AddPerson("Ali",222,1);
            //phoneBook.AddPerson("Omar",333,2);

            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));

            //phoneBook.UpdateNumber("Ahmed",999);

            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));

            //Console.WriteLine(phoneBook["Ahmed"]); // long
            //phoneBook["Ahmed"]=999; // long

            //Console.WriteLine(phoneBook["Ahmed"]); // long

            //Console.WriteLine(phoneBook[111]); 
            #endregion

            // Class : Reference types -> heap

            // Car : Id Model Speed 

            // Car C01;
            // Declare for reference 'Pointer' from type car
            // C01 : Can refer to object from type 'Car' or any class inherited from car
            // C01 : Refer to null 

            // Console.WriteLine(C01);
            // 8 Bytes will be allocated at stack for the reference 'C01'
            // 0 Bytes will be allocated at heap for the reference 'C01'

            // C01 = new Car(1);
            // C01 = new Car(1,200);
            // C01 = new Car(1,200,"XYZ");
            // Car C01 = new Car(1,300, "xyz");
            // new
            // 1. Allocate the number of required bytes at heap
            // 2. Initialization with the default value 
            // 3. Call user-defined constructor if exists
            // 4. Assign the object to the reference

            // Console.WriteLine(C01.Id);
            // Console.WriteLine(C01.Model);
            // Console.WriteLine(C01.Speed);

            // Console.WriteLine(C01);
        }
    }
}
