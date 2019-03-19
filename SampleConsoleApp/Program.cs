using System.IO;
using System.Threading.Tasks;
using VoiceTextWebAPI.Client;

namespace SampleConsoleApp
{
    class Program
    {
        static async Task Main()
        {
            var client = new VoiceTextClient
            {
                APIKey = "{your API key here.}",
                Speaker = Speaker.Haruka,
                Emotion = Emotion.Happiness,
                EmotionLevel = EmotionLevel.High,
                Volume = 50,
                Speed = 120,
                Pitch = 120,
                Format = Format.WAV
            };
            var bytes = await client.GetVoiceAsync("こんにちは。");
            File.WriteAllBytes(".\\result.wav", bytes);
        }
    }
}
