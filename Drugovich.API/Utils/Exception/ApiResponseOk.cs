namespace Drugovich.API.Utils.Exception
{
    public class ApiResponseOk : ApiResponse
    {
        public object Result { get; }
        public ApiResponseOk(object result)
            : base(200)
        {
            Result = result;
        }
    }
}
