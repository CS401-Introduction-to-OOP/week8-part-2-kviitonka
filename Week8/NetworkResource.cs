namespace Week8;

public class NetworkResource: Resource, IDisposable
{

    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine("Opened");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine("Closed");
    }
    
    public void Dispose()
    {
        Close();
        Console.WriteLine("File was closed");
    }
}