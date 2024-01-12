using System.Collections;
using System.Collections.Generic;
using BreakInfinity;

public class Data
{
    // Основные параметры игры //
    private double _happyCount; // Очки счастья (ОчС)
    private double _moneyCount; // Деньги
    // Параметры кликов //
    public double clickMoneyPerClick; // Денег за клик
    public double clickHappyPerClick; // ОчС за клик
    // Параметры за время //
    public double clickMoneyPerSecond; // Денег за секунду
    public double clickHappyPerSecond; // ОчС за секунду
    // Уровни улучшений денег //
    public int moneyUpgradeOneLevel; // Уровень первого улучшения
    public int moneyUpgradeTwoLevel; // Уровень второго улучшения
    public int moneyUpgradeThreeLevel; // Уровень третьего улучшения
    public int moneyUpgradeFourLevel; // Уровень четвертого улучшения
    public int moneyUpgradeFiveLevel; // Уровень пятого улучшения
    public int moneyUpgradeSixLevel; // Уровень шестого улучшения
    public int moneyUpgradeSevenLevel; // Уровень седьмого улучшения
    public int moneyUpgradeEightLevel; // Уровень восьмого улучшения
    public int moneyUpgradeNineLevel; // Уровень девятого улучшения
    public int moneyUpgradeTenLevel; // Уровень десятого улучшения
    // Уровни улучшений ОчС //
    public int happyUpgradeOneLevel; // Уровень первого улучшения
    public int happyUpgradeTwoLevel; // Уровень второго улучшения
    public int happyUpgradeThreeLevel; // Уровень третьего улучшения
    public int happyUpgradeFourLevel; // Уровень четвертого улучшения
    public int happyUpgradeFiveLevel; // Уровень пятого улучшения
    public int happyUpgradeSixLevel; // Уровень шестого улучшения
    public int happyUpgradeSevenLevel; // Уровень седьмого улучшения
    public int happyUpgradeEightLevel; // Уровень восьмого улучшения
    public int happyUpgradeNineLevel; // Уровень девятого улучшения
    public int happyUpgradeTenLevel; // Уровень деятого улучшения

    // При инициализации сбрасывать основные параметры до нуля
    public Data()
    {
        _happyCount = 0;
        _moneyCount = 0;

        moneyUpgradeOneLevel = 0;
        moneyUpgradeTwoLevel = 0;
        moneyUpgradeThreeLevel = 0;
        moneyUpgradeFourLevel = 0;
        moneyUpgradeFiveLevel = 0;
        moneyUpgradeSixLevel = 0;
        moneyUpgradeSevenLevel = 0;
        moneyUpgradeEightLevel = 0;
        moneyUpgradeNineLevel = 0;
        moneyUpgradeTenLevel = 0;

        happyUpgradeOneLevel = 0;
        happyUpgradeTwoLevel = 0;
        happyUpgradeThreeLevel = 0;
        happyUpgradeFourLevel = 0;
        happyUpgradeFiveLevel = 0;
        happyUpgradeSixLevel = 0;
        happyUpgradeSevenLevel = 0;
        happyUpgradeEightLevel = 0;
        happyUpgradeNineLevel = 0;
        happyUpgradeTenLevel = 0;
    }

    /// <summary>
    /// Получить количество Очков Счастья
    /// </summary>
    /// <returns></returns>
    public double GetHappyCount()
    {
        return _happyCount;
    }
    /// <summary>
    /// Получить количество Денег
    /// </summary>
    /// <returns></returns>
    public double GetMoneyCount()
    {
        return _moneyCount;
    }
    /// <summary>
    /// Добавить к ОчС значение
    /// </summary>
    /// <param name="value">Добавляемое значение</param>
    public void AddHappyCount(double value)
    {
        _happyCount += value;
    }
    /// <summary>
    /// Добавить к Деньгам значение
    /// </summary>
    /// <param name="value">Добавляемое значение</param>
    public void AddMoneyCount(double value)
    {
        _moneyCount += value;
    }
    /// <summary>
    /// Отнять от Денег значение
    /// </summary>
    /// <param name="value">Убавляемое значение</param>
    public void SubstractMoneyCount(double value)
    {
        _moneyCount -= value;
    }
}
