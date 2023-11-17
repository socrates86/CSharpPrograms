using System.IO;
namespace ReadTextFile;

class Program
{
    static void Main(string[] args)
    {
        try {
            StreamReader sr = new StreamReader("Actors.txt");

        string? oneName = string.Empty;
        string? [] names = new string[6];
        int index = 0;

        while( (oneName = sr.ReadLine() ) != null ) {
            names[index] = oneName;
            Console.WriteLine(names[index]);
            index++;
        }
        sr.Dispose();
        }
        catch(Exception e) {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally {
            Console.WriteLine("Executing finally block.");
        }
    }
}
