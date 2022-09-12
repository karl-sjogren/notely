namespace Notely.Core.Constants;

public static class Paths {
    public static string DefaultBasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".notely");
    public static string GlobalConfigurationPath => Path.Combine(DefaultBasePath, Filenames.ConfigurationFilename);
}
