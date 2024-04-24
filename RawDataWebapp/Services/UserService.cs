using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using RawDataWebapp.Models;

public class UserService
{
    private readonly string _filePath;

    public UserService(IWebHostEnvironment environment)
    {
        _filePath = Path.Combine(environment.ContentRootPath, "Users.json");
    }

    public async Task<bool> ValidateUserAsync(string username, string password)
    {
        var users = await GetUsersAsync();
        return users.Any(u => u.Username == username && u.Password == password);
    }

    private async Task<List<User>> GetUsersAsync()
    {
        if (!File.Exists(_filePath))
        {
            return new List<User>();
        }

        using (var jsonFileReader = File.OpenRead(_filePath))
        {
            return await JsonSerializer.DeserializeAsync<List<User>>(jsonFileReader) ?? new List<User>();
        }
    }
}
