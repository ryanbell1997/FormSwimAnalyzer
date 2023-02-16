using Application.Services.Uploader;
using CsvHelper;
using Domain;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Client.Services.Uploader
{
    public class UploaderService : IUploaderService
    {
        private readonly ILogger<UploaderService> _logger;

        public UploaderService(ILogger<UploaderService> logger)
        {
            _logger = logger;
        }

        public async Task<UploadResult> GetSwimDataFromCSVAsync(Stream fileStream)
        {
            if (fileStream is null) return UploadResult.Failure("File stream was null");

            List<FormSwimLength> swimLengthList = new(); 

            using (var reader = new StreamReader(fileStream))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                try
                {
                    swimLengthList = await csv.GetRecordsAsync<FormSwimLength>().ToListAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error occured while attempting to convert CSV to classes - {ex.Message} - STACK TRACE: {ex.StackTrace}");
                }
            }

            return UploadResult.Success(swimLengthList);
        }
    }
}
