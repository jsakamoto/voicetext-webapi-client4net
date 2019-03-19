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

Release Note
------------

- **v.3.0** - [Breaking Change] "EmotionLevel" range is more precise. 
- **v.2.0.0.1** - support .NET Standard 2.0
- **v.2.0** - [Breaking Change] Remove aac format. 
- **v.1.4** - Add mp3 format.
- **v.1.3** - Can chose voice file format from wav/ogg/aac.
- **v.1.2** - Add speaker "Bear"(Berserk Bear)!
- **v.1.1** - Add speaker "Santa"(Santa Claus)!
- **v.1.0** - First release.

License
-------
Copyright (c) 2014-2019 @jsakamoto. Licensed under the MIT license.
