string? choice;
string file = "characterdata.txt";
do
{
    // ask user a question
    Console.WriteLine("1) Read data from file.");
    Console.WriteLine("2) Create file from data.");
    Console.WriteLine("Enter any other key to exit.");

    choice = Console.ReadLine();

    if (choice == "1")
    {
        if (File.Exists(file))
        {
            StreamReader sr = new(file);
            while (!sr.EndOfStream)
            {
                string? line = sr.ReadLine();
                string[] arr = String.IsNullOrEmpty(line) ? [] : line.Split(',');
                Console.WriteLine("ID: {0}", arr[0],arr[1],arr[2]);
                Console.WriteLine("Name: {1}",arr[0],arr[1],arr[2]);
                Console.WriteLine("Relation to mario: {2}",arr[0],arr[1],arr[2]);
            }
            sr.Close();

        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
    else if (choice == "2")
    {
        StreamWriter sw = new(file);
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Enter a character (Y/N)?");
            string? resp = Console.ReadLine()?.ToUpper();
            if (resp != "Y") { break; }
            Console.WriteLine("Enter Character ID.");
            string? ID = Console.ReadLine();
            Console.WriteLine("Enter the character name.");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the characters relation to mario.");
            string? mario = Console.ReadLine();
            sw.WriteLine("{0},{1},{2}", ID, name, mario);
        }
        sw.Close();
    }
} while (choice == "1" || choice == "2");
