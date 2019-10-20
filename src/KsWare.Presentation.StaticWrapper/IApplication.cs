using System;
using System.Collections;
using System.Security;
using System.Windows;

namespace KsWare.Presentation.StaticWrapper {

	public interface IApplication {

		ApplicationDoExtender Do { get; }
		ApplicationGetExtender Get { get; }

		int Run();

		/// <summary>Starts a Windows Presentation Foundation (WPF) application and opens the specified window.</summary>
		/// <param name="window">A <see cref="T:System.Windows.Window" /> that opens automatically when an application starts.</param>
		/// <returns>The <see cref="T:System.Int32" /> application exit code that is returned to the operating system when the application shuts down. By default, the exit code value is 0.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		/// <see cref="M:System.Windows.Application.Run" /> is called from a browser-hosted application (for example, an XAML browser application (XBAP)).</exception>
		[SecurityCritical]
		int Run(Window window);

		/// <summary>Shuts down an application.</summary>
		void Shutdown();

		/// <summary>Shuts down an application that returns the specified exit code to the operating system.</summary>
		/// <param name="exitCode">An integer exit code for an application. The default exit code is 0.</param>
		[SecurityCritical]
		void Shutdown(int exitCode);

		/// <summary>Searches for a user interface (UI) resource, such as a <see cref="T:System.Windows.Style" /> or <see cref="T:System.Windows.Media.Brush" />, with the specified key, and throws an exception if the requested resource is not found (see XAML Resources).</summary>
		/// <param name="resourceKey">The name of the resource to find.</param>
		/// <returns>The requested resource object. If the requested resource is not found, a <see cref="T:System.Windows.ResourceReferenceKeyNotFoundException" /> is thrown.</returns>
		/// <exception cref="T:System.Windows.ResourceReferenceKeyNotFoundException">The resource cannot be found.</exception>
		object FindResource(object resourceKey);

		/// <summary>Searches for the specified resource.</summary>
		/// <param name="resourceKey">The name of the resource to find.</param>
		/// <returns>The requested resource object. If the requested resource is not found, a null reference is returned.</returns>
		object TryFindResource(object resourceKey);

		/// <summary>Gets the <see cref="T:System.Windows.Application" /> object for the current <see cref="T:System.AppDomain" />.</summary>
		/// <returns>The <see cref="T:System.Windows.Application" /> object for the current <see cref="T:System.AppDomain" />.</returns>
		Application Current { get; }

		/// <summary>Gets the instantiated windows in an application. </summary>
		/// <returns>A <see cref="T:System.Windows.WindowCollection" /> that contains references to all window objects in the current <see cref="T:System.AppDomain" />.</returns>
		WindowCollection Windows { get; }

		/// <summary>Gets or sets the main window of the application.</summary>
		/// <returns>A <see cref="T:System.Windows.Window" /> that is designated as the main application window.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		/// <see cref="P:System.Windows.Application.MainWindow" /> is set from an application that's hosted in a browser, such as an XAML browser applications (XBAPs).</exception>
		Window MainWindow { get; set; }

		/// <summary>Gets or sets the condition that causes the <see cref="M:System.Windows.Application.Shutdown" /> method to be called.</summary>
		/// <returns>A <see cref="T:System.Windows.ShutdownMode" /> enumeration value. The default value is <see cref="F:System.Windows.ShutdownMode.OnLastWindowClose" />.</returns>
		ShutdownMode ShutdownMode { get; set; }

		/// <summary>Gets or sets a collection of application-scope resources, such as styles and brushes.</summary>
		/// <returns>A <see cref="T:System.Windows.ResourceDictionary" /> object that contains zero or more application-scope resources.</returns>
		ResourceDictionary Resources { get; set; }

//		ResourceDictionary IHaveResources.Resources {get;set;}

//		bool IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);

		/// <summary>Gets or sets a UI that is automatically shown when an application starts.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that refers to the UI that automatically opens when an application starts.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		/// <see cref="P:System.Windows.Application.StartupUri" /> is set with a value of null.</exception>
		Uri StartupUri { get; set; }

		/// <summary>Gets a collection of application-scope properties.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> that contains the application-scope properties.</returns>
		IDictionary Properties { get; }

