using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float x=0.1f, y,z;
    public bool active = true;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(active==true)
        {
            transform.Translate(new Vector3(x, y, z) * Time.deltaTime);
        }
       
    }
}
