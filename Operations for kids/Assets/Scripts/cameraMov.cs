using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMov : MonoBehaviour
{
    public GameObject cam;
    public GameObject canvas1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount==1 && cam.transform.position==new Vector3(0,0,-10))
        {
            cam.transform.position = new Vector3(0, -12, -10);//despues de la pantalla de carga.
            canvas1.SetActive(true);
;       }
        
    }
}
