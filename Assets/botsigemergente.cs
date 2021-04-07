using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class botsigemergente : MonoBehaviour
{
    public TextMeshProUGUI error;
    public op1 val1;
    public op2 val2;
    public op3 val3;
    public op4 val4;
    public op5 val5;
    public op6 val6;
    public int asig1;
    public int asig2;
    public int asig3;
    public int asig4;
    public int asig5;
    public int asig6;
    public ReadJson leer1;
    public double nota1, nota2, nota3, nota4, nota5, nota6;


    public void CambiarEscena(string nombre)
    {
        val1 = FindObjectOfType<op1>();
        val2 = FindObjectOfType<op2>();
        val3 = FindObjectOfType<op3>();
        val4 = FindObjectOfType<op4>();
        val5 = FindObjectOfType<op5>();
        val6 = FindObjectOfType<op6>();

        asig1 = val1.Cal1;
        asig2 = val2.Cal2;
        asig3 = val3.Cal3;
        asig4 = val4.Cal4;
        asig5 = val5.Cal5;
        asig6 = val6.Cal6;

        leer1 = FindObjectOfType<ReadJson>();
        nota1 = leer1.not1;
        nota2 = leer1.not2;
        nota3 = leer1.not3;
        nota4 = leer1.not4;
        nota5 = leer1.not5;
        nota6 = leer1.not6;
        //nota1
        if ((asig1 == 1 && nota1>= 3) || (asig1 == 2 && nota1 < 3))
        {

            if ((asig2 == 1 && nota2 >= 3)|| (asig2 == 2 && nota2 < 3))
            {
                

                if ((asig3 == 1 && nota3 >= 3)|| (asig3 == 2 && nota3 < 3))
                {
                 

                    if ((asig4 == 1 && nota4 >= 3)|| (asig4 == 2 && nota4 < 3))
                    {
                       
                        if ((asig5 == 1 && nota5 >= 3 )|| (asig5 == 2 && nota5 < 3))
                        {
                            
                            if ((asig6 == 1 && nota6 >= 3)|| (asig6 == 2 && nota6 < 3))
                            {
                                print("Cambiando a la escena" + nombre);
                                SceneManager.LoadScene(nombre);
                            }

                            else
                            {

                                error.text = "Error en los datos asignados, porfavor vuelva a intentar";
                            }
                        }
                        else
                        {

                            error.text = "Error en los datos asignados, porfavor vuelva a intentar";
                        }
                    }
                    else
                    {

                        error.text = "Error en los datos asignados, porfavor vuelva a intentar";
                    }
                }
                else
                {

                    error.text = "Error en los datos asignados, porfavor vuelva a intentar";
                }
            }

            else
            {

                error.text = "Error en los datos asignados, porfavor vuelva a intentar";
            }
        }

        

    
        else 
        {

            error.text = "Error en los datos asignados, porfavor vuelva a intentar";
        }



    }



    public void Salir()
    {
        print("Saliendo del juego");
        Application.Quit();
    }


}
