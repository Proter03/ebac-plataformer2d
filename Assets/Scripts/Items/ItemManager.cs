using Ebac.Core.Singleton;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    [SerializeField] private SOInt coins;
    [SerializeField] private SOInt diamonds;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        diamonds.value = 0;
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
    }

    public void AddDiamonds(int amount = 1)
    {
        diamonds.value += amount;
    }
}
