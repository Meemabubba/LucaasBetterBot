using Discord.Commands;
using Discord.WebSocket;
using LucaasBetterBot.Modules;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace LucaasBetterBot
{
    internal class CommandHandler
    {
        private DiscordSocketClient client;
        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            this.client = client;

            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly(), null);

            client.MessageReceived += HandleCommand;

            ModDatabase.Start(client.GetGuild(Global.GuildID), client).GetAwaiter().GetResult();
        }

        private async Task HandleCommand(SocketMessage s)
        {
            SocketUserMessage msg = s as SocketUserMessage;
            if (msg == null) { return; }
            var context = new SocketCommandContext(client, msg);
            int argPos = 0;
            if (msg.HasCharPrefix(Global.Prefix, ref argPos))
            {
                var result = await _service.ExecuteAsync(context, argPos, null, MultiMatchHandling.Best);

                if (result.IsSuccess == false)
                {
                    Console.WriteLine(result.ErrorReason);
                }
            }
        }
    }
}