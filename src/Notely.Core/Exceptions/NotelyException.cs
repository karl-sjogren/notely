namespace Notely.Core.Exceptions;

public class NotelyException : Exception {
    public NotelyException() {
    }

    public NotelyException(string? message) : base(message) {
    }

    public NotelyException(string? message, Exception? innerException) : base(message, innerException) {
    }
}
