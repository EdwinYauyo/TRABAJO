using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMov : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount==1 && cam.transform.position==new Vector3(0,0,-10))
        {
            cam.transform.position = new Vector3(20, 0, -10);
;       }
    }
}
