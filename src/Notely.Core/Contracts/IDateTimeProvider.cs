namespace Notely.Core.Contracts;

public interface IDateTimeProvider {
    DateTime Now { get; }
}
