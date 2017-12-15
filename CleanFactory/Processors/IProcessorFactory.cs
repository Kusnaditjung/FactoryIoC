namespace CleanFactory.Processors
{
	interface IProcessorFactory
	{
		IProcessor Create(RequestType requestType);
	}
}
