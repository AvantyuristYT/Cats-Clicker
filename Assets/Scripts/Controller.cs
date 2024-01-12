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

    // ���������� ������ � ����������� ����
    public Data data;
    [Header("�������� ���������")]
    // UI �������� ����������
    [SerializeField] private TMP_Text _happyCountText; // ������� ���
    [SerializeField] private TMP_Text _moneyCountText; // ������� �����
    [SerializeField] private Slider _happyCountBar; // �������� ��� ���

    [SerializeField] private TMP_Text _moneyScreenText;

    // ������������� ���� �������
    private double ClickPowerHappy() => 1 + data.clickHappyPerClick;
    private double ClickPowerMoney() => 1 + data.clickMoneyPerClick;
    [Header("������� ���������� ��������")]
    // ������� ���������� �������� ��� �����
    [SerializeField] private GameObject popupHappyTextPrefab;
    [SerializeField] private GameObject popupHappyIconPrefab;
    [SerializeField] private GameObject popupMoneyTextPrefab;
    [SerializeField] private GameObject popupMoneyIconPrefab;
    [Header("������� �������������� ��������")]
    // �������������� ������� ��������� �����
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
    // �������������� ������� ��������� ���
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
        UpgradesManager.instance.StartUpgradeManager(); // ��������� UI ��������� ��� ������ ����
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
    /// �������� UI � ���
    /// </summary>
    public void UpdateHappyCountUI()
    {
        _happyCountText.text = Math.Round(data.GetHappyCount(), 1).ToString() + " ����� �������";
        _happyCountBar.value = (float)data.GetHappyCount();
    }
    /// <summary>
    /// �������� UI � ��������
    /// </summary>
    public void UpdateMoneyCountUI()
    {
        _moneyCountText.text = "������: \n" + UpgradesManager.instance.ReturnNotationNumber(instance.data.GetMoneyCount());
        _moneyScreenText.text = Math.Round(data.GetMoneyCount(), 2).ToString();        
    }

    // ������� �� ������ ���
    public void PressHappyButton()
    {
        data.AddHappyCount(ClickPowerHappy()); // �������� � ��� ��������, ������ ����� �� ����
        UpdateHappyCountUI();

        Instantiate(popupHappyTextPrefab, Input.mousePosition, Quaternion.identity);
        Instantiate(popupHappyIconPrefab, Input.mousePosition, Quaternion.identity);
    }
    // �������  �� ������ �����
    public void PressMoneyButton()
    {
        data.AddMoneyCount(ClickPowerMoney()); // �������� 
        UpdateMoneyCountUI();
        Instantiate(popupMoneyTextPrefab, Input.mousePosition, Quaternion.identity);
        Instantiate(popupMoneyIconPrefab, Input.mousePosition, Quaternion.identity);
    }
    // �������� �������� ��� �� ����
    public double GetPowerHappyPerClick()
    {
        return ClickPowerHappy();
    }
    // �������� �������� ����� �� ����
    public double GetPowerMoneyPerClick()
    {
        return ClickPowerMoney();
    }
}
