VoiceText WebAPI Client for .NET [![NuGet Package](https://img.shields.io/nuget/v/VoiceTextWebAPI.Client.svg)](https://www.nuget.org/packages/VoiceTextWebAPI.Client/)
================================

This is the clinet librray of HOYA Voice Text Web API for .NET.

Istllation
----------

You can install via nuget.org

    PM> Install-Package VoiceTextWebAPI.Client

Usage
-----

```csharp
using VoiceTextWebAPI.Client;
...
public async void btn_OnClick()
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
```

License
-------
Copyright (c) 2014-2018 @jsakamoto. Licensed under the MIT license.
