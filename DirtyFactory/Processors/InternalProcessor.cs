using DirtyFactory.Dependencies;

namespace DirtyFactory.Processors
{
	internal class InternalProcessor : IProcessor
	{
		private readonly IDependencyOne _depOne;
		private readonly IDependencyTwo _depTwo;

		public InternalProcessor(IDependencyOne depOne, IDependencyTwo depTwo)
		{
			_depOne = depOne;
			_depTwo = depTwo;
		}

		public string GetResponse()
		{
			return "Internal Response";
		}

		public bool IsUser(RequestType requestType)
		{
			return requestType == RequestType.Internal;
		}
	}
}
