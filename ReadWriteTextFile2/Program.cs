using ReadWriteTextFile2;

string? folder = Environment.CurrentDirectory;
var file = Path.Join(folder, "data.txt");

var fileManager = new FileManager(file);

List<Student> students = fileManager.LoadFile();
Console.Clear();



    
bool isQuit = false;

    
        do
        {
            Console.WriteLine("Enter a to add, l to list, q to quit :> ");
            var input = Console.ReadLine();

            switch (input) 
            {
                case "a" :
                Console.Clear();
                Console.WriteLine("Enter students name, date of birth (e.g. Morrison Anyanwu, 1990/09/15) :> ");
                var studentEntry = Console.ReadLine() ?? "";
                var entries = studentEntry.Split( ", " ).ToList<string>();
                var name = entries[0];
                var dob = DateTime.Parse(entries[1]);
                students.Add(new Student(name, dob));
                Console.WriteLine("Student {0} has been added. ", name);
                break;

                case "l" :
                Console.Clear();
                Console.WriteLine("Students List");
                Console.WriteLine("=================");
                foreach (var student in students)
                {
                    student.DisplayInfo();
                }
                Console.WriteLine();
                break;

                case "q" :
                isQuit = true;
                fileManager.SaveToFile(students);
                break;

                default:
                Console.WriteLine("Invalid Entry");
                break;
            } 

        } while (!isQuit);

        Console.WriteLine("Good Bye!");