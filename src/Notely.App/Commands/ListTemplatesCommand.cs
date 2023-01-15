using Notely.Core.Contracts;
using Spectre.Console.Cli;

namespace Notely.App.Commands;

public sealed class ListTemplatesCommand : Command<ListTemplatesCommand.Settings> {
    private readonly ITemplateManager _templateManager;

    public sealed class Settings : CommandSettings {
    }

    public ListTemplatesCommand(ITemplateManager templateManager) {
        ArgumentNullException.ThrowIfNull(templateManager);

        _templateManager = templateManager;
    }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings) {
        return 0;
    }
}
