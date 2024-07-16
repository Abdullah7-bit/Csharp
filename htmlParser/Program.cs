static void Main(string[] args)
{
    WriteToFile wr = new WriteToFile();
    wr.Data();
    Console.ReadKey();
}
class WriteToFile
{

    public void Data()
    {
        // This will create a file named sample.txt 
        // at the specified location  
        StreamWriter sw = new StreamWriter("H://geeksforgeeks.txt");

        // To write on the console screen 
        Console.WriteLine("Enter the Text that you want to write on File");

        // To read the input from the user 
        string str = Console.ReadLine();

        // To write a line in buffer 
        sw.WriteLine(str);

        // To write in output stream 
        sw.Flush();

        // To close the stream 
        sw.Close();
    }
}