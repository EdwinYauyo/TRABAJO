using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas1_controlls : MonoBehaviour
{
    public GameObject cam;
    public GameObject canvas1;
    public GameObject canvas_game1;
    public GameObject canvas_game2;
    public GameObject canvas_game3;
    public GameObject canvas_game4;
    public GameObject game1;
    public GameObject game2;
    public GameObject game3;
    public GameObject game4;
    public GameObject returnB;
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
        returnB.SetActive(true);
        canvas_game1.SetActive(true);   
    }

    public void movGame2()
    {
        cam.transform.position = game2.transform.position + new Vector3(0, 0, -10);
        canvas1.SetActive(false);
        returnB.SetActive(true);
        canvas_game2.SetActive(true);
    }
    public void movGame3()
    {
        cam.transform.position = game3.transform.position + new Vector3(0, 0, -10);
        canvas1.SetActive(false);
        returnB.SetActive(true);
        canvas_game3.SetActive(true);
    }
    public void movGame4()
    {

        cam.transform.position = game4.transform.position + new Vector3(0, 0, -10);
        canvas1.SetActive(false);
        returnB.SetActive(true);
        canvas_game4.SetActive(true);

    }
}
