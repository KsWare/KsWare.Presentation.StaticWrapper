using System.ComponentModel.Composition;

namespace KsWare.Presentation.StaticWrapper
{
	//TODO revise ApplicationDispatcher architecture / usage of ApplicationWrapper

	//[Export(typeof(IApplicationDispatcher)), PartCreationPolicy(CreationPolicy.Shared)]
	public sealed class ApplicationDispatcher : IApplicationDispatcher
	{
		public ApplicationDispatcherExtender Do { get; } = new ApplicationDispatcherExtender();
	}
}