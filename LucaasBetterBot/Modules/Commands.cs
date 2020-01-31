using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LucaasBetterBot.Modules
{
    class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("fivem")]
        public async Task fivem()
        {
            EmbedBuilder b = new EmbedBuilder()
            {
                Color = Color.DarkBlue,
                Title = "FiveM",
                Description = "FiveM is a modification for Grand Theft Auto V, enabling you to play multiplayer on customized; dedicated servers!\n" +
                "The name of the flight simulator server that lucaas' plays on mostly is called SFX Flight Simulator. Join their Discord server for more information join this discord server: discord.gg/sfx\n" +
                "There are a lot of other servers on FiveM as well such as roleplay servers!"
            };
            await Context.Channel.SendMessageAsync("", false, b.Build());
        }
        [Command("ceaseline")]
        public async Task ceaseline()
        {
            EmbedBuilder b = new EmbedBuilder()
            {
                Color = Color.Red,
                Title = "CEASELINE",
                Description = "⚠Alert! A Ceaseline has been called!\n" +
                "============\n" +
                "Cease your conversation or risk facing a mute\n" +
                "============"
            };
            await Context.Channel.SendMessageAsync("", false, b.Build());
        }
        [Command("help")]
        public async Task help()
        {
            EmbedBuilder b = new EmbedBuilder()
            {
                Color = Color.Orange,
                Title = "Help",
                Description = "Here's a list of commands you can use:\n" +
                ".help -brings up the command you see here!\n" +
                ".fivem -displays information on the FiveM server seen in lucaas' videos"
            };
            await Context.Channel.SendMessageAsync("", false, b.Build());
        }
    }
}
