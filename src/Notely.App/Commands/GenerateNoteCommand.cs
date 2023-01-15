using System.ComponentModel;
using Notely.Core.Contracts;
using Spectre.Console.Cli;

namespace Notely.App.Commands;

public sealed class GenerateNoteCommand : Command<GenerateNoteCommand.Settings> {
    private readonly INoteGenerator _generator;

    public sealed class Settings : CommandSettings {
        [CommandOption("-t|--template <TEMPLATE>")]
        [Description("The type of note to generate.")]
        [DefaultValue("empty")]
        public string Name { get; set; } = string.Empty;
    }

    public GenerateNoteCommand(INoteGenerator generator) {
        ArgumentNullException.ThrowIfNull(generator);

        _generator = generator;
    }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings) {
        return 0;
    }
}
