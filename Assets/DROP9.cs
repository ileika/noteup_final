using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DROP9 : MonoBehaviour, IDropHandler
{
    public DRAGDROP ver1;
    public DRAGDROP2 ver2;
    public DRAGDROP3 ver3;
    public DRAGDROP4 ver4;
    public DRAGDROP5 ver5;
    public DRAGDROP6 ver6;
    public bool rre1;
    public bool rre2;
    public bool rre3;
    public bool rre4;
    public bool rre5;
    public bool rre6;
    public int VariableD9 = 0;


    public void OnDrop(PointerEventData eventData)
    {
        ver1 = FindObjectOfType<DRAGDROP>();
        ver2 = FindObjectOfType<DRAGDROP2>();
        ver3 = FindObjectOfType<DRAGDROP3>();
        ver4 = FindObjectOfType<DRAGDROP4>();
        ver5 = FindObjectOfType<DRAGDROP5>();
        ver6 = FindObjectOfType<DRAGDROP6>();
        rre1 = ver1.repet1;
        rre2 = ver2.repet2;
        rre3 = ver3.repet3;
        rre4 = ver4.repet4;
        rre5 = ver5.repet5;
        rre6 = ver6.repet6;

        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if ((rre1 == true) || (rre2 == true) || (rre3 == true) || (rre4 == true) || (rre5 == true) || (rre6 == true))
            {
                VariableD9 = 1;
            }
        }

    }
}
