using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI textCoin;

    private void Update()
    {
        textCoin.text = $"x {ItemManager.Instance.coins}";
    }
}
