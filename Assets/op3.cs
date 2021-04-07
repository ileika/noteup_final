using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class op3 : MonoBehaviour
{
    public int Cal3 = 0;
    public void HandleInpuntData(int val)
    {
        if (val == 0)
        {
            Debug.Log("Seleccionar");
            Cal3 = 0;
        }
        if (val == 1)
        {
            Debug.Log("Aprobado");
            Cal3 = 1;
        }
        if (val == 2)
        {
            Debug.Log("Reprobado");
            Cal3 = 2;
        }
    }
}
