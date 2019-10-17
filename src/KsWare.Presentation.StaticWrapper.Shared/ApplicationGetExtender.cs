using System;
using System.Windows.Interop;

namespace KsWare.Presentation.StaticWrapper {

	public sealed class ApplicationGetExtender {

		public IApplication Application { get; }

		public ApplicationGetExtender(ApplicationWrapper applicationWrapper) {
			Application = applicationWrapper;
		}

		public IntPtr MainWindowHandle => new WindowInteropHelper(Application.MainWindow).Handle;

	}

}
