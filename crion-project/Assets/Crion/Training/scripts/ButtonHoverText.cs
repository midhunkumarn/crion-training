using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonHoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text buttonText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.gameObject.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.gameObject.SetActive(true);
    }
}