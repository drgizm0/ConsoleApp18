using System;
using System.IO;

public class Notepad
{
    public static void Main()
    {
        string fileName = "data.txt"; 
        string data = "Hello Universe"; 

        
        WriteDataToFile(fileName, data);

        
        string readData = ReadDataFromFile(fileName);

        Console.WriteLine("Read data: " + readData);
    }

    
    public static void WriteDataToFile(string fileName, string data)
    {
        try
        {
            
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                
                writer.Write(data);
            }

            Console.WriteLine("Data written to the file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing data to the file: " + ex.Message);
        }
    }

    
    public static string ReadDataFromFile(string fileName)
    {
        string data = "";

        try
        {
            
            using (StreamReader reader = new StreamReader(fileName))
            {
                
                data = reader.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading data from the file: " + ex.Message);
        }

        return data;
    }
}
