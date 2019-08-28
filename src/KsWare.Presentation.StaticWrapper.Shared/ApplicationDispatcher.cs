using System.ComponentModel;
using System.Threading;
using System.Windows.Threading;

namespace KsWare.Presentation.StaticWrapper
{
	/// <summary>
	/// Class ApplicationDispatcher. Gets access to the application dispatcher.
	/// </summary>
	public static class ApplicationDispatcher
	{
		/// <summary>
		/// The "Do" extender.
		/// </summary>
		public static ApplicationDispatcherExtender Do { get; } = new ApplicationDispatcherExtender();

		/// <summary>Gets the <see cref="T:System.Windows.Threading.Dispatcher" /> for the thread currently executing and creates a new <see cref="T:System.Windows.Threading.Dispatcher" /> if one is not already associated with the thread. </summary>
		/// <returns>The dispatcher associated with the current thread.</returns>
		public static Dispatcher CurrentDispatcher => AssemblyBootstrapper.Application_Dispatcher;

		/// <summary>Gets the thread this <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <returns>The thread.</returns>
		public static Thread Thread { get; }

		/// <summary>Determines whether the calling thread is the thread associated with this <see cref="T:System.Windows.Threading.Dispatcher" />. </summary>
		/// <returns>
		/// <see langword="true" /> if the calling thread is the thread associated with this <see cref="T:System.Windows.Threading.Dispatcher" />; otherwise, <see langword="false" />.</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool CheckAccess() => CurrentDispatcher.CheckAccess();

	}
}