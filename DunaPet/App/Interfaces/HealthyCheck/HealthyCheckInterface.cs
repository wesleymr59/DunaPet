using DunaPet.App.Entities.HealthyCheck;

namespace DunaPet.App.Interfaces.HealthyCheck
{

    public interface IHealthyCheck
    {
        Task<HealthyCheckEntitieResponse<string>> GetHealthyCheck();
    }
}

