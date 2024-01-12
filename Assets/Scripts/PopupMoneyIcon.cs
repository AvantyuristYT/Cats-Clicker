using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMoneyIcon : MonoBehaviour
{
    private Rigidbody2D rigidBodyPopupIcon;
    private void Start()
    {
        GameObject parentObject = GameObject.Find("WorldScreen");
        transform.SetParent(parentObject.transform);

        rigidBodyPopupIcon = gameObject.GetComponent<Rigidbody2D>();
        rigidBodyPopupIcon.velocity = new Vector2(0, 0);
        rigidBodyPopupIcon.AddForce(new Vector2(Random.Range(-80, 80), Random.Range(30, 70)), ForceMode2D.Impulse);
        Image imgIcon = gameObject.GetComponent<Image>();
        imgIcon.CrossFadeAlpha(0, 2.5f, false);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 100);
        Destroy(gameObject, 2.5f);
    }
}
