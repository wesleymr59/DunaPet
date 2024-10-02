using DunaPet.App.Entities.HealthyCheck;
using DunaPet.App.Interfaces.HealthyCheck;

namespace DunaPet.Infrastructure.Database.Teste
{
    public class HealthyCheckDB : IHealthyCheck
    {

        public Task<HealthyCheckEntitieResponse<string>> GetHealthyCheck()
        {
            var response = new HealthyCheckEntitieResponse<string>
            {
                Message = "healthy check ok",
            };
            return  Task.FromResult(response);
        }

    }
}
