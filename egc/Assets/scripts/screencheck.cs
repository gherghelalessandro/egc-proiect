using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class screencheck : MonoBehaviour
{
    // Start is called before the first frame update

    public do_something[] lista;
    public GameObject go;
    public TextMeshPro textMeshPro;
    public string textc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<lista.Length; i++)
        {
            if (lista[i].active==false)
            {
                Destroy(go);
                textMeshPro.text = "R:" +textc;
                for(int j=0;j<lista.Length;j++)
                {
                    lista[j].active = false;
                }
            }
        }
    }
}
