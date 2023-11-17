using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace Example5;

using static System.Console;
class Program
{
    // Write a program to accept a comment and append to a text file
    // then display all the comments including the one just added
    static void Main(string[] args)
    {
      // Declarations
      string path = @"C:\Projects\C#Comments.txt";
      StreamWriter sw = File.AppendText(path); // Open StreamWriter to append file

      // Accept comment from user in a string variable
      Console.WriteLine("Please enter a comment: ");
      string? commentLine = ReadLine();

      // Append comment to the file
      // Append: to add contents to existing content without over writing it
      sw.WriteLine(commentLine);
      sw.Close();

      // Display file
      WriteLine("\nCOMMENTS: ");
      WriteLine("----------");
      StreamReader sr = new StreamReader(path);

      // Read the first line from the stream reader
      string? str = sr.ReadLine();
      int i = 0;

      // Check to see if the file is empty or not
      // If it is not empty, then display data in loop
      while(str != null) // Keep looping until str is null and it will be null when file reaches the EOF(end of file)
      {
        Console.WriteLine(i++ + " " + str); // Display what you have read 

        // Then fetch the next record/next line
        str = sr.ReadLine();

      }
      Read();
    }
}
