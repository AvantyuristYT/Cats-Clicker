using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour
{
    public void HappyButtonPressDown()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(0.8f, 0.5f).SetEase(Ease.OutCubic));
    }
    public void HappyButtonPressUp()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(1f, 0.5f).SetEase(Ease.OutElastic));
    }
}
