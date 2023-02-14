using Domain;

namespace Application.Services.UIData
{
    public class UIDataService : IUIDataService
    {
        public List<SwimLength> SwimLengthData { get; set; } = new();

        public void SetSwimLengthsFromFormSwimData(List<FormSwimLength> formSwimLengthList)
        {
            SwimLengthData = formSwimLengthList.Select(length => new SwimLength(length)).ToList();
        }
    }
}
