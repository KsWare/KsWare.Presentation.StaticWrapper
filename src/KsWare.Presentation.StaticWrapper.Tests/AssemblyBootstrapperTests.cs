using Moq;
using NUnit.Framework;

namespace KsWare.Presentation.StaticWrapper.Tests
{
	[TestFixture]
	public class AssemblyBootstrapperTests
	{
		[Test]
		public void Initialize()
		{
			var applicationMock = new Mock<IApplication>();
			var applicationDispatcherMock = new Mock<IApplicationDispatcher>();

			AssemblyBootstrapper.ApplicationWrapper = applicationMock.Object;
			AssemblyBootstrapper.ApplicationDispatcher = applicationDispatcherMock.Object;
			AssemblyBootstrapper.Initialize();
		}
	}
}
