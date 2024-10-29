using Microsoft.SemanticKernel;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

var builder = Kernel.CreateBuilder();

builder.AddAzureOpenAIChatCompletion("gpt-4o",
    "https://luiscocoaiservice.openai.azure.com/",
    "",
    "gpt-4o");

builder.Services.AddLogging(c => c.AddConsole().SetMinimumLevel(LogLevel.Trace));

var kernel = builder.Build();

// Example 1. Invoke the kernel with a prompt and display the result
Console.WriteLine(await kernel.InvokePromptAsync("What color is the sky?"));
Console.WriteLine();