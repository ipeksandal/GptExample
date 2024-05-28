using GPTExample.Aplication.Dtos;

namespace GPTExample.Aplication;

public interface IPromptService
{
    void Add(AddPromptDto addPromptDto);
    List<GetPromptDto> GetPrompts(string userId);
}