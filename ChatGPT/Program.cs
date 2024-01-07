using OpenAI_API;
using OpenAI_API.Models;

var apiKey = Environment.GetEnvironmentVariable("ProxyAPI_API_KEY");
var proxyApiUrl = "https://api.proxyapi.ru/openai/v1/chat/completions";

OpenAIAPI api = new OpenAIAPI(apiKey);
api.ApiUrlFormat = proxyApiUrl;

var chat = api.Chat.CreateConversation();
chat.Model = Model.ChatGPTTurbo_16k;

var request = "Подушка это животное?";

Console.WriteLine($"U: {request}");

chat.AppendUserInput(request);

string response = await chat.GetResponseFromChatbotAsync();
Console.WriteLine($"C: {response}");