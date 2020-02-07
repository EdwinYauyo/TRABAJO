using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOutCounter : MonoBehaviour
{
    public GameObject text;
    public GameObject iw;
    public bool congra=false;
    public GameObject ballie;
    public GameObject congr;
    public int count=0,a,b;
  
    void Start()
    {
        gene();
        for (int i = 0; i < a; i++) {
            Instantiate(ballie, new Vector3(15 + i+1, -15, -2), Quaternion.identity); //CAMBIAR ACA LA POSICION DE LA ESCENA
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ball"))
        {
            count++;
            
         
        }
    }

    void Update()
    {
        if (count == b)
        {
            congr.SetActive(true);
            iw.GetComponent<Collider2D>().isTrigger = false;
            congra = true;
            text.SetActive(false);
        }

        
    }

    void gene()
    {
        System.Random rnd = new System.Random();
        a = rnd.Next(3, 10);
        
        while (true)
        {
            b = rnd.Next(3, 10);
            if (a > b) return;
        }
    }
   
}
