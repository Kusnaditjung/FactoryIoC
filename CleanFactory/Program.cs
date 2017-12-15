using System;
using System.Reflection;
using CleanFactory.Dependencies;
using CleanFactory.Processors;
using SimpleInjector;

namespace CleanFactory
{
	internal class Program
	{
		internal static IProcessorFactory _processorFactory;
		static void Main(string[] args)
		{
			//register the container
			Container container = GetRegisteredContainer();

			//simulate the internal state of the program
			_processorFactory = container.GetInstance<ProcessorFactory>();

			//each of this request below simulate independant executing of the program
			RunRequest(RequestType.Internal);
			RunRequest(RequestType.External);

			//just to hold the program
			Console.ReadKey();
		}

		private static void RunRequest(RequestType requestType)
		{
			IProcessor internalProcessor = _processorFactory.Create(requestType);
			Console.WriteLine(internalProcessor.GetResponse());
		}

		private static Container GetRegisteredContainer()
		{
			SimpleInjector.Container container = new SimpleInjector.Container();
			container.Register<IDependencyOne, DependencyOne>();
			container.Register<IDependencyTwo, DependencyTwo>();
			container.Register<IDependencyThree, DependencyThree>();
			container.Register<IProcessorFactory, ProcessorFactory>();
			container.RegisterCollection<IProcessor>(new Assembly[] { Assembly.GetExecutingAssembly() });
			return container;
		}
	}
}
