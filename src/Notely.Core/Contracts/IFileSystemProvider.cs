namespace Notely.Core.Contracts;

public interface IFileSystemProvider {
    string GetWorkingDirectory();
    IFileInfo GetFile(string path);
    bool FileExists(string path);
    IDirectoryInfo? GetParentDirectory(string path);
}
