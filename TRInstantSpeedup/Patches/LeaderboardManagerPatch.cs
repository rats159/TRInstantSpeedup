using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TRInstantSpeedup.Patches;
[HarmonyPatch(typeof(LeaderboardManager),nameof(LeaderboardManager.StartLeaderboardRun))]
internal class LeaderboardManagerPatch
{
    public static void Postfix(ref LeaderboardManager __instance)
    {
        Time.timeScale = 64;
        __instance.SpeedUp(); //Sets the buttons to be correct
    }
}
