using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class op4 : MonoBehaviour
{
    public int Cal4 = 0;
    public void HandleInpuntData(int val)
    {
        if (val == 0)
        {
            Debug.Log("Seleccionar");
            Cal4 = 0;
        }
        if (val == 1)
        {
            Debug.Log("Aprobado");
            Cal4 = 1;
        }
        if (val == 2)
        {
            Debug.Log("Reprobado");
            Cal4 = 2;
        }
    }
}
