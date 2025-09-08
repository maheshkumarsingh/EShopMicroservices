namespace BuildingBlocks.Exceptions;
public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    {
    }
    public NotFoundException(string name, Exception exception) : base($"Entity \"{name}\" was not found.", exception)
    {
    }
}
