using Microsoft.AspNetCore.Components.Web;

namespace BlazorNet6Demos.Client.Pages.ErrorBoundaries
{
	public class MyErrorBoundary : ErrorBoundary // ErrorBoundaryBase
	{
		protected override Task OnErrorAsync(Exception exception)
		{
			Console.WriteLine("ERROR: " + exception.Message);

			// base.OnErrorAsync(exception); ==> await ErrorBoundaryLogger.LogErrorAsync(exception);

			return Task.CompletedTask;
		}
	}
}
