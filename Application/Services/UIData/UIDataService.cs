using Application.DTOs;
using Domain;

namespace Application.Services.UIData
{
    public class UIDataService : IUIDataService
    {
        public List<SwimLength> SwimLengthData { get; set; } = new();

        public List<LengthTimeOverTimeDTO> GetLengthTimeOverTimeData()
            => SwimLengthData.Where(length => length.TotalMoveSeconds > 0 && length.Stroke != "REST")
                                   .Select(length => new LengthTimeOverTimeDTO() { LengthTime = length.TotalMoveSeconds, Time = length.SwimTime })
                                   .OrderBy(length => length.Time)
                                   .ToList();

        public List<StrokeCountvsLengthTimeDTO> GetStrokeCountVSLengthTimeScatterData()
            => SwimLengthData.Where(length => length.TotalMoveSeconds > 0 && length.Stroke != "REST")
                                   .Select(length => new StrokeCountvsLengthTimeDTO() { StrokeCount = length.StrkCount, LengthTime = length.TotalMoveSeconds })
                                   .ToList();

        public List<AvgDPSvsIntervalDTO> GetAvgDPSvsIntervalData()
            => SwimLengthData.Where(length => length.TotalMoveSeconds > 0 && length.Stroke != "REST")
                             .Select(length => new AvgDPSvsIntervalDTO() { AvgDPS = length.AvgDPS, Interval = length.Interval })
                             .ToList();

        public List<RestTimeOverTimeLineDTO> GetRestTimeOverTimeData()
            => SwimLengthData.Where(length => length.Stroke == "REST")
                             .Select(length => new RestTimeOverTimeLineDTO() { Time = length.SwimTime, TotalRestTime = length.TotalRestSeconds })
                             .ToList();

        public void ClearData()
            => SwimLengthData.Clear();

        public void SetSwimLengthsFromFormSwimData(List<FormSwimLength> formSwimLengthList)
        {
            SwimLengthData = formSwimLengthList.Select(length => new SwimLength(length)).ToList();
        }
    }
}
