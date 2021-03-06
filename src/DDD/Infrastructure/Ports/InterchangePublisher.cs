using DDD.Logging;

namespace DDD.Infrastructure.Ports
{
	public class InterchangePublisher : Publisher, IInterchangePublisher
	{
		public InterchangePublisher(
			IInterchangeEventAdapter eventAdapter,
			ILogger logger) :
			base(
				eventAdapter,
				logger)
		{
			
		}
	}
}
