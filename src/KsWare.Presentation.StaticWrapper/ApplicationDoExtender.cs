namespace KsWare.Presentation.StaticWrapper
{
	public sealed class ApplicationDoExtender
	{
		public IApplication Application { get; }

		public ApplicationDoExtender(ApplicationWrapper applicationWrapper)
		{
			Application = applicationWrapper;
		}
	}
}