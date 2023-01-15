using Spectre.Console.Cli;

namespace Notely.App.Infrastructure;

// Code taken from https://github.com/spectreconsole/spectre.console/tree/main/examples/Cli/Injection
public sealed class TypeResolver : ITypeResolver, IDisposable {
    private readonly IServiceProvider _provider;

    public TypeResolver(IServiceProvider provider) {
        _provider = provider ?? throw new ArgumentNullException(nameof(provider));
    }

    public object? Resolve(Type? type) {
        if(type == null) {
            return null;
        }

        return _provider.GetService(type);
    }

    public void Dispose() {
        if(_provider is IDisposable disposable) {
            disposable.Dispose();
        }
    }
}
