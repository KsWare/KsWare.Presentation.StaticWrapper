using System;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace KsWare.Presentation.StaticWrapper
{
	public sealed class ApplicationDispatcherExtender
	{
		private Dispatcher Dispatcher => AssemblyBootstrapper.Application_Dispatcher;
		
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