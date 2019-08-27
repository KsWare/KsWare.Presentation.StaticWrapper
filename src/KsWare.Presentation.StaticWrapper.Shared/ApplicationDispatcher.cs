using System.ComponentModel.Composition;

namespace KsWare.Presentation.StaticWrapper
{
	//TODO revise ApplicationDispatcher architecture / usage of ApplicationWrapper

	//[Export(typeof(IApplicationDispatcher)), PartCreationPolicy(CreationPolicy.Shared)]
	public static class ApplicationDispatcher
	{
		public static ApplicationDispatcherExtender Do { get; } = new ApplicationDispatcherExtender();
	}

	[Export(typeof(IApplicationDispatcher)),PartCreationPolicy(CreationPolicy.Shared)]
	public class ApplicationDispatcherInstance : IApplicationDispatcher
	{
		public ApplicationDispatcherExtender Do { get; } = new ApplicationDispatcherExtender();
	}
}