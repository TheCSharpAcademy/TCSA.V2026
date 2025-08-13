using NetCord.Gateway;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers.Constants;

namespace TCSA.V2026.Services;

public interface IDiscordService
{
    Task<bool> ChangeDiscordBelt(string discordAlias, Level newBelt);
}

public class DiscordService : IDiscordService
{
    private readonly ulong _guildId = 925901888203935744;
    private readonly ulong _channelId = 925901888203935747;
    private readonly GatewayClient _client;

    public DiscordService(GatewayClient client)
    {
        _client = client;
    }

    public async Task<bool> ChangeDiscordBelt(string discordAlias, Level newBelt)
    {
        var user = _client.Cache.Guilds[_guildId].Users.Values.FirstOrDefault(u => u.Nickname == discordAlias || u.Username == discordAlias);

        if (user is null)
        {
            return false;
        }

        foreach (var role in user.RoleIds)
        {
            await user.RemoveRoleAsync(role);
        }

        var newRole = GetNewRoleId(newBelt);

        if (newRole == 0)
        {
            return false;
        }

        await user.AddRoleAsync(newRole);

        await _client.Rest.SendMessageAsync(_channelId, $"<@{user.Id}> congratulations! You got your {(newBelt == Level.OliveGreen ? "Olive Green" : newBelt)} belt!  :tada:");

        var gif = GetRandomGif(newBelt);

        if (string.IsNullOrWhiteSpace(gif))
        {
            return false;
        }

        await _client.Rest.SendMessageAsync(_channelId, $"{gif}");

        return true;
    }

    private static ulong GetNewRoleId(Level belt)
    {
        return belt switch
        {
            Level.Green => DiscordRoles.Green,
            Level.OliveGreen => DiscordRoles.OliveGreen,
            Level.Yellow => DiscordRoles.Yellow,
            Level.Orange => DiscordRoles.Orange,
            Level.Red => DiscordRoles.Red,
            Level.Purple => DiscordRoles.Purple,
            // Level.Brown => DiscordRoles.Brown
            Level.Grey => DiscordRoles.Grey,
            // Level.Blue => DiscordRoles.Blue
            Level.Black => DiscordRoles.Black,
            _ => 0
        };
    }

    private static string GetRandomGif(Level belt)
    {
        var random = new Random();

        return belt switch
        {
            Level.Green => BeltGifs.Green[random.Next(BeltGifs.Green.Count)],
            Level.OliveGreen => BeltGifs.OliveGreen[random.Next(BeltGifs.OliveGreen.Count)],
            Level.Yellow => BeltGifs.Yellow[random.Next(BeltGifs.Yellow.Count)],
            Level.Orange => BeltGifs.Orange[random.Next(BeltGifs.Orange.Count)],
            Level.Red => BeltGifs.Red[random.Next(BeltGifs.Red.Count)],
            Level.Purple => BeltGifs.Purple[random.Next(BeltGifs.Purple.Count)],
            Level.Brown => BeltGifs.Brown[random.Next(BeltGifs.Brown.Count)],
            Level.Grey => BeltGifs.Grey[random.Next(BeltGifs.Grey.Count)],
            Level.Blue => BeltGifs.Blue[random.Next(BeltGifs.Blue.Count)],
            Level.Black => BeltGifs.Black[random.Next(BeltGifs.Black.Count)],
            _ => string.Empty
        };
    }
}
