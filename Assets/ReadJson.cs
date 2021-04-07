using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadJson : MonoBehaviour
{
    public TextAsset textJSON;
    public Transform tabla;
    public GameObject plantillaest;
    public GameObject seleccion;
    public Transform tablase;
    string filePath;
    string jsonString;
    int cantidadRegistros = 6;
    public double not1, not2, not3, not4, not5, not6;
    public string nam1 , nam2,nam3 , nam4, nam5,nam6;
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

    [ContextMenu("Leer")]
    public void Leer()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);
        print(myPlayerList);

    }


    [ContextMenu("Crear Tabla")]
    void CrearTabla()
    {
        for (int i = 0; i < cantidadRegistros; i++)
        {
            GameObject inst = Instantiate(plantillaest, tabla);
            inst.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, i * -90f);
            inst.name = i.ToString();
        }
    
    }

    [ContextMenu("Pasar datos a tabla")]
    void PasarDatosATabla()
    {
        for (int i = 0; i < cantidadRegistros; i++)
        {
            tabla.GetChild(i).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = myPlayerList.datos[i].nombre;
            tabla.GetChild(i).GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = myPlayerList.datos[i].apellido;
            tabla.GetChild(i).GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = myPlayerList.datos[i].codigo.ToString();
            tabla.GetChild(i).GetChild(3).GetComponent<TMPro.TextMeshProUGUI>().text = myPlayerList.datos[i].correo;
            tabla.GetChild(i).GetChild(4).GetComponent<TMPro.TextMeshProUGUI>().text = myPlayerList.datos[i].nota.ToString();
        }

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

    }

    
    void Start()
    {
        Leer();
        CrearTabla();
        PasarDatosATabla();
    }

    void Update()
    {
        
    }
}
