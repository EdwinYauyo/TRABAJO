﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas1_controlls : MonoBehaviour
{
    public GameObject cam;
    public GameObject canvas1;
    public GameObject game1;
    public GameObject game2;
    public GameObject game3;
    public GameObject game4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movGame1()
    {
        cam.transform.position = game1.transform.position+new Vector3(0,0,-10);
        canvas1.SetActive(false);
    }

    public void movGame2()
    {
        cam.transform.position = game2.transform.position;
    }
    public void movGame3()
    {
        cam.transform.position = game3.transform.position;
    }
    public void movGame4()
    {
        cam.transform.position = game4.transform.position;
    }
}