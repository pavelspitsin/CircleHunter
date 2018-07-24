using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler,IPointerUpHandler
{

    public Color NormalColor;
    public Color HighlightedColor;
    public Color PressedColor;


    private Text _btnText;

    public void Awake()
    {
        _btnText = gameObject.GetComponentInChildren<Text>();
        _btnText.color = NormalColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _btnText.color = PressedColor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _btnText.color = HighlightedColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _btnText.color = HighlightedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _btnText.color = NormalColor;
    }
}
