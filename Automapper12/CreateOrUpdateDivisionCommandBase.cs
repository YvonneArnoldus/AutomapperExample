namespace Automapper12
{
	public abstract class CreateOrUpdateDivisionCommandBase
	{ 
		public string DivisionUid { get; set; } = null!;

		public string DivisionName { get; set; } = null!;

		public string ApiUrl { get; set; } = null!;

		public string IdentityServerUrl { get; set; } = null!;

		public string ClientId { get; set; } = null!;

		public string ClientSecret { get; set; } = null!;

		public int ConcurrentSessions { get; set; }

		public bool IsActive { get; set; }
	}
}
