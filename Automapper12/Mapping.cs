using AutoMapper;

namespace Automapper12
{
	/// <summary>
	/// The mappings profile for <see cref="Division"/>s.
	/// </summary>
	public sealed class DivisionMappings : Profile
	{
		/// <summary>
		/// The mappings for <see cref="Division"/>s.
		/// </summary>
		public DivisionMappings()
		{

			CreateMap<UpdateDivisionCommand, Division>()
				.ForMember(d => d.DivisionId, o => o.UseDestinationValue());

			CreateMap<CreateOrUpdateDivisionCommandBase, Division>()
				.ForMember(d => d.DivisionUid, o => o.UseDestinationValue())
				.ForMember(d => d.DivisionName, o => o.UseDestinationValue())
				.ForMember(d => d.ApiUrl, o => o.UseDestinationValue())
				.ForMember(d => d.IdentityServerUrl, o => o.UseDestinationValue())
				.ForMember(d => d.ClientId, o => o.UseDestinationValue())
				.ForMember(d => d.ClientSecret, o => o.UseDestinationValue())
				.ForMember(d => d.ConcurrentSessions, o => o.UseDestinationValue())
				.ForMember(d => d.IsActive, o => o.UseDestinationValue())
				.IncludeAllDerived();
		}
	}
}
