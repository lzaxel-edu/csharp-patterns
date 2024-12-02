namespace Proxy;

public class MyFile: IMyFile
{
    private string _path; 
    public MyFile(string path)
    {
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