using GPTExample.Aplication;
using GPTExample.Aplication.Dtos;
using GptExapmle.Domain.Entities;

namespace GptExapmle.Persistance.Services;

public class PromptService : IPromptService

{
    private readonly GPTExampleDbContext _context;
    private IPromptService _promptServiceImplementation;

    public PromptService(GPTExampleDbContext context)
    {
        _context = context;
    }

    public void Add(AddPromptDto addPromptDto)
    {
        _context.Prompts.Add(new GPTPrompt
        {
            PromptText = addPromptDto.PromptText,
            CreatedBy = addPromptDto.CreatedBy

        });
        _context.SaveChanges();
    }

    public List<GetPromptDto> GetPrompts(string userId)
    {
        throw new NotImplementedException();
    }

    public List<GetPromptDto> GetAll(string userId)
    {
        return _context.Prompts
            .Where(x => x.CreatedBy == userId)
            .Select(x => new GetPromptDto
            {
                PromptText = x.PromptText,
                ResponseText = x.ResponseText,
                CreatedDate = x.CreatedDate
            }).ToList();
    }

}