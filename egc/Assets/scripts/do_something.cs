using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class do_something : MonoBehaviour
{
    // Start is called before the first frame update

    
    

    public bool do_some = false;
    public bool iscorect=false;
    public bool active = true;
    public bool kill = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(do_some==true)
        {
            if(iscorect==true)
            {
                var render = gameObject.GetComponent<Renderer>();
                render.material.SetColor("_Color", UnityEngine.Color.green);
            }
            else
            {
                var render = gameObject.GetComponent<Renderer>();
                render.material.SetColor("_Color", UnityEngine.Color.red);
            }
        }
        
    }
    
}
