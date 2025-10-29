namespace MyBookishSide.Common.Domain;

public record Error()
{
    public string Code { get; }
    public string Description { get; }
    public ErrorType ErrorType { get; }

    private Error(string code, string description, ErrorType errorType) : this()
    {
        Code = code;
        Description = description;
        ErrorType = errorType;
    }

    public static Error Failure(string code, string description) => new(code, description, ErrorType.Failure);
    public static Error NotFound(string code, string description) => new(code, description, ErrorType.NotFound);
    public static Error Conflict(string code, string description) => new(code, description, ErrorType.Conflict);
}
