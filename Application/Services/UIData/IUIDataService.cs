using Application.DTOs;
using Domain;

namespace Application.Services.UIData
{
    public interface IUIDataService
    {
        public List<SwimLength> SwimLengthData { get; set; }
        void SetSwimLengthsFromFormSwimData(List<FormSwimLength> formSwimLengthList);
        List<StrokeCountvsLengthTimeDTO> GetStrokeCountVSLengthTimeScatterData();
        List<LengthTimeOverTimeDTO> GetLengthTimeOverTimeData();
        List<AvgDPSvsIntervalDTO> GetAvgDPSvsIntervalData();
        List<RestTimeOverTimeLineDTO> GetRestTimeOverTimeData();
    }
}
