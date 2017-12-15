namespace DirtyFactory.Processors
{
	internal interface IProcessorFactory
	{
		IProcessor Create(RequestType requestType);
	}
}
