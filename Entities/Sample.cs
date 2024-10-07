namespace CardWise.Entities;

public class Sample
{
	public Guid Id { get; set; }
	public string Example {  get; set; }
	
	public Guid WordId { get; set; }
	public Word Word { get; set; }
}