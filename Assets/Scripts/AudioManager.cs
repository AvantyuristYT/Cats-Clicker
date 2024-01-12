using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake() => instance = this;

    [SerializeField] private AudioSource _soundClickMainButton;
    [SerializeField] private AudioSource _soundClickUIButton;
    [SerializeField] private AudioSource _soundClickBuyUpgrade;

    public void PlaySoundClickMainButton()
    {
        _soundClickMainButton.Play();
    }

    public void PlaySoundClickUIButton()
    {
        _soundClickUIButton.Play();
    }

    public void PlaySoundBuyUpgrade()
    {
        _soundClickBuyUpgrade.Play();
    }
}
