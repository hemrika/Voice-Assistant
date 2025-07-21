# C# Voice Assistant

A simple voice assistant in C# using Windows Speech Recognition/Synthesis APIs.

## Features
- Listens for a few basic commands: "hello", "what is the time", "exit"
- Responds using synthesized speech

## How to Use
1. Open in Visual Studio or use CLI.
2. Restore packages (System.Speech is included in .NET Framework).
3. Build and run.

## Requirements
- .NET Framework (Windows only)
- Microphone

## Notes
- Extend `choices` in Program.cs to support more commands.
- For advanced AI integration, connect to OpenAI or Azure Cognitive Services.
