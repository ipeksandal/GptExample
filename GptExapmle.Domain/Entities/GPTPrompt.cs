namespace GptExapmle.Domain.Entities;

public class GPTPrompt : EntityBase<Guid>
{
    public string PromptText { get; set; }
    public string ResponseText { get; set; }
}