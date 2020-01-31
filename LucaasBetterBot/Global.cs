using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LucaasBetterBot
{
    internal class Global
    {
        public static string Token { get; internal set; }

        public static char Prefix { get; set; }
        public static ulong ModeratorRoleID { get; internal set; }
        public static bool AutoSlowmodeToggle { get; internal set; }
        public static int AutoSlowmodeTrigger { get; internal set; }

        public static ulong GuildID { get; set; }
        public static ulong MutedRoleID { get; internal set; }

        public static string ConfigPath = Environment.CurrentDirectory + "\\Data\\Config.json";



        internal static void ReadConfig()
        {
            var jsonObj = JsonConvert.DeserializeObject<Dictionary<object, object>>(File.ReadAllText(ConfigPath));
            Token = jsonObj["Token"].ToString();
            Prefix = char.Parse(jsonObj["Prefix"].ToString());
            ModeratorRoleID = Convert.ToUInt64(jsonObj["ModeratorRoleID"]);
            AutoSlowmodeToggle = bool.Parse(jsonObj["AutoSlowmodeToggle"].ToString());
            AutoSlowmodeTrigger = int.Parse(jsonObj["AutoSlowmodeTrigger"].ToString());
            GuildID = ulong.Parse(jsonObj["GuildID"].ToString());
        }
    }
}