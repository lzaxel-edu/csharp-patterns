namespace Proxy;

public class MyFile: IMyFile
{
    private string _path; 
    public MyFile(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentException("Value cannot be null or empty.", nameof(path));
        }
        _path = path;
    }

    public string GetPath()
    {
        return _path;
    }

    public long Size()
    {
        using (var stream = File.Open(_path, FileMode.Open))
        {
            return stream.Length;    
        }
    }
    public byte[] ReadAll()
    {
        using (var stream = File.Open(_path, FileMode.Open))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
            
        }
    }
}