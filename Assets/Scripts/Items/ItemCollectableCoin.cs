using DG.Tweening;
using UnityEngine;

public class ItemCollectableCoin : ItemCollectableBase
{
    [Header("Animation Setup")]
    public float duration = .5f;
    public Ease ease = Ease.OutBack;

    protected override void Collect()
    {
        transform.DOScale(Vector2.zero, duration).SetEase(ease).OnComplete(() =>
        {
            base.Collect();
            ItemManager.Instance.AddCoins();
        });
    }
}
