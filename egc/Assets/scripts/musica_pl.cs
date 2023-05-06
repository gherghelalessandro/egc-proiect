using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica_pl : MonoBehaviour
{
    public AudioSource sursa;
    // Start is called before the first frame update
    private void Awake()
    { 
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        sursa.Play();
        sursa.loop = true;
    }
}
