using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class op2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int Cal2 = 0;
    public void HandleInpuntData(int val)
    {
        if (val == 0)
        {
            Debug.Log("Seleccionar");
            Cal2 = 0;
        }
        if (val == 1)
        {
            Debug.Log("Aprobado");
            Cal2 = 1;
        }
        if (val == 2)
        {
            Debug.Log("Reprobado");
            Cal2 = 2;
        }
    }
}
