using System;
using System.Text;
using System.IO;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {

            string? data;
            try
            {
               StreamReader sr = new StreamReader("animal.txt");
                data = sr.ReadLine();

                while(data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();

                }
                
                sr.Close();
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }

            finally
            {
        
                Console.WriteLine("Good Luck!");
                
            }
        }
    }
}