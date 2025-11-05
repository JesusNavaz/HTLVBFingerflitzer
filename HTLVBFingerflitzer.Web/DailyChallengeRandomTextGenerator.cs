public class DailyChallengeRandomTextGenerator : IDailyChallengeTextGenerator
{
    private readonly string[] _texts;
    private readonly Random _random = new();

    public DailyChallengeRandomTextGenerator(IEnumerable<string> texts)
    {
        _texts = texts.ToArray();
    }

    public Task<string> GetDailyChallengeTextAsync()
    {
        if (_texts.Length == 0)
            return Task.FromResult("No challenges available.");

        int index = _random.Next(_texts.Length);
        return Task.FromResult(_texts[index]);
    }
}