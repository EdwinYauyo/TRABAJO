using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Suma : MonoBehaviour
{
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
    }

    void generarAl()
    {
        System.Random rnd = new System.Random();
        a = rnd.Next(1, 10);
        b = rnd.Next(1, 10);
        sum = b + a;
    }
}

