using System;
using System.IO;
using  System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// namespace ReadWriteTextFile;

public class Student
{
    // Constructor

    public Student(string name, DateTime dateOfBirth)
    {
        this.Name = name;
        this.DateOfBirth = dateOfBirth;
    }   

    // Student Name property

    public string Name { get; set; }
    
    // Student Date of Birth property

    public DateTime DateOfBirth { get; set;  }

    // Method of Display

    public void DisplayInfo()
    {
        Console.WriteLine("{0}, {1}", Name, DateOfBirth.ToString("dd mmm, yyyy"));
    }
}