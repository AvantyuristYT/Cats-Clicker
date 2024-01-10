using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Controller : MonoBehaviour
{
    [SerializeField] private TMP_Text _happyCountText;
    [SerializeField] private Slider _happyCountBar;

    private Data _data;

    [SerializeField] private double _countPerClick;

    private void Start()
    {
        _data = new Data();
        _happyCountBar.value = 0;
    }

    public void PressHappyButton()
    {
        _data.AddHappyCount(_countPerClick);
        _happyCountText.text = Math.Round(_data.GetHappyCount(), 1).ToString() + " Î×ÊÎÂ Ñ×ÀÑÒÜß";
        _happyCountBar.value = (float)_data.GetHappyCount();
    }
}
