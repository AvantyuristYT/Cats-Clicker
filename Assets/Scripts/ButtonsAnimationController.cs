using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class ButtonsAnimationController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private void Update()
    {
        // �������� ������ �� ��� Z
        if (gameObject.tag == "CharityButton")
        {
            transform.Rotate(0, 0, 0.01f);
        }
    }

    // �������� ���������� ������
    public void ButtonPressDown()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(0.8f, 0.5f).SetEase(Ease.OutCubic));
    }
    // �������� ���������� ������
    public void ButtonPressUp()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(1f, 0.5f).SetEase(Ease.OutElastic));
    }
    
    // ��������� ������ �������� ����
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameObject.tag == "WindowButton")
        {
            transform.DOScale(1.07f, 0.5f).SetEase(Ease.OutCubic);
        }     
    }

    // ��������� ������ �������� ����
    public void OnPointerExit(PointerEventData eventData)
    {
        if (gameObject.tag == "WindowButton")
        {
            transform.DOScale(1.0f, 0.5f).SetEase(Ease.OutCubic);
        }
    }
}
