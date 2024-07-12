using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using UnityEngine;

namespace ExamplePlugin
{
    internal class EventHandlers
    {
        // 玩家加入游戏
        [PluginEvent]
        void OnPlayerJoined(PlayerJoinedEvent ev)
        {
            ev.Player.SendBroadcast("欢迎来到萌新天堂服务器(°∀°)ﾉ", 10);
        }

        // 游戏回合开始
        [PluginEvent]
        void OnRoundStart(RoundStartEvent ev)
        {
            Map.Broadcast(10, "游戏开始!");
        }

        // 禁用血迹
        [PluginEvent]
        void OnPlaceBlood(PlaceBloodEvent ev)
        {
            ev.Position = Vector3.zero;
        }
    }
}