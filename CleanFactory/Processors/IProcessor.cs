namespace CleanFactory.Processors
{
	internal interface IProcessor
	{
		bool IsValidUser(RequestType requestType);
		string GetResponse();
	}
}