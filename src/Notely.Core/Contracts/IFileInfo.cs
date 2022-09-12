namespace Notely.Core.Contracts;

public interface IFileInfo {
    string FullName { get; }
    bool Exists { get; }
    Stream OpenRead();
}
