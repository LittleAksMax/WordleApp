namespace WordleLib.Exceptions;

public class UnacceptableWordException : Exception
{
    public UnacceptableWordException() : base() { }
    public UnacceptableWordException(string message) : base(message) { }
    public UnacceptableWordException(string message, Exception inner) : base(message, inner) { }
}
