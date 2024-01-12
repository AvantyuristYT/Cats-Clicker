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
    // Уровни улучшений денег //
    public int moneyUpgradeOneLevel; // Уровень первого улучшения
    // Уровни улучшений ОчС //
    public int happyUpgradeOneLevel; // Уровень первого улучшения

    // При инициализации сбрасывать основные параметры до нуля
    public Data()
    {
        _happyCount = 0;
        _moneyCount = 0;

        moneyUpgradeOneLevel = 0;
        happyUpgradeOneLevel = 0;
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
