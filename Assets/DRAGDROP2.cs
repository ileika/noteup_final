using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DRAGDROP2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public bool repet2 = false;
    public read2json calificaf2;
    public double nota2ff;
    public double nes2;
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnPointerDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        repet2 = true;
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; ;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        repet2 = true;
        calificaf2 = FindObjectOfType<read2json>();
        nota2ff = calificaf2.not2;
        nes2 = nota2ff;
        Debug.Log("OnEndDrag");
        Debug.Log(nes2);
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}
