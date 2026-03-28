namespace Week8;

public class FileResource: Resource, IDisposable
{

    public FileResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Opened");
    }

    public override void Close()
    {
        Console.WriteLine("Closed");
    }
    
    public void Dispose()
    {
        Close();
        Console.WriteLine("File was closed");
    }
}