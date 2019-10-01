namespace Gradebook.Gradebooks
{
	public class RankedGradeBook : BaseGradeBook
	{
		public RankedGradeBook(string name) : base (name)
		{
			Type = Enum.GradeBookType.Ranked;
		}
	}
}
