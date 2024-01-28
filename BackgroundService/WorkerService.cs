
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BackgroundService1
{
    public class WorkerService : IHostedService
    {
        private readonly ILogger<WorkerService> _logger;
        public WorkerService(ILogger<WorkerService> logger)
        {
            _logger = logger;
        }

        //protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        //{
        //    while (!cancellationToken.IsCancellationRequested)
        //    {
        //        _logger.LogInformation("background running");
        //        await Task.Delay(1000);
        //    }
        //}

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("hosted service running");
            await Task.Delay(20000);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("hosted service stopped");
        }
    }
}
