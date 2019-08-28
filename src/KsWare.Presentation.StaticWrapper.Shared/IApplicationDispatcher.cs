namespace KsWare.Presentation.StaticWrapper
{
	/// <summary>
	/// Interface IApplicationDispatcher.
	/// </summary>
	public interface IApplicationDispatcher : IDispatcher
	{
		/// <summary>
		/// The "Do" extender.
		/// </summary>
		ApplicationDispatcherExtender Do { get; }

		/// <summary>
		/// Gets a value indicating whether the caller must call an invoke method when making method calls because the caller is not on the UI thread.
		/// </summary>
		bool InvokeRequired { get; }
	}
}