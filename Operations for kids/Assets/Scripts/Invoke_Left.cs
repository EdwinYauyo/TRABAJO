using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Left : MonoBehaviour
{
    public GameObject bally;
    public int number_balls_l = 0;

    private bool ball_flag = false;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                ball_flag = true;
            }
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && Input.GetTouch(0).phase == TouchPhase.Ended && ball_flag) {
                Instantiate(bally, transform.position, Quaternion.identity);
                number_balls_l++;
                ball_flag = false;
            }
        }
    }
}
