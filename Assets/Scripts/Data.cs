using System.Collections;
using System.Collections.Generic;
using BreakInfinity;

public class Data
{
    // �������� ��������� ���� //
    private double _happyCount; // ���� ������� (���)
    private double _moneyCount; // ������
    // ��������� ������ //
    public double clickMoneyPerClick; // ����� �� ����
    public double clickHappyPerClick; // ��� �� ����
    // ��������� �� ����� //
    public double clickMoneyPerSecond; // ����� �� �������
    public double clickHappyPerSecond; // ��� �� �������
    // ������ ��������� ����� //
    public int moneyUpgradeOneLevel; // ������� ������� ���������
    public int moneyUpgradeTwoLevel; // ������� ������� ���������
    public int moneyUpgradeThreeLevel; // ������� �������� ���������
    public int moneyUpgradeFourLevel; // ������� ���������� ���������
    public int moneyUpgradeFiveLevel; // ������� ������ ���������
    public int moneyUpgradeSixLevel; // ������� ������� ���������
    public int moneyUpgradeSevenLevel; // ������� �������� ���������
    public int moneyUpgradeEightLevel; // ������� �������� ���������
    public int moneyUpgradeNineLevel; // ������� �������� ���������
    public int moneyUpgradeTenLevel; // ������� �������� ���������
    // ������ ��������� ��� //
    public int happyUpgradeOneLevel; // ������� ������� ���������
    public int happyUpgradeTwoLevel; // ������� ������� ���������
    public int happyUpgradeThreeLevel; // ������� �������� ���������
    public int happyUpgradeFourLevel; // ������� ���������� ���������
    public int happyUpgradeFiveLevel; // ������� ������ ���������
    public int happyUpgradeSixLevel; // ������� ������� ���������
    public int happyUpgradeSevenLevel; // ������� �������� ���������
    public int happyUpgradeEightLevel; // ������� �������� ���������
    public int happyUpgradeNineLevel; // ������� �������� ���������
    public int happyUpgradeTenLevel; // ������� ������� ���������

    // ��� ������������� ���������� �������� ��������� �� ����
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
    /// �������� ���������� ����� �������
    /// </summary>
    /// <returns></returns>
    public double GetHappyCount()
    {
        return _happyCount;
    }
    /// <summary>
    /// �������� ���������� �����
    /// </summary>
    /// <returns></returns>
    public double GetMoneyCount()
    {
        return _moneyCount;
    }
    /// <summary>
    /// �������� � ��� ��������
    /// </summary>
    /// <param name="value">����������� ��������</param>
    public void AddHappyCount(double value)
    {
        _happyCount += value;
    }
    /// <summary>
    /// �������� � ������� ��������
    /// </summary>
    /// <param name="value">����������� ��������</param>
    public void AddMoneyCount(double value)
    {
        _moneyCount += value;
    }
    /// <summary>
    /// ������ �� ����� ��������
    /// </summary>
    /// <param name="value">���������� ��������</param>
    public void SubstractMoneyCount(double value)
    {
        _moneyCount -= value;
    }
}
