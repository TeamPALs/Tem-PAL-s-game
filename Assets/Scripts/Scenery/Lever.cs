﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{


 //   public GameObject FenceObject;
    public Sprite opened;
    public Sprite closed;

    private KeyDoor kd;
    // Use this for initialization
    void Start()
    {
        kd = GetComponent<KeyDoor>();
        gameObject.GetComponent<SpriteRenderer>().sprite = closed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Fred" || col.transform.tag == "Zwei" || col.transform.tag == "Dog" || col.transform.tag == "Velma")
        {
             gameObject.GetComponent<SpriteRenderer>().sprite = opened;
            FenceObject.gameObject.SetActive(false);
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }*/

    public void PullLever()
    {
        Debug.Log("leverPulled");
        kd.Activate = !kd.Activate;
        if (kd.Activate)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = opened;
            //FenceObject.gameObject.SetActive(false);
            //gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = closed;
        }
    }
}
