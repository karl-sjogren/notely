namespace Notely.Core.Tests.FileSystem;

public class MockedFileSystemProvider : IFileSystemProvider {
    public bool FileExists(string path) {
        throw new NotImplementedException();
    }

    public IFileInfo GetFile(string path) {
        throw new NotImplementedException();
    }

    public IDirectoryInfo? GetParentDirectory(string path) {
        throw new NotImplementedException();
    }

    public string GetWorkingDirectory() {
        throw new NotImplementedException();
    }
}
