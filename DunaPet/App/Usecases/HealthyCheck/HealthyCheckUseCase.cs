using DunaPet.App.Entities.DTO.Request.User;
using DunaPet.App.Entities.HealthyCheck;
using DunaPet.App.Interfaces.HealthyCheck;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DunaPet.App.Usecases.HealthyCheck
{
    public class HealthyCheckUseCase
    {
        private readonly IHealthyCheck _healthyCheckInterface;

        public HealthyCheckUseCase(IHealthyCheck healthyCheck)
        {
            _healthyCheckInterface = healthyCheck;
        }

        public Task<HealthyCheckEntitieResponse<string>> GetHealthyCheck()
        {
            return _healthyCheckInterface.GetHealthyCheck();

        }

    }
}
