using DG.Tweening;
using UnityEngine;

public class ItemCollectableDiamond : ItemCollectableBase
{
    [Header("Animation Setup")]
    public float duration = .5f;
    public Vector3 animationRotation = new Vector3(0, 1000, 0);
    public Ease ease = Ease.InCubic;

    protected override void Collect()
    {
        base.Collect();
        transform.DOScale(Vector2.zero, duration).SetEase(ease);
        transform.DORotate(animationRotation, duration, RotateMode.FastBeyond360).SetEase(ease).OnComplete(() =>
        {
            ItemManager.Instance.AddDiamonds();
        });
    }
}
