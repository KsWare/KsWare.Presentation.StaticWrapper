using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace KsWare.Presentation.StaticWrapper
{
	public sealed class ApplicationDispatcherExtender
	{
		private Dispatcher Dispatcher => AssemblyBootstrapper.Application_Dispatcher;

		#region Invoke

		/// <summary>Executes the specified delegate synchronously at the specified priority on the thread on which the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with. </summary>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="method">A delegate to a method that takes no arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		/// <paramref name="priority" /> is not a valid priority.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="method" /> is <see langword="null" />. </exception>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Invoke(DispatcherPriority priority, Delegate method) => Dispatcher.Invoke(priority, method);

		/// <summary>Executes the specified delegate at the specified priority with the specified argument synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="method">A delegate to a method that takes one argument, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="arg">An object to pass as an argument to the given method.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		/// <paramref name="priority" /> is not a valid priority.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="method" /> is <see langword="null" />. </exception>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Invoke(DispatcherPriority priority, Delegate method, object arg)
			=> Dispatcher.Invoke(priority, method, arg);

		/// <summary>Executes the specified delegate at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="arg">An object to pass as an argument to the given method.</param>
		/// <param name="args">An array of objects to pass as arguments to the given method.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		/// <paramref name="priority" /> is not a valid priority.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="method" /> is <see langword="null" />. </exception>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Invoke(DispatcherPriority priority,Delegate method,object arg,params object[] args)=> Dispatcher.Invoke(priority, method, arg, args);

		/// <summary>Executes the specified delegate synchronously at the specified priority and with the specified time-out value on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> was created.</summary>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="timeout">The maximum time to wait for the operation to finish.</param>
		/// <param name="method">The delegate to a method that takes no arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method) => Dispatcher.Invoke(priority, timeout, method);

		/// <summary>Executes the specified delegate at the specified priority with the specified argument synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="timeout">The maximum time to wait for the operation to finish.</param>
		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="arg">An object to pass as an argument to the given method. This can be <see langword="null" /> if no arguments are needed.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		/// <paramref name="priority" /> is not a valid priority.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="method" /> is <see langword="null" />. </exception>
		public object Invoke(DispatcherPriority priority,TimeSpan timeout,Delegate method,object arg) => Dispatcher.Invoke(priority, timeout, method, arg);

		/// <summary>Executes the specified delegate at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="timeout">The maximum time to wait for the operation to finish.</param>
		/// <param name="method">A delegate to a method that takes multiple arguments, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="arg">An object to pass as an argument to the specified method.</param>
		/// <param name="args">An array of objects to pass as arguments to the specified method. </param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="priority" /> is equal to <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		/// <paramref name="priority" /> is not a valid <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="method" /> is <see langword="null" />. </exception>
		public object Invoke(DispatcherPriority priority,TimeSpan timeout,Delegate method,object arg,
			params object[] args) => Dispatcher.Invoke(priority, timeout, method, arg, args);

		/// <summary>Executes the specified delegate with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		public object Invoke(Delegate method, params object[] args) => Dispatcher.Invoke(method, args);
		
		/// <summary>Executes the specified delegate at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		public object Invoke(Delegate method, DispatcherPriority priority, params object[] args) => Dispatcher.Invoke(method, priority, args);
		
		/// <summary>Executes the specified delegate within the designated time span at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="timeout">The maximum amount of time to wait for the operation to complete.</param>
		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		public object Invoke(Delegate method, TimeSpan timeout, params object[] args) => Dispatcher.Invoke(method, timeout, args);
		
		/// <summary>Executes the specified delegate within the designated time span at the specified priority with the specified arguments synchronously on the thread the <see cref="T:System.Windows.Threading.Dispatcher" /> is associated with.</summary>
		/// <param name="method">A delegate to a method that takes parameters specified in <paramref name="args" />, which is pushed onto the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue.</param>
		/// <param name="timeout">The maximum amount of time to wait for the operation to complete.</param>
		/// <param name="priority">The priority, relative to the other pending operations in the <see cref="T:System.Windows.Threading.Dispatcher" /> event queue, the specified method is invoked.</param>
		/// <param name="args">An array of objects to pass as arguments to the given method. Can be <see langword="null" />.</param>
		/// <returns>The return value from the delegate being invoked or <see langword="null" /> if the delegate has no return value.</returns>
		public object Invoke(Delegate method,TimeSpan timeout,DispatcherPriority priority,params object[] args) => Dispatcher.Invoke(method, timeout, priority, args);

		#endregion

		public void Run(Action action) => Dispatcher.Invoke(action);
		public void Run<T1>(T1 p1, Action<T1> action) => Dispatcher.Invoke(action, p1);
		public void Run<T1, T2>(T1 p1, T2 p2, Action<T1,T2> action) => Dispatcher.Invoke(action, p1, p2);

		public TResult Run<TResult>(Func<TResult> func) => Dispatcher.Invoke(func);
		public TResult Run<T1, TResult>(T1 p1, Func<T1, TResult> func) => Dispatcher.Invoke(()=>func(p1));
		public TResult Run<T1,T2, TResult>(T1 p1, T2 p2, Func<T1,T2, TResult> func) => Dispatcher.Invoke(() => func(p1,p2));

		public Task RunAsync(Action action) => Dispatcher.BeginInvoke(action).Task;
		public Task RunAsync<T1>(T1 p1, Action action) => Dispatcher.BeginInvoke(action, p1).Task;
		public Task RunAsync<T1,T2>(T1 p1,T2 p2, Action action) => Dispatcher.BeginInvoke(action, p1, p2).Task;
		
		public Task<TResult> RunAsync<TResult>(Func<TResult> func) => Dispatcher.InvokeAsync(func).Task;
		public Task<TResult> RunAsync<T1, TResult>(T1 p1, Func<T1, TResult> func) => Dispatcher.InvokeAsync(() => func(p1)).Task;
		public Task<TResult> RunAsync<T1,T2, TResult>(T1 p1, T2 p2, Func<T1,T2, TResult> func) => Dispatcher.InvokeAsync(() => func(p1, p2)).Task;

	}
}