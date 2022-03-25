// See https://aka.ms/new-console-template for more information
using Colors.Net;
using Microsoft.Extensions.CommandLineUtils;
using YoutubeVideosCLI;

Console.WriteLine("Hello, World!");
    try
    {
        var app = new CommandLineApplication()
        {
            Name = "YoutubeCLI",
            FullName = "YoutubeCLI",
            Description = "YoutubeCLI"
        };

        //app.HelpOption("YoutubeCLI");
        app.Commands.Add(new CreateCommand());

        app.OnExecute(() => {
            ColoredConsole.Error.WriteLine("No commands specified, please specify a command");
            app.ShowHelp();
            return 1;
        });
        return app.Execute(args);
    }
    catch (Exception e)
    {
        ColoredConsole.Error.WriteLine(e.Message);
        return 1;
    }