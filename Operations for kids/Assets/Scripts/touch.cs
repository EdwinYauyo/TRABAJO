using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public GameObject cam;
    public GameObject game4, canvas_game4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1)
        {

            cam.transform.position = game4.transform.position + new Vector3(0, 0, -10);
            canvas_game4.SetActive(true);
        }

    }
}
