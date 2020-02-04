using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Right : MonoBehaviour
{
    public int number_balls_r = 0;
    public GameObject bally;
    private bool ball_flag = false;
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
                Instantiate(bally, transform.position, Quaternion.identity);
                number_balls_r++;
                ball_flag = false;
            }
        }
    }
}