		/// <summary>Gets or sets the <see cref="T:System.Reflection.Assembly" /> that provides the pack uniform resource identifiers (URIs) for resources in a WPF application.</summary>
		/// <returns>A reference to the <see cref="T:System.Reflection.Assembly" /> that provides the pack uniform resource identifiers (URIs) for resources in a WPF application.</returns>
		/// <exception cref="T:System.InvalidOperationException">A WPF application has an entry assembly, or <see cref="P:System.Windows.Application.ResourceAssembly" /> has already been set.</exception>
		System.Reflection.Assembly ResourceAssembly { get; set; }

//		/// <summary>Occurs when the <see cref="M:System.Windows.Application.Run" /> method of the <see cref="T:System.Windows.Application" /> object is called.</summary>
//		event StartupEventHandler Startup;
//
//		/// <summary>Occurs just before an application shuts down, and cannot be canceled.</summary>
//		event ExitEventHandler Exit;
//
//		/// <summary>Occurs when an application becomes the foreground application.</summary>
//		event EventHandler Activated;
//
//		/// <summary>Occurs when an application stops being the foreground application.</summary>
//		event EventHandler Deactivated;
//
//		/// <summary>Occurs when the user ends the Windows session by logging off or shutting down the operating system.</summary>
//		event SessionEndingCancelEventHandler SessionEnding;
//
//		/// <summary>Occurs when an exception is thrown by an application but not handled.</summary>
//		event DispatcherUnhandledExceptionEventHandler DispatcherUnhandledException;
//
//		/// <summary>Occurs when a new navigation is requested by a navigator in the application.</summary>
//		event NavigatingCancelEventHandler Navigating;
//
//		/// <summary>Occurs when the content that is being navigated to by a navigator in the application has been found, although it may not have completed loading.</summary>
//		event NavigatedEventHandler Navigated;
//
//		/// <summary>Occurs periodically during a download that is being managed by a navigator in the application to provide navigation progress information.</summary>
//		event NavigationProgressEventHandler NavigationProgress;
//
//		/// <summary>Occurs when an error occurs while a navigator in the application is navigating to the requested content.</summary>
//		event NavigationFailedEventHandler NavigationFailed;
//
//		/// <summary>Occurs when content that was navigated to by a navigator in the application has been loaded, parsed, and has begun rendering.</summary>
//		event LoadCompletedEventHandler LoadCompleted;
//
//		/// <summary>Occurs when the <see langword="StopLoading" /> method of a navigator in the application is called, or when a new navigation is requested by a navigator while a current navigation is in progress.</summary>
//		event NavigationStoppedEventHandler NavigationStopped;
//
//		/// <summary>Occurs when a navigator in the application begins navigation to a content fragment, Navigation occurs immediately if the desired fragment is in the current content, or after the source XAML content has been loaded if the desired fragment is in different content.</summary>
//		event FragmentNavigationEventHandler FragmentNavigation;

//		/// <summary>Raises the <see cref="E:System.Windows.Application.Startup" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
//		void OnStartup(Action<StartupEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.Exit" /> event.</summary>
//		/// <param name="e">An <see cref="T:System.Windows.ExitEventArgs" /> that contains the event data.</param>
//		void OnExit(Action<ExitEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.Activated" /> event.</summary>
//		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
//		void OnActivated(Action<EventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.Deactivated" /> event.</summary>
//		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
//		void OnDeactivated(Action<EventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.SessionEnding" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.SessionEndingCancelEventArgs" /> that contains the event data.</param>
//		void OnSessionEnding(Action<SessionEndingCancelEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.Navigating" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigatingCancelEventArgs" /> that contains the event data.</param>
//		void OnNavigating(Action<NavigatingCancelEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.Navigated" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationEventArgs" /> that contains the event data.</param>
//		void OnNavigated(Action<NavigationEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.NavigationProgress" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationProgressEventArgs" /> that contains the event data.</param>
//		void OnNavigationProgress(Action<NavigationProgressEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.NavigationFailed" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationFailedEventArgs" /> that contains the event data.</param>
//		void OnNavigationFailed(Action<NavigationFailedEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.LoadCompleted" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationEventArgs" /> that contains the event data.</param>
//		void OnLoadCompleted(Action<NavigationEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.NavigationStopped" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationEventArgs" /> that contains the event data. </param>
//		void OnNavigationStopped(Action<NavigationEventArgs> e);
//
//		/// <summary>Raises the <see cref="E:System.Windows.Application.FragmentNavigation" /> event.</summary>
//		/// <param name="e">A <see cref="T:System.Windows.Navigation.FragmentNavigationEventArgs" /> that contains the event data.</param>
//		void OnFragmentNavigation(Action<FragmentNavigationEventArgs> e);

	}

}
