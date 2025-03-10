namespace blazing_resume.models;

public sealed class WorkExperience
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string Url { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Summary { get; set; }
    public List<string> Highlights { get; set; }
}
