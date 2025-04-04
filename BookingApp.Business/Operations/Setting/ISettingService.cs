using BookingApp.Business.Types;

namespace BookingApp.Business.Operations.Setting
{
    public interface ISettingService
    {
        Task ToggleMaintenence();
        bool GetMaintenenceState();
    }
}