using CleanFactory.Dependencies;

namespace CleanFactory.Processors
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

		public bool IsValidUser(RequestType requestType)
		{
			return requestType == RequestType.External;
		}
	}
}
