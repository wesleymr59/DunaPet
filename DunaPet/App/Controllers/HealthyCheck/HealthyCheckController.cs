using DunaPet.App.Entities.HealthyCheck;
using DunaPet.App.Usecases.HealthyCheck;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DunaPet.App.Controllers.HealthyCheck
{
    [ApiController]
    [Route("api/")]
    public class HealthyCheckController : ControllerBase
    {
        private readonly HealthyCheckUseCase _healthyCheckUseCase;
        public HealthyCheckController(HealthyCheckUseCase healthyCheckUseCase)
        {
            _healthyCheckUseCase = healthyCheckUseCase;
        }

        [HttpGet("healthy_check")]
        public Task<HealthyCheckEntitieResponse<string>> getHealthyCheck()
        {
            var response = _healthyCheckUseCase.GetHealthyCheck();
            return response;
        }


    }
}
