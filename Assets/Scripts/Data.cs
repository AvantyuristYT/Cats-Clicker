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
    // ������ ��������� ����� //
    public int moneyUpgradeOneLevel; // ������� ������� ���������
    // ������ ��������� ��� //
    public int happyUpgradeOneLevel; // ������� ������� ���������

    // ��� ������������� ���������� �������� ��������� �� ����
    public Data()
    {
        _happyCount = 0;
        _moneyCount = 0;

        moneyUpgradeOneLevel = 0;
        happyUpgradeOneLevel = 0;
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
