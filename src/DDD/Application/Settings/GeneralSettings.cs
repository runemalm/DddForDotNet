using Microsoft.Extensions.Options;

namespace DDD.Application.Settings
{
	public class GeneralSettings : IGeneralSettings
	{
		public string Context { get; }
		
		public GeneralSettings() { }

		public GeneralSettings(IOptions<Options> options)
		{
			var context = options.Value.GENERAL_CONTEXT;

			Context = context;
		}
	}
}
