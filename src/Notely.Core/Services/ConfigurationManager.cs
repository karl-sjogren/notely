using System.Text.Json;

namespace Notely.Core.Services;

public class ConfigurationManager : IConfigurationManager {
    private readonly IFileSystemProvider _fileSystemProvider;

    public ConfigurationManager(IFileSystemProvider fileSystemProvider) {
        _fileSystemProvider = fileSystemProvider;
    }

    public async Task<INotelyConfiguration> GetConfigurationAsync(CancellationToken cancellationToken) {
        var globalConfigurationPath = _fileSystemProvider.GetFile(Paths.GlobalConfigurationPath);
        var globalConfiguration = await ParseConfigurationFileAsync(globalConfigurationPath, cancellationToken);
        if(globalConfiguration is null) {
            throw new NotelyException($"Could not parse configuration file at {globalConfigurationPath.FullName}");
        }

        var localConfigurationPath = FindNearestAncestoralConfiguration(Environment.CurrentDirectory);
        if(localConfigurationPath is null) {
            return globalConfiguration;
        }

        var localConfiguration = await ParseConfigurationFileAsync(localConfigurationPath, cancellationToken);
        if(localConfiguration is null) {
            return globalConfiguration;
        }

        localConfiguration.Parent = globalConfiguration;
        return localConfiguration;
    }

    private IFileInfo? FindNearestAncestoralConfiguration(string path) {
        var possibleConfigurationPath = Path.Combine(path, Filenames.ConfigurationFilename);
        var possibleConfiguration = _fileSystemProvider.GetFile(possibleConfigurationPath);
        if(possibleConfiguration.Exists) {
            return possibleConfiguration;
        }

        var parentDirectory = _fileSystemProvider.GetParentDirectory(path);
        if(parentDirectory?.FullName == null) {
            return null;
        }

        return FindNearestAncestoralConfiguration(parentDirectory.FullName);
    }

    private static async Task<NotelyConfiguration?> ParseConfigurationFileAsync(IFileInfo file, CancellationToken cancellationToken) {
        var jsonOptions = DefaultValues.DefaultJsonOptions;

        using var fs = file.OpenRead();
        return await JsonSerializer.DeserializeAsync<NotelyConfiguration>(fs, jsonOptions, cancellationToken);
    }
}
