using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    

    void Start()
    {
        Debug.Log("Bat Dau");
        _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("Fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("Son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("Si").GetComponent<AudioSource>();
        
    }

 
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.D) )
        {
            Debug.Log("press D");
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("press R");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("press M");
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("press F");
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("press s");
            _son.Play();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("press L");
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("press W");
            _si.Play();
        }
    }
}
