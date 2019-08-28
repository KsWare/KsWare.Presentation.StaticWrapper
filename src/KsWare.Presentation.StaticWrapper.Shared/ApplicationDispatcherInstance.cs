using System.ComponentModel.Composition;
using System.Threading;
using System.Windows.Threading;

namespace KsWare.Presentation.StaticWrapper
{
	/// <summary>
	/// Class ApplicationDispatcherInstance. Gets access to the application dispatcher.
	/// </summary>
	[Export(typeof(IApplicationDispatcher)),PartCreationPolicy(CreationPolicy.Shared)]
	public class ApplicationDispatcherInstance : IApplicationDispatcher
	{
		/// <inheritdoc />
		public ApplicationDispatcherExtender Do => ApplicationDispatcher.Do;

		//		public bool InvokeRequired => System.Windows.Threading.Dispatcher.CurrentDispatcher != AssemblyBootstrapper.Application_Dispatcher;

		/// <inheritdoc />
		public bool InvokeRequired => CurrentDispatcher.CheckAccess() == false;  // CheckAccess returns true if you're on the dispatcher thread

		/// <inheritdoc />
		public Dispatcher CurrentDispatcher => AssemblyBootstrapper.Application_Dispatcher;

		/// <inheritdoc />
		public Thread Thread => CurrentDispatcher.Thread;

		/// <inheritdoc />
		public bool CheckAccess() => CurrentDispatcher.CheckAccess();
	}
}