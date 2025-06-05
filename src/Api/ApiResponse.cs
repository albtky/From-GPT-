namespace Api;

public record ApiResponse<T>(T Data, bool Success = true, string? Error = null)
{
    public static ApiResponse<T> Ok(T data) => new(data);
    public static ApiResponse<T> Fail(string error) => new(default!, false, error);
}
