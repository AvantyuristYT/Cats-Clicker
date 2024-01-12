using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public static UpgradesManager instance;
    private void Awake() => instance = this;

    [SerializeField] private Upgrades moneyUpgradeOne; // Получаем характеристики улучшения с объекта

    [SerializeField] private double moneyUpgradeOneCost; // Цена за одно улучшение
    [SerializeField] private double moneyUpgradeOneCostMultiplier; // Множитель для цены улучшения

    /// <summary>
    /// Инициализация основных параметров при старте
    /// </summary>
    public void StartUpgradeManager()
    {
        moneyUpgradeOneCost = 10;
        moneyUpgradeOneCostMultiplier = 1.14;

        UpdateMoneyUpgradeOneUI();
    }
    /// <summary>
    /// Обновить UI первого улучшения Денег
    /// </summary>
    public void UpdateMoneyUpgradeOneUI()
    {
        moneyUpgradeOne.levelText.text = Controller.instance.data.moneyUpgradeOneLevel.ToString();
        moneyUpgradeOne.costText.text = Cost().ToString("F2");
    }
    // Формируем новую цену для улучшения
    private double Cost() => moneyUpgradeOneCost * Math.Pow(moneyUpgradeOneCostMultiplier, Controller.instance.data.moneyUpgradeOneLevel);
    
    // Покупаем улучшение
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
