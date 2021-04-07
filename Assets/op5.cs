using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class op5 : MonoBehaviour
{
    public int Cal5 = 0;
    public void HandleInpuntData(int val)
    {
        if (val == 0)
        {
            Debug.Log("Seleccionar");
            Cal5 = 0;
        }
        if (val == 1)
        {
            Debug.Log("Aprobado");
            Cal5 = 1;
        }
        if (val == 2)
        {
            Debug.Log("Reprobado");
            Cal5 = 2;
        }
    }
}
