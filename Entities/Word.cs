namespace CardWise.Entities;

public class Word
{
	public Guid Id { get; set; }
	public string EngWord { get; set; }
	public string RusWord { get; set; }
	public string Description { get; set; }
	public string Image { get; set; }
	public string Category { get; set; } //ToStudy, repetition, learned
	//public byte[] Pronunciation { get; set; } //for audio storing
	public List<Sample> Samples { get; set; }
}