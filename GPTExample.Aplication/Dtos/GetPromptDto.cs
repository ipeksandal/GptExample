namespace GPTExample.Aplication.Dtos;

public class GetPromptDto
{
    public string PromptText { get; set; }
    public string ResponseText { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
}