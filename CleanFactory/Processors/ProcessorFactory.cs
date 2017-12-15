using System.Collections.Generic;
using System.Linq;

namespace CleanFactory.Processors
{
	internal class ProcessorFactory : IProcessorFactory
	{
		private readonly IEnumerable<IProcessor> _processors;
		public ProcessorFactory(IEnumerable<IProcessor> processors)
		{
			_processors = processors;
		}
		public IProcessor Create(RequestType requestType)
		{
			return _processors.Single(item => item.IsValidUser(requestType));
		}
	}
}
