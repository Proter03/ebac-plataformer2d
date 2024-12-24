using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class FlashColor : MonoBehaviour
{
    public List<SpriteRenderer> spriteRenderers;
    public Color color = Color.red;
    public float duration = .1f;

    private Tween _currentTween;

    private void OnValidate()
    {
        spriteRenderers = new List<SpriteRenderer>();
        foreach (var child in transform.GetComponentsInChildren<SpriteRenderer>())
        {
            spriteRenderers.Add(child);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Flash();
        }
    }

    public void Flash()
    {
        if (_currentTween != null)
        {
            _currentTween.Kill();
            spriteRenderers.ForEach(s => s.color = Color.white);
        }

        foreach (var s in spriteRenderers)
        {
            _currentTween = s.DOColor(color, duration).SetLoops(4, LoopType.Yoyo);
        }
    }
}
