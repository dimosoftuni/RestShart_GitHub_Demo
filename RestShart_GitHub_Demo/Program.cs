using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");
client.Authenticator = new HttpBasicAuthenticator("dimosoftuni", "token");

string url = "/repos/dimosoftuni/postman/issues";

var request = new RestRequest(url);

request.AddBody(new { title = "New Issue from RestSharp" });

var response = await client.ExecuteAsync(request, Method.Post);

Console.WriteLine("STATUS CODE " + response.StatusCode);
Console.WriteLine("STATUS CODE " + response.Content);

// var repos = JsonSerializer.Deserialize<List<Repo>>(response.Content);

//var issues = JsonSerializer.Deserialize<List<Issue>>(response.Content);

//foreach (var issue in issues)
//{
//    Console.WriteLine("ISSUE NUMBERS: " + issue.number);
//    Console.WriteLine("ISSUE ID: " + issue.id);
//    Console.WriteLine("ISSUE ID: " + issue.html_url);
//    Console.WriteLine("******");

//}
