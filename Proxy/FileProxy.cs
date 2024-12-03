namespace Proxy;

public class FileProxy: IMyFile
{
    private MyFile? _myFile;
    private string _path;

    public FileProxy(string path)
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

    public byte[] ReadAll()
    {
        if (_myFile == null)
        {
            _myFile = new MyFile(_path);    
        }
        
        return _myFile.ReadAll();
    }

    public long Size() => _myFile?.Size() ?? new System.IO.FileInfo(_path).Length;
}