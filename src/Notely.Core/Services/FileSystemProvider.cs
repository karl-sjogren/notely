namespace Notely.Core.Services;

public class FileSystemProvider : IFileSystemProvider {
    public bool FileExists(string path) => new FileInfo(path).Exists;

    public IFileInfo GetFile(string path) => new FileInfoImpl(new FileInfo(path));

    public IDirectoryInfo? GetParentDirectory(string path) {
        var directoryInfo = Directory.GetParent(path);
        if(directoryInfo == null) {
            return null;
        }

        return new DirectoryInfoImpl(directoryInfo);
    }

    public string GetWorkingDirectory() => Environment.CurrentDirectory;
}
