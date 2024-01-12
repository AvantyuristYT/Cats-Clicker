using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class ButtonsAnimationController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private void Update()
    {
        // Вращение кнопки по оси Z
        if (gameObject.tag == "CharityButton")
        {
            transform.Rotate(0, 0, 0.01f);
        }
    }

    // Анимация уменьшения кнопки
    public void ButtonPressDown()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(0.8f, 0.5f).SetEase(Ease.OutCubic));
    }
    // Анимация увеличения кнопки
    public void ButtonPressUp()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(1f, 0.5f).SetEase(Ease.OutElastic));
    }
    
    // Увеличить кнопку перехода окна
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameObject.tag == "WindowButton")
        {
            transform.DOScale(1.07f, 0.5f).SetEase(Ease.OutCubic);
        }     
    }

    // Уменьшить кнопку перехода окна
    public void OnPointerExit(PointerEventData eventData)
    {
        if (gameObject.tag == "WindowButton")
        {
            transform.DOScale(1.0f, 0.5f).SetEase(Ease.OutCubic);
        }
    }
}
