using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class contador : MonoBehaviour
{
    public Obj o1;
    public Obj o2;
    public Obj o3;
    public Obj o4;
    public obj2 o5;
    public obj2 o6;
    public obj2 o7;
    public obj2 o8;
    public int horizontal;
    public int vertical;
    public Text aa;
    public Text bb;
    public Text mul;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        horizontal = o1.h + o2.h + o3.h + o4.h;
        vertical = o5.v + o6.v + o7.v + o8.v;
        aa.text = horizontal.ToString();
        bb.text = vertical.ToString();
        mul.text = (horizontal * vertical).ToString();
    }
}
