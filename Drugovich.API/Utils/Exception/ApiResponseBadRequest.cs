using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Drugovich.API.Utils.Exception
{
    public class ApiResponseBadRequest: ApiResponse
    {
        public IEnumerable<string> Errors { get; }
        public ApiResponseBadRequest(ModelStateDictionary modelState)
            : base(400)
        {
            if (modelState.IsValid)
            {
                throw new ArgumentException("ModelState deve ser inválido", nameof(modelState));
            }
            Errors = modelState.SelectMany(x => x.Value.Errors)
                .Select(x => x.ErrorMessage).ToArray();
        }
    }
}
