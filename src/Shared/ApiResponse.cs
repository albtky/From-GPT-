namespace Shared;

public class ApiResponse<T> : BaseResponse
{
    private ApiResponse(T data) : base(true, null)
    {
        Data = data;
    }

    private ApiResponse(Error error) : base(false, error)
    {
    }

    public T? Data { get; }

    public static ApiResponse<T> Ok(T data) => new(data);
    public static ApiResponse<T> Fail(Error error) => new(error);
}
