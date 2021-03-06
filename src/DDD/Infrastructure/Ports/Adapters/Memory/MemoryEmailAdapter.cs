using System.Threading;
using System.Threading.Tasks;
using DDD.Logging;
using DDD.Application.Settings;

namespace DDD.Infrastructure.Ports.Adapters.Memory
{
	public class MemoryEmailAdapter : IEmailPort
	{
		private readonly ISettings _settings;
		private readonly ILogger _logger;
		private int SentCount = 0;

		public MemoryEmailAdapter(ISettings settings, ILogger logger)
		{
			_settings = settings;
			_logger = logger;
		}

		public async Task SendAsync(
			string fromEmail, string fromName, string toEmail, string toName, 
			string subject, string message, CancellationToken ct)
		{
			SentCount++;
		}
	}
}
