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

    // UI �������� ����������
    [SerializeField] private TMP_Text _happyCountText; // ������� ���
    [SerializeField] private TMP_Text _moneyCountText; // ������� �����
    [SerializeField] private Slider _happyCountBar; // �������� ��� ���

    // ������������� ���� �������
    private double ClickPowerHappy() => 1 + data.clickHappyPerClick;
    private double ClickPowerMoney() => 1 + data.clickMoneyPerClick;

    [SerializeField] private GameObject popupHappyTextPrefab;
    [SerializeField] private GameObject popupHappyIconPrefab;
    [SerializeField] private GameObject popupMoneyTextPrefab;
    [SerializeField] private GameObject popupMoneyIconPrefab;

    private void Start()
    {
        data = new Data();
        UpgradesManager.instance.StartUpgradeManager(); // ��������� UI ��������� ��� ������ ����
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
        _moneyCountText.text = "������: \n" + Math.Round(data.GetMoneyCount(), 1).ToString();
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
