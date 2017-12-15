using DirtyFactory.Dependencies;

namespace DirtyFactory.Processors
{
	internal class ExternalProcessor : IProcessor
	{
		private readonly IDependencyOne _depOne;
		private readonly IDependencyThree _depThree;

		public ExternalProcessor(IDependencyOne depOne, IDependencyThree depThree)
		{
			_depOne = depOne;
			_depThree = depThree;
		}

		public string GetResponse()
		{
			return "External Response";
		}

		public bool IsUser(RequestType requestType)
		{
			return requestType == RequestType.External;
		}
	}
}
