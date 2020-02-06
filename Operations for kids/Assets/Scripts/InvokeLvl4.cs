using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeLvl4 : MonoBehaviour
{
    public GameObject bally;
    private bool ball_flag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                
                ball_flag = true;
            }
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && Input.GetTouch(0).phase == TouchPhase.Ended && ball_flag)
            {
                Debug.Log("xd");
                Instantiate(bally, transform.position + new Vector3(-3.67f, 1.89f, 0), Quaternion.identity);
                ball_flag = false;
            }
        }
    }
}
