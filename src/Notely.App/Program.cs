using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;
using Notely.App.Infrastructure;
using Notely.App.Commands;

var services = new ServiceCollection();
//services.AddSingleton<IGreeter, HelloWorldGreeter>();

var registrar = new TypeRegistrar(services);

// Create a new command app with the registrar
// and run it with the provided arguments.
var app = new CommandApp(registrar);
app.Configure(config => {
    config.AddCommand<GenerateNoteCommand>("create")
        .WithDescription("Creates a new note.");

    config.AddCommand<ListTemplatesCommand>("templates")
        .WithDescription("Lists the templates available from the current location.");
});

return app.Run(args);
