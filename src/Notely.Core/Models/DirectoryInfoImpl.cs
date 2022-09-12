namespace Notely.Core.Models;

public class DirectoryInfoImpl : IDirectoryInfo {
    private readonly DirectoryInfo _directoryInfo;

    public DirectoryInfoImpl(DirectoryInfo directoryInfo) {
        _directoryInfo = directoryInfo;
    }

    public string FullName => _directoryInfo.FullName;
}
