using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class op1 : MonoBehaviour
{
    public int Cal1 = 0;
    public void HandleInpuntData(int val)
    {
        if (val == 0)
        {
            Debug.Log("Seleccionar");
            Cal1 = 0;
        }
        if (val == 1)
        {
            Debug.Log("Aprobado");
            Cal1 = 1;
        }
        if (val == 2)
        {
            Debug.Log("Reprobado");
            Cal1 = 2;
        }
    }
}
