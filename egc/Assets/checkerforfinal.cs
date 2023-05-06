using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkerforfinal : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[] nivele = { false,false,false };

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("portal 1") != null && nivele[0]==true)
        {
            var render = GameObject.Find("portal 1").GetComponent<Renderer>();
            render.material.SetColor("_Color", UnityEngine.Color.green);
        }
        if (GameObject.Find("portal 2") != null && nivele[1] == true)
        {
            var render = GameObject.Find("portal 2").GetComponent<Renderer>();
            render.material.SetColor("_Color", UnityEngine.Color.green);
        }
        if (GameObject.Find("portal 3") != null && nivele[2] == true)
        {
            var render = GameObject.Find("portal 3").GetComponent<Renderer>();
            render.material.SetColor("_Color", UnityEngine.Color.green);
        }

        
    }
    private void FixedUpdate()
    {
        if (GameObject.Find("portal 4") != null && nivele[0] == true && nivele[1] == true && nivele[2] == true)
        {
            var render = GameObject.Find("portal 4").GetComponent<Renderer>();
            render.material.SetColor("_Color", UnityEngine.Color.white);
            var portal = GameObject.Find("portal 4").GetComponent<checknivel>();
            portal.Scena = "FINALE";
        }
    }
}
