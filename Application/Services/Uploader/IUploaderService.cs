using Application.Services.Uploader;
using Domain;

namespace Client.Services.Uploader
{
    public interface IUploaderService
    {
        Task<UploadResult> GetSwimDataFromCSVAsync(Stream fileStream);
    }
}
