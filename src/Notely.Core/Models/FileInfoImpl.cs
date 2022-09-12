namespace Notely.Core.Models;

public class FileInfoImpl : IFileInfo {
    private readonly FileInfo _fileInfo;

    public FileInfoImpl(FileInfo fileInfo) {
        _fileInfo = fileInfo;
    }

    public string FullName => _fileInfo.FullName;

    public bool Exists => _fileInfo.Exists;

    public Stream OpenRead() => _fileInfo.OpenRead();
}
