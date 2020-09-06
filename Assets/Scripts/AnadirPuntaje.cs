using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnadirPuntaje : MonoBehaviour
{
    private AudioSource punto;
    

    private void Start()
    {
        punto = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Puntaje.puntaje++;
        punto.mute = false;
        punto.Play();
    }
    
}
