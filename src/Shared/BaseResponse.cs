namespace Shared;

public abstract class BaseResponse
{
    protected BaseResponse(bool success, Error? error)
    {
        Success = success;
        Error = error;
    }

    public bool Success { get; }
    public Error? Error { get; }
}
