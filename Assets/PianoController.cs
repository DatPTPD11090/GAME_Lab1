using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _Do, _Re, _Mi, _Fa, _Son, _La, _Si;
    // Start is called before the first frame update
    void Start()
    {
        _Do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _Re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _Mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        _Fa = GameObject.FindWithTag("Fa").GetComponent<AudioSource>();
        _Son = GameObject.FindWithTag("Son").GetComponent<AudioSource>();
        _La = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        _Si = GameObject.FindWithTag("Si").GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            _Do.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _Re.Play();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            _Mi.Play();
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            _Fa.Play();
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            _Son.Play();
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            _La.Play();
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            _Si.Play();
        }

    }
}
