using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _Do, _Re, _Mi, _Fa, _Son, _La, _Si;
    SpriteRenderer _luc, _vang, _den, _xanh, _trang, _hong, _tim;
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
        //--------------------------------------------------------------
        _luc = GameObject.FindWithTag("Do").GetComponent<SpriteRenderer>();
        _vang = GameObject.FindWithTag("Re").GetComponent<SpriteRenderer>();
        _den = GameObject.FindWithTag("Mi").GetComponent<SpriteRenderer>();
        _xanh = GameObject.FindWithTag("Fa").GetComponent<SpriteRenderer>();
        _trang = GameObject.FindWithTag("Son").GetComponent<SpriteRenderer>();
        _hong = GameObject.FindWithTag("La").GetComponent<SpriteRenderer>();
        _tim = GameObject.FindWithTag("Si").GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            _Do.Play();
        }
        if (Input.GetKey(KeyCode.E)) 
        {
            _luc.color = Color.black;
        }
        else 
        {
            _luc.color= Color.white;
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _Re.Play();
        }
        if (Input.GetKey(KeyCode.R))
        {
            _vang.color = Color.black;
        }
        else
        {
            _vang.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            _Mi.Play();
        }
        if (Input.GetKey(KeyCode.T))
        {
            _den.color = Color.black;
        }
        else
        {
            _den.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            _Fa.Play();
        }
        if (Input.GetKey(KeyCode.Y))
        {
            _xanh.color = Color.black;
        }
        else
        {
            _xanh.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            _Son.Play();
        }
        if (Input.GetKey(KeyCode.U))
        {
            _trang.color = Color.black;
        }
        else
        {
            _trang.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            _La.Play();
        }
        if (Input.GetKey(KeyCode.I))
        {
            _hong.color = Color.black;
        }
        else
        {
            _hong.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            _Si.Play();
        }
        if (Input.GetKey(KeyCode.O))
        {
            _tim.color = Color.black;
        }
        else
        {
            _tim.color = Color.white;
        }

    }
}
