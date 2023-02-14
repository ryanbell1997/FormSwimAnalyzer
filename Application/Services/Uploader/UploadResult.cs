using Domain;

namespace Application.Services.Uploader
{
    public class UploadResult
    {
        public UploadResult(bool success, List<FormSwimLength>? data, string errorMessage = "")
        {
            this.IsSuccess = success;
            Data = data;
            ErrorMessage = errorMessage;
        }

        public bool IsSuccess { get; set; }
        public List<FormSwimLength>? Data { get; set; }
        public string ErrorMessage { get; set; }

        public static UploadResult Success(List<FormSwimLength> data)
            => new(true, data);

        public static UploadResult Failure(string errorMessage)
            => new(false, null, errorMessage);
    }
}
