using System;
using System.Collections;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;

namespace KsWare.Presentation.StaticWrapper
{
	//[Export(typeof(IApplication)),PartCreationPolicy(CreationPolicy.Shared)]
	public class ApplicationWrapper : IApplication
	{
		private readonly Application _current;
		private readonly WindowCollection _windows;
		private readonly Window _mainWindow;
		private readonly ShutdownMode _shutdownMode;
		private readonly ResourceDictionary _resources;
		private readonly Uri _startupUri;
		private readonly IDictionary _properties;
		private readonly System.Reflection.Assembly _resourceAssembly;
		private readonly Dispatcher _dispatcher;

		public ApplicationWrapper(Application current)
		{
			_current = current ?? throw new ArgumentNullException(nameof(current));
			_dispatcher = _current.Dispatcher;
		}

		public ApplicationWrapper(Application current, Dispatcher dispatcher)
		{
			_current = current ?? throw new ArgumentNullException(nameof(current));
			_dispatcher = dispatcher ?? throw new ArgumentNullException(nameof(current));
		}

		public ApplicationWrapper()
		{
		}

		public Dispatcher Dispatcher
		{
			get
			{
				if (_dispatcher != null) return _dispatcher;
				if (Current != null) return Current.Dispatcher;
				
				throw new NotImplementedException(); 
				// TODO create Dispatcher for case Current == null

			}
		}

		public IntPtr MainWindowHandle => new WindowInteropHelper(MainWindow).Handle;


		public int Run() => throw new NotImplementedException();

		public int Run(Window window) => throw new NotImplementedException();

		public void Shutdown() => Current.Shutdown();

		public void Shutdown(int exitCode) => Current.Shutdown(exitCode);

		public object FindResource(object resourceKey) => Current.FindResource(resourceKey);

		public object TryFindResource(object resourceKey) => Current.TryFindResource(resourceKey);
		
		public Application Current => _current ?? AssemblyBootstrapper.Application;

		public WindowCollection Windows => Current?.Windows;

		public Window MainWindow { get => Current?.MainWindow; set => Current.MainWindow = value; }

		public ShutdownMode ShutdownMode { get => Current.ShutdownMode; set => Current.ShutdownMode = value; }

		public ResourceDictionary Resources { get => Current.Resources; set => Current.Resources = value; }

		public Uri StartupUri { get => Current.StartupUri; set => Current.StartupUri = value; }

		public IDictionary Properties => Current.Properties;

		public System.Reflection.Assembly ResourceAssembly { get => Application.ResourceAssembly; set => Application.ResourceAssembly = value; }

//		public event StartupEventHandler Startup;
//		public event ExitEventHandler Exit;
//		public event EventHandler Activated;
//		public event EventHandler Deactivated;
//		public event SessionEndingCancelEventHandler SessionEnding;
//		public event DispatcherUnhandledExceptionEventHandler DispatcherUnhandledException;
//		public event NavigatingCancelEventHandler Navigating;
//		public event NavigatedEventHandler Navigated;
//		public event NavigationProgressEventHandler NavigationProgress;
//		public event NavigationFailedEventHandler NavigationFailed;
//		public event LoadCompletedEventHandler LoadCompleted;
//		public event NavigationStoppedEventHandler NavigationStopped;
//		public event FragmentNavigationEventHandler FragmentNavigation;

//		public void OnStartup(Action<StartupEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnExit(Action<ExitEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnActivated(Action<EventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnDeactivated(Action<EventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnSessionEnding(Action<SessionEndingCancelEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnNavigating(Action<NavigatingCancelEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnNavigated(Action<NavigationEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnNavigationProgress(Action<NavigationProgressEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnNavigationFailed(Action<NavigationFailedEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnLoadCompleted(Action<NavigationEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnNavigationStopped(Action<NavigationEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
//
//		public void OnFragmentNavigation(Action<FragmentNavigationEventArgs> e)
//		{
//			throw new NotImplementedException();
//		}
	}
}
