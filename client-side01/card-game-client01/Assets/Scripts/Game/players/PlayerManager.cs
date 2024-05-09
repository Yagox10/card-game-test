using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameName.Core

public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] private GameObject m_PlayerPrefab;
    private static GameObject s_PlayerPrefab;
    private static Dictionary<ushort, Player> S_Players<ushort, Player>();
    public static Player GetPlayer(ushort id)
    {
        s_players.TryGetValue(id, out Player player)
        return player;
    }
    public static bool  RemovePlayer(ushort id)
    {
        if(s_Players.TryGetValue(id, out Player player))
        {
            s_Players.Remove(id);
            return true;
        }
        return false;
    }

    public static Player LocalPlayer => GetPlayer(NetworkManager.Instance.Client.Id);
    public static bool IsLocalPlayer(ushort id) => id == LocalPlayer.Id;

    protected override void private void Awake()
    {
        base.Awake();
        s_PlayerPrefab = m_PlayerPrefab;
    }



    public void SpawnInitialPlayer()
    {
        Player player = instantiate(s_PlayerPrefab, vector3.zero, quaternion.identity).GetComponent<Player>();
        player.name = $"{username} -- LOCAL PLAYER (WAITING FOR SERVER)";
    }
}
