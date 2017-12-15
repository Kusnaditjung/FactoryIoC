using System;
using DirtyFactory.Dependencies;

namespace DirtyFactory.Processors
{
	internal class ProcessorFactory : IProcessorFactory
	{
		private readonly IDependencyOne _depOne;
		private readonly IDependencyTwo _depTwo;
		private readonly IDependencyThree _depThree;

		public ProcessorFactory(IDependencyOne depOne, IDependencyTwo depTwo, IDependencyThree depThree)
		{
			_depOne = depOne;
			_depTwo = depTwo;
			_depThree = depThree;
		}

		public IProcessor Create(RequestType requestType)
		{
			switch(requestType)
			{
				case RequestType.Internal:
					return new InternalProcessor(_depOne, _depTwo);
				case RequestType.External:
					return new ExternalProcessor(_depOne, _depThree);
				default:
					throw new NotImplementedException();
			}
		}
	}
}
