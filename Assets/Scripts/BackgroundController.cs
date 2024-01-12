using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private RawImage _rawBackground;
    [SerializeField] private float _xPos, _yPos;

    private void Update()
    {
        _rawBackground.uvRect = new Rect(_rawBackground.uvRect.position + new Vector2(_xPos, _yPos) * Time.deltaTime, _rawBackground.uvRect.size);
    }
}
