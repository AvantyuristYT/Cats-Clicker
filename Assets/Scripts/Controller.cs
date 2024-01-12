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
    [Header("Основные параметры")]
    // UI элементы параметров
    [SerializeField] private TMP_Text _happyCountText; // Счётчик ОчС
    [SerializeField] private TMP_Text _moneyCountText; // Счётчик Денег
    [SerializeField] private Slider _happyCountBar; // Прогресс Бар ОчС

    [SerializeField] private TMP_Text _moneyScreenText;

    // Устанавливаем силу нажатия
    private double ClickPowerHappy() => 1 + data.clickHappyPerClick;
    private double ClickPowerMoney() => 1 + data.clickMoneyPerClick;
    [Header("Префабы выпадающих объектов")]
    // Префабы выпадающих объектов при клике
    [SerializeField] private GameObject popupHappyTextPrefab;
    [SerializeField] private GameObject popupHappyIconPrefab;
    [SerializeField] private GameObject popupMoneyTextPrefab;
    [SerializeField] private GameObject popupMoneyIconPrefab;
    [Header("Префабы загораживающих объектов")]
    // Загораживающие объекты улучшения Денег
    [SerializeField] private GameObject _moneyButtonOneFadeScreen;
    [SerializeField] private GameObject _moneyButtonTwoFadeScreen;
    [SerializeField] private GameObject _moneyButtonThreeFadeScreen;
    [SerializeField] private GameObject _moneyButtonFourFadeScreen;
    [SerializeField] private GameObject _moneyButtonFiveFadeScreen;
    [SerializeField] private GameObject _moneyButtonSixFadeScreen;
    [SerializeField] private GameObject _moneyButtonSevenFadeScreen;
    [SerializeField] private GameObject _moneyButtonEightFadeScreen;
    [SerializeField] private GameObject _moneyButtonNineFadeScreen;
    [SerializeField] private GameObject _moneyButtonTenFadeScreen;
    // Загораживающие объекты улучшения ОчС
    [SerializeField] private GameObject _happyButtonOneFadeScreen;
    [SerializeField] private GameObject _happyButtonTwoFadeScreen;
    [SerializeField] private GameObject _happyButtonThreeFadeScreen;
    [SerializeField] private GameObject _happyButtonFourFadeScreen;
    [SerializeField] private GameObject _happyButtonFiveFadeScreen;
    [SerializeField] private GameObject _happyButtonSixFadeScreen;
    [SerializeField] private GameObject _happyButtonSevenFadeScreen;
    [SerializeField] private GameObject _happyButtonEightFadeScreen;
    [SerializeField] private GameObject _happyButtonNineFadeScreen;
    [SerializeField] private GameObject _happyButtonTenFadeScreen;

    private void Start()
    {
        data = new Data();
        UpgradesManager.instance.StartUpgradeManager(); // Обновляем UI улучшений при старте игры
        UpdateMoneyCountUI();
    }

    private void Update()
    {
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeOneCost()) _moneyButtonOneFadeScreen.SetActive(true);
        else _moneyButtonOneFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeTwoCost()) _moneyButtonTwoFadeScreen.SetActive(true);
        else _moneyButtonTwoFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeThreeCost()) _moneyButtonThreeFadeScreen.SetActive(true);
        else _moneyButtonThreeFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeFourCost()) _moneyButtonFourFadeScreen.SetActive(true);
        else _moneyButtonFourFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeFiveCost()) _moneyButtonFiveFadeScreen.SetActive(true);
        else _moneyButtonFiveFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeSixCost()) _moneyButtonSixFadeScreen.SetActive(true);
        else _moneyButtonSixFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeSevenCost()) _moneyButtonSevenFadeScreen.SetActive(true);
        else _moneyButtonSevenFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeEightCost()) _moneyButtonEightFadeScreen.SetActive(true);
        else _moneyButtonEightFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeNineCost()) _moneyButtonNineFadeScreen.SetActive(true);
        else _moneyButtonNineFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.MoneyUpgradeTenCost()) _moneyButtonTenFadeScreen.SetActive(true);
        else _moneyButtonTenFadeScreen.SetActive(false);

        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeOneCost()) _happyButtonOneFadeScreen.SetActive(true);
        else _happyButtonOneFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeTwoCost()) _happyButtonTwoFadeScreen.SetActive(true);
        else _happyButtonTwoFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeThreeCost()) _happyButtonThreeFadeScreen.SetActive(true);
        else _happyButtonThreeFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeFourCost()) _happyButtonFourFadeScreen.SetActive(true);
        else _happyButtonFourFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeFiveCost()) _happyButtonFiveFadeScreen.SetActive(true);
        else _happyButtonFiveFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeSixCost()) _happyButtonSixFadeScreen.SetActive(true);
        else _happyButtonSixFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeSevenCost()) _happyButtonSevenFadeScreen.SetActive(true);
        else _happyButtonSevenFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeEightCost()) _happyButtonEightFadeScreen.SetActive(true);
        else _happyButtonEightFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeNineCost()) _happyButtonNineFadeScreen.SetActive(true);
        else _happyButtonNineFadeScreen.SetActive(false);
        if (instance.data.GetMoneyCount() < UpgradesManager.instance.HappyUpgradeTenCost()) _happyButtonTenFadeScreen.SetActive(true);
        else _happyButtonTenFadeScreen.SetActive(false);
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
        _moneyCountText.text = "ДЕНЬГИ: \n" + UpgradesManager.instance.ReturnNotationNumber(instance.data.GetMoneyCount());
        _moneyScreenText.text = Math.Round(data.GetMoneyCount(), 2).ToString();        
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
