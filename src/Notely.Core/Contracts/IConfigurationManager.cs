namespace Notely.Core.Contracts;

public interface IConfigurationManager {
    Task<INotelyConfiguration> GetConfigurationAsync(CancellationToken cancellationToken);
}
