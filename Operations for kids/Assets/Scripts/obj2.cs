using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj2 : MonoBehaviour
{
    public GameObject obj1;
    public int v;
    private bool a=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == obj1.transform.position&&a)
        {
            
            v++;
            a = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("L1"))
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = obj1.transform.position;
            obj1.GetComponent<CircleCollider2D>().enabled = !obj1.GetComponent<CircleCollider2D>().enabled;
            


        }


    }

}