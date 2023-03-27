using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Automapper11
{
	/// <summary>
	/// The '' Division
	/// </summary>
	public sealed class Division
	{

		public int DivisionId { get; set; }

		public string DivisionUid { get; set; } = null!;

		public string DivisionName { get; set; } = null!;

		public string ApiUrl { get; set; } = null!;

		public string IdentityServerUrl { get; set; } = null!;

		public string ClientId { get; set; } = null!;

		public string ClientSecret { get; set; } = null!;

		public byte ConcurrentSessions { get; set; }

		public bool IsActive { get; set; }

		public DateTimeOffset? DateActive { get; set; }

		public DateTimeOffset _Created { get; set; }

		public string UserCreated { get; set; } = null!;

		public DateTimeOffset? _Deleted { get; set; }

		public string? UserDeleted { get; set; }

		public bool IsDeleted { get; set; }

		public DateTimeOffset? _Modified { get; set; }

		public string? UserModified { get; set; }
	}
}
