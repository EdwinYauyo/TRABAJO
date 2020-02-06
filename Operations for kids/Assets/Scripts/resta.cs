using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resta : MonoBehaviour
{

    public BallOutCounter count;
    public int a, b;
    public Text aa, bb, ress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = count.a;
        b = count.b;
        aa.text = a.ToString();
        bb.text = b.ToString();
        ress.text = (a - b).ToString();
    }
}
