using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private string _descriptionBonusText;
    
    // �������� ���������
    public void OnPointerEnter(PointerEventData eventData)
    {
        ToolTipManager.Instance.SetAndShowToolTip(_descriptionBonusText);
    }

    // ������ ���������
    public void OnPointerExit(PointerEventData eventData)
    {
        ToolTipManager.Instance.HideToolTip();
    }
}
