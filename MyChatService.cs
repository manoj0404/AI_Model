public class MyChatService
{
    private readonly ITextGenerationService _textGeneration;
    public MyChatService(ITextGenerationService textGeneration)
    {
        _textGeneration = textGeneration;
    }
    public async Task<string> AskAsync(string prompt)
    {
        var result = await _textGeneration.GenerateTextAsync(prompt);
        return result.GeneratedText;
    }
}
