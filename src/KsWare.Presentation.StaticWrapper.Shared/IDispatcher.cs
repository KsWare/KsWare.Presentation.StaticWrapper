using System.ComponentModel;
using System.Threading;
using System.Windows.Threading;

namespace KsWare.Presentation.StaticWrapper {

	public interface IDispatcher {

		/// <summary>Gets the <see cref="T:System.Windows.Threading.Dispatcher" /> for the thread currently executing and creates a new <see cref="T:System.Windows.Threading.Dispatcher" /> if one is not already associated with the thread. </summary>
		/// <returns>The dispatcher associated with the current thread.</returns>
		Dispatcher CurrentDispatcher { get; }
//
//		/// <summary>Gets the <see cref="T:System.Windows.Threading.Dispatcher" /> for the specified thread. </summary>
//		/// <param name="thread">The thread to obtain the <see cref="T:System.Windows.Threading.Dispatcher" /> from.</param>
//		/// <returns>The dispatcher for <paramref name="thread" />.</returns>
//		Dispatcher FromThread(Thread thread);

		/// <summary>Gets the thread this <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <returns>The thread.</returns>
		Thread Thread { get; }

		/// <summary>Determines whether the calling thread is the thread associated with this <see cref="T:System.Windows.Threading.Dispatcher" />. </summary>
		/// <returns>
		/// <see langword="true" /> if the calling thread is the thread associated with this <see cref="T:System.Windows.Threading.Dispatcher" />; otherwise, <see langword="false" />.</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		bool CheckAccess();

//		/// <summary>Determines whether the calling thread has access to this <see cref="T:System.Windows.Threading.Dispatcher" />. </summary>
//		/// <exception cref="T:System.InvalidOperationException">The calling thread does not have access to this <see cref="T:System.Windows.Threading.Dispatcher" />.</exception>
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		void VerifyAccess();
//
//		/// <summary>Initiates shutdown of the <see cref="T:System.Windows.Threading.Dispatcher" /> asynchronously. </summary>
//		/// <param name="priority">The priority at which to begin shutting down the dispatcher.</param>
//		[SecurityCritical]
//		void BeginInvokeShutdown(DispatcherPriority priority);
//
//		/// <summary>Initiates the shutdown process of the <see cref="T:System.Windows.Threading.Dispatcher" /> synchronously.</summary>
//		[SecurityCritical]
//		void InvokeShutdown();
//
//
//		/// <summary>Determines whether the <see cref="T:System.Windows.Threading.Dispatcher" /> is shutting down. </summary>
//		/// <returns>
//		/// <see langword="true" /> if the <see cref="T:System.Windows.Threading.Dispatcher" /> has started shutting down; otherwise, <see langword="false" />.</returns>
//		bool HasShutdownStarted { get; }
//
//		/// <summary>Determines whether the <see cref="T:System.Windows.Threading.Dispatcher" /> has finished shutting down.</summary>
//		/// <returns>
//		/// <see langword="true" /> if the dispatcher has finished shutting down; otherwise, <see langword="false" />.</returns>
//		bool HasShutdownFinished { get; }
//
//		/// <summary>Occurs when the <see cref="T:System.Windows.Threading.Dispatcher" /> begins to shut down. </summary>
//		event EventHandler ShutdownStarted;
//
//		/// <summary>Occurs when the <see cref="T:System.Windows.Threading.Dispatcher" /> finishes shutting down. </summary>
//		event EventHandler ShutdownFinished;
//
//
//		/// <summary>Enters an execute loop.</summary>
//		/// <param name="frame">The frame for the dispatcher to process.</param>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="frame" /> is <see langword="null" />.</exception>
//		/// <exception cref="T:System.InvalidOperationException">
//		/// <see cref="P:System.Windows.Threading.Dispatcher.HasShutdownFinished" /> is <see langword="true" />-or-
//		/// <paramref name="frame" /> is running on a different <see cref="T:System.Windows.Threading.Dispatcher" />.-or-Dispatcher processing has been disabled.</exception>
//		[SecurityCritical]
//		[UIPermission(SecurityAction.LinkDemand, Unrestricted = true)]
//		void PushFrame(DispatcherFrame frame);
//
//		/// <summary>Requests that all frames exit, including nested frames.</summary>
//		[SecurityCritical]
//		void ExitAllFrames();
//
//		/// <summary>Creates an awaitable object that asynchronously yields control back to the current dispatcher and provides an opportunity for the dispatcher to process other events.</summary>
//		/// <returns>An awaitable object that asynchronously yields control back to the current dispatcher and provides an opportunity for the dispatcher to process other events.</returns>
//		DispatcherPriorityAwaitable Yield();
//
//		/// <summary>Creates an awaitable object that asynchronously yields control back to the current dispatcher and provides an opportunity for the dispatcher to process other events.  The work that occurs when control returns to the code awaiting the result of this method is scheduled with the specified priority.</summary>
//		/// <param name="priority">The priority at which to schedule the continuation.</param>
//		/// <returns>An awaitable object that asynchronously yields control back to the current dispatcher and provides an opportunity for the dispatcher to process other events.</returns>
//		DispatcherPriorityAwaitable Yield(DispatcherPriority priority);
//
//		/// <summary>Executes the specified delegate asynchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="method">The delegate to a method that takes no arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <returns>An object, which is returned immediately after <see cref="Dispatcher.BeginInvoke" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		DispatcherOperation BeginInvoke(
//			DispatcherPriority priority,
//			Delegate method);
//
//		/// <summary>Executes the specified delegate asynchronously at the specified priority and with the specified argument on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="method">A delegate to a method that takes one argument, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="arg">The object to pass as an argument to the specified method.</param>
//		/// <returns>An object, which is returned immediately after <see cref="Dispatcher.BeginInvoke" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		DispatcherOperation BeginInvoke(
//			DispatcherPriority priority,
//			Delegate method,
//			object arg);
//
//		/// <summary>Executes the specified delegate asynchronously at the specified priority and with the specified array of arguments on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="arg">The object to pass as an argument to the specified method.</param>
//		/// <param name="args">An array of objects to pass as arguments to the specified method.</param>
//		/// <returns>An object, which is returned immediately after <see cref="Dispatcher.BeginInvoke" /> is called, that can be used to interact with the delegate as it is pending execution in the <see cref="T:System.Windows.Threading.Dispatcher" /> queue.</returns>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <see cref="T:System.Windows.Threading.DispatcherPriority" /> is not a valid priority.</exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		DispatcherOperation BeginInvoke(
//			DispatcherPriority priority,
//			Delegate method,
//			object arg,
//			params object[] args);
//
//		/// <summary>Executes the specified delegate asynchronously with the specified arguments on the thread that the <see cref="T:System.Windows.Threading.Dispatcher" /> was created on.</summary>
//		/// <param name="method">The delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
//		/// <returns>An object, which is returned immediately after <see cref="Dispatcher.BeginInvoke" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		DispatcherOperation BeginInvoke(Delegate method, params object[] args);
//
//		/// <summary>Executes the specified delegate asynchronously with the specified arguments, at the specified priority, on the thread that the <see cref="T:System.Windows.Threading.Dispatcher" /> was created on.</summary>
//		/// <param name="method">The delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
//		/// <returns>An object, which is returned immediately after <see cref="Dispatcher.BeginInvoke" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		DispatcherOperation BeginInvoke(
//			Delegate method,
//			DispatcherPriority priority,
//			params object[] args);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		void Invoke(Action callback);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		void Invoke(Action callback, DispatcherPriority priority);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <param name="cancellationToken">An object that indicates whether to cancel the action.</param>
//		void Invoke(
//			Action callback,
//			DispatcherPriority priority,
//			CancellationToken cancellationToken);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <param name="cancellationToken">An object that indicates whether to cancel the action.</param>
//		/// <param name="timeout">The minimum amount of time to wait for the operation to start.</param>
//		[SecuritySafeCritical]
//		void Invoke(
//			Action callback,
//			DispatcherPriority priority,
//			CancellationToken cancellationToken,
//			TimeSpan timeout);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		TResult Invoke<TResult>(Func<TResult> callback);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <param name="cancellationToken">An object that indicates whether to cancel the operation.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		TResult Invoke<TResult>(
//			Func<TResult> callback,
//			DispatcherPriority priority,
//			CancellationToken cancellationToken);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <param name="cancellationToken">An object that indicates whether to cancel the operation.</param>
//		/// <param name="timeout">The minimum amount of time to wait for the operation to start.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		[SecuritySafeCritical]
//		TResult Invoke<TResult>(
//			Func<TResult> callback,
//			DispatcherPriority priority,
//			CancellationToken cancellationToken,
//			TimeSpan timeout);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> asynchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <returns>An object, which is returned immediately after <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync(System.Action)" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		DispatcherOperation InvokeAsync(Action callback);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> asynchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <returns>An object, which is returned immediately after <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync(System.Action,System.Windows.Threading.DispatcherPriority)" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		DispatcherOperation InvokeAsync(
//			Action callback,
//			DispatcherPriority priority);
//
//		/// <summary>Executes the specified <see cref="T:System.Action" /> asynchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <param name="cancellationToken">An object that indicates whether to cancel the action.</param>
//		/// <returns>An object, which is returned immediately after <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync(System.Action,System.Windows.Threading.DispatcherPriority,System.Threading.CancellationToken)" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		[SecuritySafeCritical]
//		DispatcherOperation InvokeAsync(
//			Action callback,
//			DispatcherPriority priority,
//			CancellationToken cancellationToken);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> asynchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		/// <returns>An object, which is returned immediately after <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync``1(System.Func{``0})" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		DispatcherOperation<TResult> InvokeAsync<TResult>(
//			Func<TResult> callback);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> asynchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		/// <returns>An object, which is returned immediately after <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync``1(System.Func{``0},System.Windows.Threading.DispatcherPriority)" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		DispatcherOperation<TResult> InvokeAsync<TResult>(
//			Func<TResult> callback,
//			DispatcherPriority priority);
//
//		/// <summary>Executes the specified <see cref="T:System.Func`1" /> synchronously at the specified priority on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="callback">A delegate to invoke through the dispatcher.</param>
//		/// <param name="priority">The priority that determines in what order the specified callback is invoked relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" />.</param>
//		/// <param name="cancellationToken">An object that indicates whether to cancel the operation.</param>
//		/// <typeparam name="TResult">The return value type of the specified delegate.</typeparam>
//		/// <returns>An object, which is returned immediately after <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync``1(System.Func{``0},System.Windows.Threading.DispatcherPriority,System.Threading.CancellationToken)" /> is called, that can be used to interact with the delegate as it is pending execution in the event queue.</returns>
//		[SecuritySafeCritical]
//		DispatcherOperation<TResult> InvokeAsync<TResult>(
//			Func<TResult> callback,
//			DispatcherPriority priority,
//			CancellationToken cancellationToken);
//
//		/// <summary>Executes the specified delegate synchronously at the specified priority on the thread on which the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with. </summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="method">A delegate to a method that takes no arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		/// <exception cref="T:System.ArgumentException">
//		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid priority.</exception>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		object Invoke(DispatcherPriority priority, Delegate method);
//
//		/// <summary>Executes the specified delegate at the specified priority with the specified argument synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="method">A delegate to a method that takes one argument, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="arg">An object to pass as an argument to the given method.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		/// <exception cref="T:System.ArgumentException">
//		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid priority.</exception>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		object Invoke(DispatcherPriority priority, Delegate method, object arg);
//
//		/// <summary>Executes the specified delegate at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="arg">An object to pass as an argument to the given method.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		/// <exception cref="T:System.ArgumentException">
//		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid priority.</exception>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		object Invoke(
//			DispatcherPriority priority,
//			Delegate method,
//			object arg,
//			params object[] args);
//
//		/// <summary>Executes the specified delegate synchronously at the specified priority and with the specified time-out value on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> was created.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="timeout">The maximum time to wait for the operation to finish.</param>
//		/// <param name="method">The delegate to a method that takes no arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method);
//
//		/// <summary>Executes the specified delegate at the specified priority with the specified argument synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="timeout">The maximum time to wait for the operation to finish.</param>
//		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="arg">An object to pass as an argument to the given method. This can be <see langword="null" /> if no arguments are needed.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		/// <exception cref="T:System.ArgumentException">
//		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid priority.</exception>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		object Invoke(
//			DispatcherPriority priority,
//			TimeSpan timeout,
//			Delegate method,
//			object arg);
//
//		/// <summary>Executes the specified delegate at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="timeout">The maximum time to wait for the operation to finish.</param>
//		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="arg">An object to pass as an argument to the specified method.</param>
//		/// <param name="args">An array of objects to pass as arguments to the specified method. </param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		/// <exception cref="T:System.ArgumentException">
//		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
//		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
//		/// <paramref name="priority" /> is not a valid <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
//		/// <exception cref="T:System.ArgumentNullException">
//		/// <paramref name="method" /> is <see langword="null" />. </exception>
//		[Browsable(false)]
//		[EditorBrowsable(EditorBrowsableState.Never)]
//		object Invoke(
//			DispatcherPriority priority,
//			TimeSpan timeout,
//			Delegate method,
//			object arg,
//			params object[] args);
//
//		/// <summary>Executes the specified delegate with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		object Invoke(Delegate method, params object[] args);
//
//		/// <summary>Executes the specified delegate at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		object Invoke(Delegate method, DispatcherPriority priority, params object[] args);
//
//		/// <summary>Executes the specified delegate within the designated time span at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="timeout">The maximum amount of time to wait for the operation to complete.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		object Invoke(Delegate method, TimeSpan timeout, params object[] args);
//
//		/// <summary>Executes the specified delegate within the designated time span at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
//		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
//		/// <param name="timeout">The maximum amount of time to wait for the operation to complete.</param>
//		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
//		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
//		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
//		object Invoke(
//			Delegate method,
//			TimeSpan timeout,
//			DispatcherPriority priority,
//			params object[] args);
//
//
//		/// <summary>Disables processing of the <see cref="T:System.Windows.Threading.Dispatcher" /> queue.</summary>
//		/// <returns>A structure used to re-enable dispatcher processing.</returns>
//		DispatcherProcessingDisabled DisableProcessing();
//
//
//		/// <summary>Gets the collection of hooks that provide additional event information about the <see cref="T:System.Windows.Threading.Dispatcher" />. </summary>
//		/// <returns>The hooks associated with this <see cref="T:System.Windows.Threading.Dispatcher" />. </returns>
//		[EditorBrowsable(EditorBrowsableState.Advanced)]
//		DispatcherHooks Hooks
//		{
//			[SecurityCritical, UIPermission(SecurityAction.LinkDemand, Unrestricted = true)]
//			get;
//		}
//
//		/// <summary>Occurs when a thread exception is thrown and uncaught during execution of a delegate by way of <see cref="Dispatcher.Invoke" /> or <see cref="Dispatcher.BeginInvoke" /> when in the filter stage. </summary>
//		event DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter;
//
//		/// <summary>Occurs when a thread exception is thrown and uncaught during execution of a delegate by way of <see cref="Dispatcher.Invoke" /> or <see cref="Dispatcher.BeginInvoke" />.</summary>
//		event DispatcherUnhandledExceptionEventHandler UnhandledException;

	}

}
