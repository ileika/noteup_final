using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BTverificardrag : MonoBehaviour
{
    //Verificar contenedores
    public DROP Verificar;
    public DROP2 Verificar2;
    public DROP3 Verificar3;
    public DROP4 Verificar4;
    public DROP5 Verificar5;
    public DROP6 Verificar6;
    public DROP7 Verificar7;
    public DROP8 Verificar8;
    public DROP9 Verificar9;
    public DROP10 Verificar10;
    public DROP11 Verificar11;
    public DROP12 Verificar12;
    public int ValorSi1;
    public int ValorSi2;
    public int ValorSi3;
    public int ValorSi4;
    public int ValorSi5;
    public int ValorSi6;
    public int ValorSi7;
    public int ValorSi8;
    public int ValorSi9;
    public int ValorSi10;
    public int ValorSi11;
    public int ValorSi12;

    int cont1 = 0;
    int cont2 = 0;
    int cont3 = 0;
    int cont4 = 0;
    int cont5 = 0;
    int cont6 = 0;
    int contfinal = 0;

    public string nombre;

    //Notas
    public read2json NotasFinales;
    double NF1;
    double NF2;
    double NF3;
    double NF4;
    double NF5;
    double NF6;


    public void BOTON()
    {
        // Verificar si son aprobados
        Verificar = FindObjectOfType<DROP>();
        Verificar2 = FindObjectOfType<DROP2>();
        Verificar3 = FindObjectOfType<DROP3>();
        Verificar4 = FindObjectOfType<DROP4>();
        Verificar5 = FindObjectOfType<DROP5>();
        Verificar6 = FindObjectOfType<DROP6>();
        Verificar7 = FindObjectOfType<DROP7>();
        Verificar8 = FindObjectOfType<DROP8>();
        Verificar9 = FindObjectOfType<DROP9>();
        Verificar10 = FindObjectOfType<DROP10>();
        Verificar11 = FindObjectOfType<DROP11>();
        Verificar12 = FindObjectOfType<DROP12>();
        ValorSi1 = Verificar.VariableD1;
        ValorSi2 = Verificar2.VariableD2;
        ValorSi3 = Verificar3.VariableD3;
        ValorSi4 = Verificar4.VariableD4;
        ValorSi5 = Verificar5.VariableD5;
        ValorSi6 = Verificar6.VariableD6;
        ValorSi7 = Verificar7.VariableD7;
        ValorSi8 = Verificar8.VariableD8;
        ValorSi9 = Verificar9.VariableD9;
        ValorSi10 = Verificar10.VariableD10;
        ValorSi11 = Verificar11.VariableD11;
        ValorSi12 = Verificar12.VariableD12;
        //Verificar si son reprobados

        //Notas de los estudiantes
        NotasFinales = FindObjectOfType<read2json>();
        NF1 = NotasFinales.not1;
        NF2 = NotasFinales.not2;
        NF3 = NotasFinales.not3;
        NF4 = NotasFinales.not4;
        NF5 = NotasFinales.not5;
        NF6 = NotasFinales.not6;

        Debug.Log(NF1);
        Debug.Log(NF2);
        Debug.Log(NF3);
        Debug.Log(NF4);
        Debug.Log(NF5);
        Debug.Log(NF6);
        Debug.Log(ValorSi1);
        Debug.Log(ValorSi2);
        Debug.Log(ValorSi3);
        Debug.Log(ValorSi4);
        Debug.Log(ValorSi5);
        Debug.Log(ValorSi6);
        Debug.Log(ValorSi7);
        Debug.Log(ValorSi8);
        Debug.Log(ValorSi9);
        Debug.Log(ValorSi10);
        Debug.Log(ValorSi11);
        Debug.Log(ValorSi12);

        //Estudiante 1
        if ((ValorSi1 == 1 && NF1 >= 3))
        {
            Debug.Log("Correcto estudiante 1a");
            cont1 = 1;
        }
        if ((ValorSi7 == 1 && NF1 >= 3))
        {
            Debug.Log("Incorrecto estudiante 1b");
            cont1 = 0;
        }
        if ((ValorSi1 == 1 && NF1 < 3))
        {
            Debug.Log("Incorrecto estudiante 1c");
            cont1 = 0;
        }
        if ((ValorSi7 == 1 && NF1 < 3))
        {
            Debug.Log("Correcto estudiante 1d");
            cont1 = 1;
        }


        //Estudiante 2
        if ((ValorSi2 == 1 && NF2 >= 3))
        {
            Debug.Log("Correcto estudiante 2");
            cont2 = 1;
        }
        if ((ValorSi8 == 1 && NF2 >= 3))
        {
            Debug.Log("Incorrecto estudiante 2");
            cont2 = 0;
        }
        if ((ValorSi2 == 1 && NF2 < 3))
        {
            Debug.Log("Incorrecto estudiante 2");
            cont2 = 0;
        }
        if ((ValorSi8 == 1 && NF2 < 3))
        {
            Debug.Log("Correcto estudiante 2");
            cont2 = 1;
        }

        //Estudiante 3
        if ((ValorSi3 == 1 && NF3 >= 3))
        {
            Debug.Log("Correcto estudiante 3");
            cont3 = 1;
        }
        if ((ValorSi9 == 1 && NF3 >= 3))
        {
            Debug.Log("Incorrecto estudiante 3");
            cont3 = 0;
        }
        if ((ValorSi3 == 1 && NF3 < 3))
        {
            Debug.Log("Incorrecto estudiante 3");
            cont3 = 0;
        }
        if ((ValorSi9 == 1 && NF3 < 3))
        {
            Debug.Log("Correcto estudiante 3");
            cont3 = 1;
        }

        //Estudiante 4
        if ((ValorSi4 == 1 && NF4 >= 3))
        {
            Debug.Log("Correcto estudiante 4");
            cont4 = 1;
        }
        if ((ValorSi10 == 1 && NF4 >= 3))
        {
            Debug.Log("Incorrecto estudiante 4");
            cont4 = 0;
        }
        if ((ValorSi4 == 1 && NF4 < 3))
        {
            Debug.Log("Incorrecto estudiante 4");
            cont4 = 0;
        }
        if ((ValorSi10 == 1 && NF4 < 3))
        {
            Debug.Log("Correcto estudiante 4");
            cont4 = 1;
        }

        //Estudiante 5
        if ((ValorSi5 == 1 && NF5 >= 3))
        {
            Debug.Log("Correcto estudiante 5");
            cont5 = 1;
        }
        if ((ValorSi11 == 1 && NF5 >= 3))
        {
            Debug.Log("Incorrecto estudiante 5");
            cont5 = 0;
        }
        if ((ValorSi5 == 1 && NF5 < 3))
        {
            Debug.Log("Incorrecto estudiante 5");
            cont5 = 0;
        }
        if ((ValorSi11 == 1 && NF5 < 3))
        {
            Debug.Log("Correcto estudiante 5");
            cont5 = 1;
        }

        //Estudiante 6
        if ((ValorSi6 == 1 && NF6 >= 3))
        {
            Debug.Log("Correcto estudiante 6");
            cont6 = 1;
        }
        if ((ValorSi12 == 1 && NF6 >= 3))
        {
            Debug.Log("Incorrecto estudiante 6");
            cont6 = 0;
        }
        if ((ValorSi6 == 1 && NF6 < 3))
        {
            Debug.Log("Incorrecto estudiante 6");
            cont6 = 0;
        }
        if ((ValorSi12 == 1 && NF6 < 3))
        {
            Debug.Log("Correcto estudiante 6");
            cont6 = 1;
        }


        contfinal = cont1 + cont2 + cont3 + cont4 + cont5 + cont6;
        Debug.Log(contfinal);

        if(contfinal == 6)
        {
            Application.Quit();
        }
        else
        {
            nombre = "Error";
            SceneManager.LoadScene(nombre);
        }
    }
}
