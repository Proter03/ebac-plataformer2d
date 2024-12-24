using DG.Tweening;
using UnityEngine;

public class ItemCollectableCoin : ItemCollectableBase
{
    [Header("Animation setup")]
    public float duration = .5f;
    public float moveY = 4;
    public Ease ease = Ease.OutBack;

    protected override void Collect()
    {
        transform.DOScale(Vector2.zero, duration).SetEase(ease);
        transform.DOMoveY(moveY, duration).SetEase(ease).OnComplete(() =>
        {
            base.Collect();
        });
    }
}
