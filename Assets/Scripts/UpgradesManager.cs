using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public static UpgradesManager instance;
    private void Awake() => instance = this;
    // Получаем текста с прыбылью в секунду
    [SerializeField] private TMP_Text _happyPerSecText;
    [SerializeField] private TMP_Text _moneyPerSecText;

    // Получаем хар-ти улучшений Денег с объектов 
    [Header("Ссылки на улучшения Денег")]
    [SerializeField] private Upgrades moneyUpgradeOne;
    [SerializeField] private Upgrades moneyUpgradeTwo;
    [SerializeField] private Upgrades moneyUpgradeThree;
    [SerializeField] private Upgrades moneyUpgradeFour;
    [SerializeField] private Upgrades moneyUpgradeFive;
    [SerializeField] private Upgrades moneyUpgradeSix;
    [SerializeField] private Upgrades moneyUpgradeSeven;
    [SerializeField] private Upgrades moneyUpgradeEight;
    [SerializeField] private Upgrades moneyUpgradeNine;
    [SerializeField] private Upgrades moneyUpgradeTen;
    // Получаем хар-ти улучшений ОчС с объектов
    [Header("Ссылки на улучшения ОчС")]
    [SerializeField] private Upgrades happyUpgradeOne;
    [SerializeField] private Upgrades happyUpgradeTwo;
    [SerializeField] private Upgrades happyUpgradeThree;
    [SerializeField] private Upgrades happyUpgradeFour;
    [SerializeField] private Upgrades happyUpgradeFive;
    [SerializeField] private Upgrades happyUpgradeSix;
    [SerializeField] private Upgrades happyUpgradeSeven;
    [SerializeField] private Upgrades happyUpgradeEight;
    [SerializeField] private Upgrades happyUpgradeNine;
    [SerializeField] private Upgrades happyUpgradeTen;
    // Создаём цены для улучшений Денег
    [SerializeField] private double moneyUpgradeOneCost; 
    [SerializeField] private double moneyUpgradeTwoCost;
    [SerializeField] private double moneyUpgradeThreeCost;
    [SerializeField] private double moneyUpgradeFourCost; 
    [SerializeField] private double moneyUpgradeFiveCost;
    [SerializeField] private double moneyUpgradeSixCost;
    [SerializeField] private double moneyUpgradeSevenCost;
    [SerializeField] private double moneyUpgradeEightCost; 
    [SerializeField] private double moneyUpgradeNineCost;
    [SerializeField] private double moneyUpgradeTenCost;
    // Создаём цены для улучшений ОчС
    [SerializeField] private double happyUpgradeOneCost;
    [SerializeField] private double happyUpgradeTwoCost; 
    [SerializeField] private double happyUpgradeThreeCost; 
    [SerializeField] private double happyUpgradeFourCost;
    [SerializeField] private double happyUpgradeFiveCost;
    [SerializeField] private double happyUpgradeSixCost;
    [SerializeField] private double happyUpgradeSevenCost;
    [SerializeField] private double happyUpgradeEightCost;
    [SerializeField] private double happyUpgradeNineCost;
    [SerializeField] private double happyUpgradeTenCost;
    // Множители для цены улучшений Денег
    [SerializeField] private double moneyUpgradeOneCostMultiplier;
    [SerializeField] private double moneyUpgradeTwoCostMultiplier;
    [SerializeField] private double moneyUpgradeThreeCostMultiplier;
    [SerializeField] private double moneyUpgradeFourCostMultiplier;
    [SerializeField] private double moneyUpgradeFiveCostMultiplier;
    [SerializeField] private double moneyUpgradeSixCostMultiplier;
    [SerializeField] private double moneyUpgradeSevenCostMultiplier;
    [SerializeField] private double moneyUpgradeEightCostMultiplier;
    [SerializeField] private double moneyUpgradeNineCostMultiplier;
    [SerializeField] private double moneyUpgradeTenCostMultiplier;
    // Множители для цены улучшений ОчС
    [SerializeField] private double happyUpgradeOneCostMultiplier;
    [SerializeField] private double happyUpgradeTwoCostMultiplier;
    [SerializeField] private double happyUpgradeThreeCostMultiplier;
    [SerializeField] private double happyUpgradeFourCostMultiplier;
    [SerializeField] private double happyUpgradeFiveCostMultiplier;
    [SerializeField] private double happyUpgradeSixCostMultiplier;
    [SerializeField] private double happyUpgradeSevenCostMultiplier;
    [SerializeField] private double happyUpgradeEightCostMultiplier;
    [SerializeField] private double happyUpgradeNineCostMultiplier;
    [SerializeField] private double happyUpgradeTenCostMultiplier;

    /// <summary>
    /// Инициализация основных параметров при старте
    /// </summary>
    public void StartUpgradeManager()
    {
        InitUpgradeCost();
        InitUpgradeCostMultiplier();        
        UpdateMoneyUpgradeUI();
        UpdateHappyUpgradeUI();
    }

    private void Update()
    {
        Controller.instance.data.AddHappyCount(Controller.instance.data.clickHappyPerSecond * Time.deltaTime);
        Controller.instance.UpdateHappyCountUI();
        
        Controller.instance.data.AddMoneyCount(Controller.instance.data.clickMoneyPerSecond * Time.deltaTime);
        Controller.instance.UpdateMoneyCountUI();
    }
    /// <summary>
    /// Инициализация цены улучшения
    /// </summary>
    private void InitUpgradeCost()
    {
        moneyUpgradeOneCost = 20; 
        moneyUpgradeTwoCost = 200;
        moneyUpgradeThreeCost = 1000;
        moneyUpgradeFourCost = 12000;
        moneyUpgradeFiveCost = 99999;
        moneyUpgradeSixCost = 1000000;
        moneyUpgradeSevenCost = 20000000;
        moneyUpgradeEightCost = 270000000;
        moneyUpgradeNineCost = 3000000000;
        moneyUpgradeTenCost = 50000000000;

        happyUpgradeOneCost = 10;
        happyUpgradeTwoCost = 100;
        happyUpgradeThreeCost = 700;
        happyUpgradeFourCost = 4000;
        happyUpgradeFiveCost = 18000;
        happyUpgradeSixCost = 60000;
        happyUpgradeSevenCost = 500000;
        happyUpgradeEightCost = 12000000;
        happyUpgradeNineCost = 300000000;
        happyUpgradeTenCost = 1500000000;
    }
    /// <summary>
    /// Инициализация множителей цены улучшения
    /// </summary>
    private void InitUpgradeCostMultiplier()
    {
        moneyUpgradeOneCostMultiplier = 1.08;
        moneyUpgradeTwoCostMultiplier = 1.09;
        moneyUpgradeThreeCostMultiplier = 1.12;
        moneyUpgradeFourCostMultiplier = 1.13;
        moneyUpgradeFiveCostMultiplier = 1.16;
        moneyUpgradeSixCostMultiplier = 1.11;
        moneyUpgradeSevenCostMultiplier = 1.10;
        moneyUpgradeEightCostMultiplier = 1.08;
        moneyUpgradeNineCostMultiplier = 1.09;
        moneyUpgradeTenCostMultiplier = 1.07;

        happyUpgradeOneCostMultiplier = 1.10;
        happyUpgradeTwoCostMultiplier = 1.11;
        happyUpgradeThreeCostMultiplier = 1.12;
        happyUpgradeFourCostMultiplier = 1.10;
        happyUpgradeFiveCostMultiplier = 1.15;
        happyUpgradeSixCostMultiplier = 1.12;
        happyUpgradeSevenCostMultiplier = 1.15;
        happyUpgradeEightCostMultiplier = 1.13;
        happyUpgradeNineCostMultiplier = 1.12;
        happyUpgradeTenCostMultiplier = 1.08;
    }

    /// <summary>
    /// Обновить UI улучшений Денег
    /// </summary>
    public void UpdateMoneyUpgradeUI()
    {
        var _data = Controller.instance.data;
        moneyUpgradeOne.levelText.text = _data.moneyUpgradeOneLevel.ToString();
        moneyUpgradeOne.costText.text = ReturnNotationNumber(MoneyUpgradeOneCost());
        moneyUpgradeTwo.levelText.text = _data.moneyUpgradeTwoLevel.ToString();
        moneyUpgradeTwo.costText.text = ReturnNotationNumber(MoneyUpgradeTwoCost());
        moneyUpgradeThree.levelText.text = _data.moneyUpgradeThreeLevel.ToString();
        moneyUpgradeThree.costText.text = ReturnNotationNumber(MoneyUpgradeThreeCost());
        moneyUpgradeFour.levelText.text = _data.moneyUpgradeFourLevel.ToString();
        moneyUpgradeFour.costText.text = ReturnNotationNumber(MoneyUpgradeFourCost());
        moneyUpgradeFive.levelText.text = _data.moneyUpgradeFiveLevel.ToString();
        moneyUpgradeFive.costText.text = ReturnNotationNumber(MoneyUpgradeFiveCost());
        moneyUpgradeSix.levelText.text = _data.moneyUpgradeSixLevel.ToString();
        moneyUpgradeSix.costText.text = ReturnNotationNumber(MoneyUpgradeSixCost());
        moneyUpgradeSeven.levelText.text = _data.moneyUpgradeSevenLevel.ToString();
        moneyUpgradeSeven.costText.text = ReturnNotationNumber(MoneyUpgradeSevenCost());
        moneyUpgradeEight.levelText.text = _data.moneyUpgradeEightLevel.ToString();
        moneyUpgradeEight.costText.text = ReturnNotationNumber(MoneyUpgradeEightCost());
        moneyUpgradeNine.levelText.text = _data.moneyUpgradeNineLevel.ToString();
        moneyUpgradeNine.costText.text = ReturnNotationNumber(MoneyUpgradeNineCost());
        moneyUpgradeTen.levelText.text = _data.moneyUpgradeTenLevel.ToString();
        moneyUpgradeTen.costText.text = ReturnNotationNumber(MoneyUpgradeTenCost());
    }

    public string ReturnNotationNumber(double value)
    {
        string temp = "";
        if (value > 999999 && value < 1000000000)
        {
            temp = (value / 1000000).ToString("N3");
            return temp + " М";
        }
        if (value > 999999999 && value < 1000000000000)
        {
            temp = (value / 1000000000).ToString("N3");
            return temp + " B";
        }
        if (value > 999999999999 && value < 1000000000000000)
        {
            temp = (value / 1000000000000).ToString("N3");
            return temp + " T";
        }
        if (value > 999999999999999 && value < 1000000000000000000)
        {
            temp = (value / 1000000000000).ToString("N3");
            return temp + " Q";
        }
        return value.ToString("N0");
    }

    /// <summary>
    /// Обновить UI улучшений ОчС
    /// </summary>
    public void UpdateHappyUpgradeUI()
    {
        var _data = Controller.instance.data;
        happyUpgradeOne.levelText.text = _data.happyUpgradeOneLevel.ToString();
        happyUpgradeOne.costText.text = ReturnNotationNumber(HappyUpgradeOneCost());
        happyUpgradeTwo.levelText.text = _data.happyUpgradeTwoLevel.ToString();
        happyUpgradeTwo.costText.text = ReturnNotationNumber(HappyUpgradeTwoCost());
        happyUpgradeThree.levelText.text = _data.happyUpgradeThreeLevel.ToString();
        happyUpgradeThree.costText.text = ReturnNotationNumber(HappyUpgradeThreeCost());
        happyUpgradeFour.levelText.text = _data.happyUpgradeFourLevel.ToString();
        happyUpgradeFour.costText.text = ReturnNotationNumber(HappyUpgradeFourCost());
        happyUpgradeFive.levelText.text = _data.happyUpgradeFiveLevel.ToString();
        happyUpgradeFive.costText.text = ReturnNotationNumber(HappyUpgradeFiveCost());
        happyUpgradeSix.levelText.text = _data.happyUpgradeSixLevel.ToString();
        happyUpgradeSix.costText.text = ReturnNotationNumber(HappyUpgradeSixCost());
        happyUpgradeSeven.levelText.text = _data.happyUpgradeSevenLevel.ToString();
        happyUpgradeSeven.costText.text = ReturnNotationNumber(HappyUpgradeSevenCost());
        happyUpgradeEight.levelText.text = _data.happyUpgradeEightLevel.ToString();
        happyUpgradeEight.costText.text = ReturnNotationNumber(HappyUpgradeEightCost());
        happyUpgradeNine.levelText.text = _data.happyUpgradeNineLevel.ToString();
        happyUpgradeNine.costText.text = ReturnNotationNumber(HappyUpgradeNineCost());
        happyUpgradeTen.levelText.text = _data.happyUpgradeTenLevel.ToString();
        happyUpgradeTen.costText.text = ReturnNotationNumber(HappyUpgradeTenCost());
    }
    /// <summary>
    /// Обновить UI ОчС в секунду
    /// </summary>
    public void UpdateHappyPerSecUI()
    {
        _happyPerSecText.text = $"{Controller.instance.data.clickHappyPerSecond:N3}/с";
    }
    /// <summary>
    /// Обновить UI Денег в секунду
    /// </summary>
    public void UpdateMoneyPerSecUI()
    {
        _moneyPerSecText.text = $"{Controller.instance.data.clickMoneyPerSecond:N3}/с";
    }

    // Формируем новую цену для улучшения Денег
    public double MoneyUpgradeOneCost() => moneyUpgradeOneCost * Math.Pow(moneyUpgradeOneCostMultiplier, Controller.instance.data.moneyUpgradeOneLevel);
    public double MoneyUpgradeTwoCost() => moneyUpgradeTwoCost * Math.Pow(moneyUpgradeTwoCostMultiplier, Controller.instance.data.moneyUpgradeTwoLevel);
    public double MoneyUpgradeThreeCost() => moneyUpgradeThreeCost * Math.Pow(moneyUpgradeThreeCostMultiplier, Controller.instance.data.moneyUpgradeThreeLevel);
    public double MoneyUpgradeFourCost() => moneyUpgradeFourCost * Math.Pow(moneyUpgradeFourCostMultiplier, Controller.instance.data.moneyUpgradeFourLevel);
    public double MoneyUpgradeFiveCost() => moneyUpgradeFiveCost * Math.Pow(moneyUpgradeFiveCostMultiplier, Controller.instance.data.moneyUpgradeFiveLevel);
    public double MoneyUpgradeSixCost() => moneyUpgradeSixCost * Math.Pow(moneyUpgradeSixCostMultiplier, Controller.instance.data.moneyUpgradeSixLevel);
    public double MoneyUpgradeSevenCost() => moneyUpgradeSevenCost * Math.Pow(moneyUpgradeSevenCostMultiplier, Controller.instance.data.moneyUpgradeSevenLevel);
    public double MoneyUpgradeEightCost() => moneyUpgradeEightCost * Math.Pow(moneyUpgradeEightCostMultiplier, Controller.instance.data.moneyUpgradeEightLevel);
    public double MoneyUpgradeNineCost() => moneyUpgradeNineCost * Math.Pow(moneyUpgradeNineCostMultiplier, Controller.instance.data.moneyUpgradeNineLevel);
    public double MoneyUpgradeTenCost() => moneyUpgradeTenCost * Math.Pow(moneyUpgradeTenCostMultiplier, Controller.instance.data.moneyUpgradeTenLevel);
    // Формируем новую цену для улучшения ОчС
    public double HappyUpgradeOneCost() => happyUpgradeOneCost * Math.Pow(happyUpgradeOneCostMultiplier, Controller.instance.data.happyUpgradeOneLevel);
    public double HappyUpgradeTwoCost() => happyUpgradeTwoCost * Math.Pow(happyUpgradeTwoCostMultiplier, Controller.instance.data.happyUpgradeTwoLevel);
    public double HappyUpgradeThreeCost() => happyUpgradeThreeCost * Math.Pow(happyUpgradeThreeCostMultiplier, Controller.instance.data.happyUpgradeThreeLevel);
    public double HappyUpgradeFourCost() => happyUpgradeFourCost * Math.Pow(happyUpgradeFourCostMultiplier, Controller.instance.data.happyUpgradeFourLevel);
    public double HappyUpgradeFiveCost() => happyUpgradeFiveCost * Math.Pow(happyUpgradeFiveCostMultiplier, Controller.instance.data.happyUpgradeFiveLevel);
    public double HappyUpgradeSixCost() => happyUpgradeSixCost * Math.Pow(happyUpgradeSixCostMultiplier, Controller.instance.data.happyUpgradeSixLevel);
    public double HappyUpgradeSevenCost() => happyUpgradeSevenCost * Math.Pow(happyUpgradeSevenCostMultiplier, Controller.instance.data.happyUpgradeSevenLevel);
    public double HappyUpgradeEightCost() => happyUpgradeEightCost * Math.Pow(happyUpgradeEightCostMultiplier, Controller.instance.data.happyUpgradeEightLevel);
    public double HappyUpgradeNineCost() => happyUpgradeNineCost * Math.Pow(happyUpgradeNineCostMultiplier, Controller.instance.data.happyUpgradeNineLevel);
    public double HappyUpgradeTenCost() => happyUpgradeTenCost * Math.Pow(happyUpgradeTenCostMultiplier, Controller.instance.data.happyUpgradeTenLevel);

    // Покупаем улучшения Денег
    public void BuyMoneyUpgradeOne()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeOneCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeOneCost());

            data.moneyUpgradeOneLevel += 1;
            data.clickMoneyPerClick += 0.1;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeTwo()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeTwoCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeTwoCost());

            data.moneyUpgradeTwoLevel += 1;
            data.clickMoneyPerSecond += 1;

            UpdateMoneyPerSecUI();
            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeThree()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeThreeCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeThreeCost());

            data.moneyUpgradeThreeLevel += 1;
            data.clickMoneyPerSecond += 5;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeFour()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeFourCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeFourCost());

            data.moneyUpgradeFourLevel += 1;
            data.clickMoneyPerClick += 10;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeFive()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeFiveCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeFiveCost());

            data.moneyUpgradeFiveLevel += 1;
            data.clickMoneyPerSecond += 100;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeSix()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeSixCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeSixCost());

            data.moneyUpgradeSixLevel += 1;
            data.clickMoneyPerSecond += 5000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeSeven()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeSevenCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeSevenCost());

            data.moneyUpgradeSevenLevel += 1;
            data.clickMoneyPerClick += 5000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeEight()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeEightCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeEightCost());

            data.moneyUpgradeEightLevel += 1;
            data.clickMoneyPerSecond += 30000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeNine()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeNineCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeNineCost());

            data.moneyUpgradeNineLevel += 1;
            data.clickMoneyPerClick += 15000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    public void BuyMoneyUpgradeTen()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= MoneyUpgradeTenCost())
        {
            data.SubstractMoneyCount(MoneyUpgradeTenCost());

            data.moneyUpgradeTenLevel += 1;
            data.clickMoneyPerSecond += 400000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateMoneyUpgradeUI();
        }
    }
    // Покупаем улучшения Денег
    public void BuyHappyUpgradeOne()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeOneCost())
        {
            data.SubstractMoneyCount(HappyUpgradeOneCost());

            data.happyUpgradeOneLevel += 1;
            data.clickHappyPerClick += 0.2;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeTwo()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeTwoCost())
        {
            data.SubstractMoneyCount(HappyUpgradeTwoCost());

            data.happyUpgradeTwoLevel += 1;
            data.clickHappyPerClick += 0.5;

            _happyPerSecText.text = $"{Controller.instance.data.clickHappyPerSecond:F2}/с";
            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeThree()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeThreeCost())
        {
            data.SubstractMoneyCount(HappyUpgradeThreeCost());

            data.happyUpgradeThreeLevel += 1;
            data.clickHappyPerSecond += 0.5;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeFour()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeFourCost())
        {
            data.SubstractMoneyCount(HappyUpgradeFourCost());

            data.happyUpgradeFourLevel += 1;
            data.clickHappyPerSecond += 2;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeFive()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeFiveCost())
        {
            data.SubstractMoneyCount(HappyUpgradeFiveCost());

            data.happyUpgradeFiveLevel += 1;
            data.clickHappyPerClick += 10;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeSix()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeSixCost())
        {
            data.SubstractMoneyCount(HappyUpgradeSixCost());

            data.happyUpgradeSixLevel += 1;
            data.clickHappyPerSecond += 10;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeSeven()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeSevenCost())
        {
            data.SubstractMoneyCount(HappyUpgradeSevenCost());

            data.happyUpgradeSevenLevel += 1;
            data.clickHappyPerClick += 500;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeEight()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeEightCost())
        {
            data.SubstractMoneyCount(HappyUpgradeEightCost());

            data.happyUpgradeEightLevel += 1;
            data.clickHappyPerSecond += 300;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeNine()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeNineCost())
        {
            data.SubstractMoneyCount(HappyUpgradeNineCost());

            data.happyUpgradeNineLevel += 1;
            data.clickHappyPerClick += 3000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
    public void BuyHappyUpgradeTen()
    {
        var data = Controller.instance.data;

        if (data.GetMoneyCount() >= HappyUpgradeTenCost())
        {
            data.SubstractMoneyCount(HappyUpgradeTenCost());

            data.happyUpgradeTenLevel += 1;
            data.clickHappyPerSecond += 5000;

            Controller.instance.UpdateMoneyCountUI();
            UpdateHappyUpgradeUI();
        }
    }
}
