using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dont : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sunet;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("wall");

        if (objs.Length > 1)
        {
            sunet.Play();
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }
}
