using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanelsController : MonoBehaviour
{
    [Header("Главные экраны")]
    [SerializeField] private GameObject _catsScreen;
    [SerializeField] private GameObject _worldScreen;
    private List<GameObject> _gamePanelsList = new List<GameObject>();

    private void Awake()
    {
        _gamePanelsList.Add(_catsScreen);
        _gamePanelsList.Add(_worldScreen);
    }

    private void Start()
    {
        SetActivePanel(_catsScreen);
    }

    /// <summary>
    /// Включает выбранное окно и закрывает другие
    /// </summary>
    /// <param name="currentWindow">Объект, который включаем.</param>
    private void SetActivePanel(GameObject currentWindow)
    {
        foreach (GameObject expectedWindow in _gamePanelsList)
        {
            if (expectedWindow == currentWindow)
            {
               expectedWindow.SetActive(true);
            }
            else
            {
                expectedWindow.SetActive(false);
            }
        }
    }

    public void OpenCatsScreen()
    {
        SetActivePanel(_catsScreen);
        AudioManager.instance.PlaySoundClickUIButton();
    }

    public void OpenWorldScreen()
    {
        SetActivePanel(_worldScreen);
        AudioManager.instance.PlaySoundClickUIButton();
    }
}
