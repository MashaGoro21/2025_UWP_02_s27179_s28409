using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int coins;
    private int keys;
    private static Inventory _instance;
    public static Inventory Instance => _instance ??= new Inventory();

    private void Awake()
    {
        coins = 0;
        keys = 0;
    }

    public void AddCoin()
    {
        coins++;
    }

    public void AddKey()
    {
        keys++;
    }

    public int GetKeys()
    {
        return keys;
    }

    public void UseKey()
    {
        keys--;
    }
}
