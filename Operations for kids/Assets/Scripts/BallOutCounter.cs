using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOutCounter : MonoBehaviour
{
    public GameObject ballie;
    public int count = 5;
  
    void Start()
    {
        for (int i = 0; i < count; i++) {
            Instantiate(ballie, new Vector3(15 + i+1, -15, -1), Quaternion.identity); //CAMBIAR ACA LA POSICION DE LA ESCENA
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ball"))
        {
            
            ballie.GetComponent<Rigidbody2D>().AddForce(new Vector3(-50, 20, 0));
            count--;
         
        }
    }

   
}
