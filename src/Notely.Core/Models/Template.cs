namespace Notely.Core.Models;

public class Template {
}

public class TemplateManifest {
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public TemplateType Type { get; set; } = TemplateType.Global;
    public TemplateFormat Format { get; set; } = TemplateFormat.Scriban;
}
