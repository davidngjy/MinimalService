namespace MinimalService.Web.Models.Responses;

public record RandomStringResponse(string Prefix, string Random)
{
    public string Value => Prefix + Random;
}
