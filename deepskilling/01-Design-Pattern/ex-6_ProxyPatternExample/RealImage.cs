using System.IO;

public class RealImage : Image
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadFromServer();
    }

    private void LoadFromServer()
    {
        if (File.Exists(fileName))
            Console.WriteLine($"Loading image: {fileName}");
        else
            Console.WriteLine("Image file not found!");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {fileName}");
    }
}