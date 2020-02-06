using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("L1"))
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = obj1.transform.position;
            obj1.GetComponent<CircleCollider2D>().enabled = !obj1.GetComponent<CircleCollider2D>().enabled;



        }
        else if (col.gameObject.CompareTag("R1"))
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = obj2.transform.position;
            obj2.GetComponent<CircleCollider2D>().enabled = !obj1.GetComponent<CircleCollider2D>().enabled;


        }

    }

}