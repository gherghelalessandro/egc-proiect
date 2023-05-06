using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checknivel : MonoBehaviour
{
    public int i = -1;
    public string Scena="main hub";
    public checkerforfinal c;
    // Start is called before the first frame update
    void Start()
    {
        c = GameObject.Find("nivele check").GetComponent<checkerforfinal>();
    }

    // Update is called once per frame
  

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            if(i>-1&&i<3)
            {
                c.nivele[i] = true;
            }

            if (Scena == "EXIT")
            {
                Application.Quit();
            }
            else if(Scena!="IGNORE")
            {
                SceneManager.LoadScene(Scena);
            }
            
        }
    }
}
