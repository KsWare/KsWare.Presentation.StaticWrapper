using NUnit.Framework;

namespace KsWare.Presentation.StaticWrapper.Tests
{
	[TestFixture]
	public class AssemblyBootstrapperTests
	{
		[Test]
		public void Initialize()
		{
			AssemblyBootstrapper.Initialize();
		}
	}
}
