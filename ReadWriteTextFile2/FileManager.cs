using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWriteTextFile2;

    public class FileManager
    {
        // The Filepath 
        public string FilePath { get; set ; }


        // Constructor and Property(filepath)
        public FileManager ( string filePath )
        {
            FilePath = filePath;
        }

        public List<Student> LoadFile()
        {
            var studentList = new List<Student>();

            if (File.Exists(FilePath))
            {
                using (StreamReader reader = File.OpenText(FilePath))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string [] LineContents = line.Split(",");
                        var student = new Student(LineContents[0], DateTime.Parse(LineContents[1]));
                        studentList.Add(student);
                    }
                }
            }
            return studentList;
        }

        // Method created 
        public void SaveToFile(List<Student> studentList)
        {
            using (StreamWriter writer = File.CreateText(FilePath))
            {
                foreach(var student in studentList)
                {
                    writer.WriteLine("{0}, {1}", student.Name, student.DateOfBirth.ToString());
                }
            }
        }
    }