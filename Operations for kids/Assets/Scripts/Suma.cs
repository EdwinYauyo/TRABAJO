using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Suma : MonoBehaviour
{
    public GameObject add;
    public Invoke_Left il;
    public Invoke_Right ir;
    public int a, b, sum;
    public Text aa;
    public Text bb;
    public Text suma;
    // Start is called before the first frame update
    void Start()
    {
        generarAl();
    }

    // Update is called once per frame
    void Update()
    {
        aa.text = a.ToString();
        bb.text = b.ToString();
        suma.text = sum.ToString();

        if (il.number_balls_l + ir.number_balls_r == sum)
        {
            add.SetActive(true);
        }

    }

    void generarAl()
    {
        System.Random rnd = new System.Random();
        a = rnd.Next(1, 10);
        b = rnd.Next(1, 10);
        sum = b + a;
    }
}

