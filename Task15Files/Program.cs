namespace Task15Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\File.txt";
            //Task 1 
            //File.Create(path);

            //Task 2
            //try
            //{
            //    if (File.Exists(path))
            //    {
            //        File.Delete(path);
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exists!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Task 3
            //    if (File.Exists(path))
            //{
            //    Console.WriteLine("File is exist!");
            //}
            //else
            //{
            //    File.Create(path);
            //}

            //Task 4
            //File.WriteAllText(path, "First Line");

            //Task 5
            //Console.WriteLine(File.ReadAllText(path));

            //Task 6
            //Console.Write("input number of lines to write in the file: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string[] strings = new string[num];
            //Console.WriteLine($"Input {num} strings below: ");
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.Write($"input the text {i}:");
            //    strings[i] = Console.ReadLine()!;
            //}
            //File.WriteAllLines(path, strings);

            //Task 7
            //Console.Write("input number of lines to write in the file: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string[] strings = new string[num];
            //Console.Write($"Input the string to ignore the line: ");
            //string ignore = Console.ReadLine()!;
            //Console.WriteLine($"Input {num} strings below: ");
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.Write($"input the string {i}:");
            //    strings[i] = Console.ReadLine()!;
            //}
            //List<string> arr = new List<string>();
            //foreach (string line in strings)
            //{
            //    if (!line.Contains(ignore))
            //    {
            //        arr.Add(line);
            //    }
            //}
            //File.WriteAllLines(path, arr);

            //Task 8
            //Console.Write("Append new text: ");
            //string name = Console.ReadLine()!;
            //File.AppendAllText(path, name);

            //Task 9
            //string path2 = @"C:\Users\User\Desktop\mynewtest.txt";
            //File.Copy(path, path2);

            //Task 10
            //string path3 = @"C:\Users\User\Desktop\mynewtest2.txt";
            //File.Move(path, path3);

            //Task 11
            //string[] arr = { "First Line", "Second Line", "Third Line" };
            //File.WriteAllLines(path, arr);

            //Console.WriteLine("The content of the first line of the file is: ");
            //string[] lines = File.ReadAllLines(path);
            //Console.Write(lines[0]);

            //Task 12
            //Console.Write("Input number of lines to write in the file: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Input {count} strings: ");
            //string[] arr = new string[count];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Input line {i+1}: ");
            //    arr[i] = Console.ReadLine()!;
            //}
            //File.WriteAllLines(path, arr);
            //Console.WriteLine("The content of the last line of the file is: ");
            //string[] lines = File.ReadAllLines(path);
            //Console.Write(lines[count-1]);

            //Task 13
            //Console.Write("Input number of lines to write in the file: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Input {count} strings: ");
            //string[] arr = new string[count];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Input line {i + 1}: ");
            //    arr[i] = Console.ReadLine()!;
            //}
            //File.WriteAllLines(path, arr);
            //Console.Write("Input which line you want to display: ");
            //int linecount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The content of the line {linecount} of the file is: ");
            //string[] lines = File.ReadAllLines(path);
            //Console.Write(lines[linecount - 1]);

            //Task 14
            //Console.Write("Input number of lines to write in the file: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Input {count} strings: ");
            //string[] arr = new string[count];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Input line {i + 1}: ");
            //    arr[i] = Console.ReadLine()!;
            //}
            //File.WriteAllLines(path, arr);
            //Console.Write("Input last how many numbers of lines you want to display: ");
            //int linecount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"The content of the last {linecount} lines of the file is: ");
            //string[] lines = File.ReadAllLines(path);
            //for (int i = lines.Length - linecount; i < lines.Length; i++)
            //{
            //    Console.WriteLine(lines[i]);
            //}

            //Task 15
            //Console.WriteLine("Here is the content of the file: ");
            //string[] arr = { "line 1", "Line 2", "Line 3", "Line 4", "Line 5", "Line 6" };
            //File.WriteAllLines(path, arr);
            //Console.Write($"Number of the lines in the file is: ");
            //File.ReadAllLines(path);
            //Console.WriteLine(arr.Length);


        }
    }
}