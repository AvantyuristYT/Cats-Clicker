using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Controller : MonoBehaviour
{
    public static Controller instance;
    private void Awake() => instance = this;

    // Объявление класса с параметрами игры
    public Data data;

    // UI элементы параметров
    [SerializeField] private TMP_Text _happyCountText; // Счётчик ОчС
    [SerializeField] private TMP_Text _moneyCountText; // Счётчик Денег
    [SerializeField] private Slider _happyCountBar; // Прогресс Бар ОчС

    // Устанавливаем силу нажатия
    private double ClickPowerHappy() => 1 + data.clickHappyPerClick;
    private double ClickPowerMoney() => 1 + data.clickMoneyPerClick;

    [SerializeField] private GameObject popupHappyTextPrefab;
    [SerializeField] private GameObject popupHappyIconPrefab;
    [SerializeField] private GameObject popupMoneyTextPrefab;
    [SerializeField] private GameObject popupMoneyIconPrefab;

    private void Start()
    {
        data = new Data();
        UpgradesManager.instance.StartUpgradeManager(); // Обновляем UI улучшений при старте игры
    }
    /// <summary>
    /// Обновить UI с ОчС
    /// </summary>
    public void UpdateHappyCountUI()
    {
        _happyCountText.text = Math.Round(data.GetHappyCount(), 1).ToString() + " ОЧКОВ СЧАСТЬЯ";
        _happyCountBar.value = (float)data.GetHappyCount();
    }
    /// <summary>
    /// Обновить UI с Деньгами
    /// </summary>
    public void UpdateMoneyCountUI()
    {
        _moneyCountText.text = "ДЕНЬГИ: \n" + Math.Round(data.GetMoneyCount(), 1).ToString();
    }

    // Нажатие на кнопку ОчС
    public void PressHappyButton()
    {
        data.AddHappyCount(ClickPowerHappy()); // Добавить к ОчС значение, равное очкам за клик
        UpdateHappyCountUI();

        Instantiate(popupHappyTextPrefab, Input.mousePosition, Quaternion.identity);
        Instantiate(popupHappyIconPrefab, Input.mousePosition, Quaternion.identity);
    }
    // Нажатие  на кнопку Денег
    public void PressMoneyButton()
    {
        data.AddMoneyCount(ClickPowerMoney()); // Добавить 
        UpdateMoneyCountUI();
        Instantiate(popupMoneyTextPrefab, Input.mousePosition, Quaternion.identity);
        Instantiate(popupMoneyIconPrefab, Input.mousePosition, Quaternion.identity);
    }
    // Получить значение ОчС за клик
    public double GetPowerHappyPerClick()
    {
        return ClickPowerHappy();
    }
    // Получить значение Денег за клик
    public double GetPowerMoneyPerClick()
    {
        return ClickPowerMoney();
    }
}
