namespace Automapper12
{
	public sealed class UpdateDivisionCommand : CreateOrUpdateDivisionCommandBase
	{
		public int DivisionId { get; set; }
	}
}
