namespace Notely.Core.Contracts;

public interface INotelyConfiguration {
    string? BasePath { get; }
    string? TemplatePath { get; }
    string? DocumentsPath { get; }
    string? Culture { get; }
}
