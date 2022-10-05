namespace Logm.FileUpdater.FileHandling;

public class FileMetaData
{
    private string _name;

    private long _size;

    private string _type;

    public FileMetaData(string name, long size, string type)
    {
        this._name = name;
        this._size = size;
        this._type = type;
    }
}