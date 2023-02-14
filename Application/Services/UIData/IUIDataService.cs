using Domain;

namespace Application.Services.UIData
{
    public interface IUIDataService
    {
        public List<SwimLength> SwimLengthData { get; set; }
        void SetSwimLengthsFromFormSwimData(List<FormSwimLength> formSwimLengthList);
    }
}
