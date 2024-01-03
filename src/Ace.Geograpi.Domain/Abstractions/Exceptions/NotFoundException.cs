namespace Ace.Geograpi.Domain.Abstractions.Exceptions;

public abstract class NotFoundException : Exception
{
    protected NotFoundException()
    {
    }

    protected NotFoundException(string message)
        : base(message)
    {
    }

    protected NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
