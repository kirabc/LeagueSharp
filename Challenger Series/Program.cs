﻿#region License
/* Copyright (c) LeagueSharp 2016
 * No reproduction is allowed in any way unless given written consent
 * from the LeagueSharp staff.
 * 
 * Author: imsosharp
 * Date: 2/20/2016
 * File: Program.cs
 */
#endregion License

using LeagueSharp;
using LeagueSharp.SDK;

namespace Challenger_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Events.OnLoad += (sender, eventArgs) =>
            {
                switch (ObjectManager.Player.ChampionName)
                {
                    case "Soraka":
                        new Soraka();
                        break;
                    case "Vayne":
                        new Vayne();
                        break;
                }
            };
        }
    }
}