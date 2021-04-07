using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class read2json : MonoBehaviour
{
    public TextAsset textJSON;
    string filePath;
    string jsonString;
    int cantidadRegistros = 6;
    public TextMeshProUGUI est1t;
    public TextMeshProUGUI est2t;
    public TextMeshProUGUI est3t;
    public TextMeshProUGUI est4t;
    public TextMeshProUGUI est5t;
    public TextMeshProUGUI est6t;
    public TextMeshProUGUI est1t1;
    public TextMeshProUGUI est2t2;
    public TextMeshProUGUI est3t3;
    public TextMeshProUGUI est4t4;
    public TextMeshProUGUI est5t5;
    public TextMeshProUGUI est6t6;
    public double not1, not2, not3, not4, not5, not6;
    public string nam1, nam2, nam3, nam4, nam5, nam6;
    public string apl1, apl2, apl3, apl4, apl5, apl6;
    private object listaestudiantes;

    [System.Serializable]
    public class Player
    {
        public string nombre;
        public string apellido;
        public int codigo;
        public string correo;
        public double nota;
    }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] datos;
    }

    public PlayerList myPlayerList = new PlayerList();


    public void Leer()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);
        print(myPlayerList);

        not1 = myPlayerList.datos[0].nota;
        not2 = myPlayerList.datos[1].nota;
        not3 = myPlayerList.datos[2].nota;
        not4 = myPlayerList.datos[3].nota;
        not5 = myPlayerList.datos[4].nota;
        not6 = myPlayerList.datos[5].nota;


        nam1 = myPlayerList.datos[0].nombre;
        nam2 = myPlayerList.datos[1].nombre;
        nam3 = myPlayerList.datos[2].nombre;
        nam4 = myPlayerList.datos[3].nombre;
        nam5 = myPlayerList.datos[4].nombre;
        nam6 = myPlayerList.datos[5].nombre;



        apl1 = myPlayerList.datos[0].apellido;
        apl2 = myPlayerList.datos[1].apellido;
        apl3 = myPlayerList.datos[2].apellido;
        apl4 = myPlayerList.datos[3].apellido;
        apl5 = myPlayerList.datos[4].apellido;
        apl6 = myPlayerList.datos[5].apellido;

        Debug.Log(nam1);

        est1t.text = nam1 + " " + apl1;
        est2t.text = nam2 + " " + apl2;
        est3t.text = nam3 + " " + apl3;
        est4t.text = nam4 + " " + apl4;
        est5t.text = nam5 + " " + apl5;
        est6t.text = nam6 + " " + apl6;
        est1t1.text = nam1 + " " + apl1;
        est2t2.text = nam2 + " " + apl2;
        est3t3.text = nam3 + " " + apl3;
        est4t4.text = nam4 + " " + apl4;
        est5t5.text = nam5 + " " + apl5;
        est6t6.text = nam6 + " " + apl6;
    }

    

    void Start()
    {
        Leer();
       
    }

  
}
