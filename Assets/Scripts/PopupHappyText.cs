using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupHappyText : MonoBehaviour
{
    private void Start()
    {
        GameObject parentObject = GameObject.Find("CatsScreen");
        transform.SetParent(parentObject.transform);

        TMP_Text text = gameObject.GetComponent<TMP_Text>();
        var click = Controller.instance.GetPowerHappyPerClick();
        text.text = "+" + click;
        text.CrossFadeAlpha(0, 2.5f, false);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 100);
        Destroy(gameObject, 2.5f);      
    }
}
