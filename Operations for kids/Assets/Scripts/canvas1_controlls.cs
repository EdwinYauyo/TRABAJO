using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas1_controlls : MonoBehaviour
{
    GameObject cam;
    GameObject game1;
    GameObject game2;
    GameObject game3;
    GameObject game4;
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
        cam.transform.position = game1.transform.position;
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
