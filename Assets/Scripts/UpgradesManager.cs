using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public static UpgradesManager instance;
    private void Awake() => instance = this;

    [SerializeField] private Upgrades moneyUpgradeOne; // �������� �������������� ��������� � �������

    [SerializeField] private double moneyUpgradeOneCost; // ���� �� ���� ���������
    [SerializeField] private double moneyUpgradeOneCostMultiplier; // ��������� ��� ���� ���������

    /// <summary>
    /// ������������� �������� ���������� ��� ������
    /// </summary>
    public void StartUpgradeManager()
    {
        moneyUpgradeOneCost = 10;
        moneyUpgradeOneCostMultiplier = 1.14;

        UpdateMoneyUpgradeOneUI();
    }
    /// <summary>
    /// �������� UI ������� ��������� �����
    /// </summary>
    public void UpdateMoneyUpgradeOneUI()
    {
        moneyUpgradeOne.levelText.text = Controller.instance.data.moneyUpgradeOneLevel.ToString();
        moneyUpgradeOne.costText.text = Cost().ToString("F2");
    }
    // ��������� ����� ���� ��� ���������
    private double Cost() => moneyUpgradeOneCost * Math.Pow(moneyUpgradeOneCostMultiplier, Controller.instance.data.moneyUpgradeOneLevel);
    
    // �������� ���������
    public void BuyMoneyUpgrade()
    {
        var data = Controller.instance.data;
        if (data.GetMoneyCount() >= Cost())
        {
            data.SubstractMoneyCount(Cost());

            data.moneyUpgradeOneLevel += 1;
            data.clickMoneyPerClick += 0.5;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeOneUI();
        }
    }
}
