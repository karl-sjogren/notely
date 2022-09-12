namespace Notely.Core.Models;

public class NotelyConfiguration : INotelyConfiguration {
    public NotelyConfiguration() {
        BasePath = Paths.DefaultBasePath;
        TemplatePath = Path.Combine(BasePath, ".notely", "templates");
        DocumentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "notely");
    }

    public string? BasePath { get; set; }
    public string? TemplatePath { get; set; }
    public string? DocumentsPath { get; set; }
    public string? Culture { get; set; }
    public bool IsGlobal { get; set; }

    public NotelyConfiguration? Parent { get; set; }

    string? INotelyConfiguration.BasePath => BasePath ?? Parent?.BasePath;
    string? INotelyConfiguration.TemplatePath => TemplatePath ?? Parent?.TemplatePath;
    string? INotelyConfiguration.DocumentsPath => DocumentsPath ?? Parent?.DocumentsPath;
    string? INotelyConfiguration.Culture => Culture ?? Parent?.Culture;
}
