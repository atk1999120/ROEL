using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlagDefine : MonoBehaviour
{
    // ÉQÅ[ÉÄì‡ÇÃÉtÉâÉO
    public enum GameFlag
    {
        Invalide = 0,
        KeyItemGet,
        Max
    }

    public static Dictionary<GameFlag, bool> GameFlagDictionary = new Dictionary<GameFlag, bool>();
    private void Start()
    {
        InitGameFlag();
    }

    public void InitGameFlag()
    {
        GameFlagDictionary.Clear();
        GameFlagDictionary.Add(GameFlag.KeyItemGet, false);
    }
    public static void SetGameFlag(GameFlag gameFlag)
    {
        GameFlagDictionary[gameFlag] = true;
    }
    public static bool GetGameFlag(GameFlag gameFlag)
    {
        return GameFlagDictionary[gameFlag];
    }
}
