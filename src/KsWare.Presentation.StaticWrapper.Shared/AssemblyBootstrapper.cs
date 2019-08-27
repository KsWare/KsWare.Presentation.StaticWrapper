using System;
using System.Windows;
using System.Windows.Threading;
using JetBrains.Annotations;

namespace KsWare.Presentation.StaticWrapper
{
	public static class AssemblyBootstrapper
	{
		public static Application Application { get; set; } = System.Windows.Application.Current;


		public static Dispatcher Application_Dispatcher { get; set; } = System.Windows.Application.Current?.Dispatcher;

		public static IApplication ApplicationWrapper { get; set; } = new ApplicationWrapper();

		public static IApplicationDispatcher ApplicationDispatcher { get; set; } = new ApplicationDispatcherInstance();

		public static void Initialize()
		{
//			Application = System.Windows.Application.Current ?? throw new InvalidOperationException("Application.Current is null!");
//			Application_Dispatcher = Application.Dispatcher ?? throw new InvalidOperationException("Application.Current.Dispatcher is null!");
			if(Application==null || ApplicationWrapper == null) throw new InvalidOperationException("Application is null!");
			if(ApplicationDispatcher==null) throw new InvalidOperationException("ApplicationDispatcher is null!");
		}

		public static void Initialize([NotNull] Application application, [NotNull] Dispatcher applicationDispatcher)
		{
			Application = application ?? throw new ArgumentNullException(nameof(application));
			Application_Dispatcher = applicationDispatcher ?? throw new ArgumentNullException(nameof(applicationDispatcher));
		}

		public static void Initialize([NotNull] IApplication application)
		{
			ApplicationWrapper = application ?? throw new ArgumentNullException(nameof(application));
		}
	}
}
