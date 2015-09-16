﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using PRADA_Vayne.MyUtils;

namespace PRADA_Vayne.MyLogic.Others
{
    public static class SkinHack
    {
        public static bool Died = false;

        public static void OnUpdate(EventArgs args)
        {
            if (ObjectManager.Player.IsDead)
            {
                Died = true;
            }
            else
            {
                if (Died)
                {
                    Died = false;
                    Heroes.Player.SetSkin(Heroes.Player.CharData.BaseSkinName, Program.SkinhackMenu.Item("skin").GetValue<StringList>().SelectedIndex + 1);
                }
            }
        }
    }
}
