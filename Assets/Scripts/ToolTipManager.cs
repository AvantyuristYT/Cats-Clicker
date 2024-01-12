using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToolTipManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _descriptionBonusText;

    public static ToolTipManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, Input.mousePosition.y, transform.position.z);
    }

    /// <summary>
    /// Показывает подсказку с указанными параметрами
    /// </summary>
    /// <param name="newDescriptionText">Описание улучшения</param>
    public void SetAndShowToolTip(string newDescriptionText)
    {
        gameObject.SetActive(true);
        _descriptionBonusText.text = "\"" + newDescriptionText + "\"";
    }

    /// <summary>
    /// Скрывает подсказку
    /// </summary>
    public void HideToolTip()
    {
        gameObject.SetActive(false);
        _descriptionBonusText.text = string.Empty;
    }
}
