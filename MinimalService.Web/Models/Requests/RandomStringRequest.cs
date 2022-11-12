using FastEndpoints;
using FluentValidation;

namespace MinimalService.Web.Models.Requests;

public record RandomStringRequest()
{
    [QueryParam]
    public string? Prefix { get; init; }
}

public class RandomStringRequestValidator : Validator<RandomStringRequest>
{
    public RandomStringRequestValidator()
    {
        RuleFor(x => x.Prefix)
            .NotNull();
    }
}
