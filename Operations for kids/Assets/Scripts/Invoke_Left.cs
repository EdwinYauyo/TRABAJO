using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Left : MonoBehaviour
{
    public GameObject bally;
    public int number_balls_l = 0;
    public int a;
    private bool ball_flag = false;

    public Suma sum;

    void Update()
    {

        a = sum.a;



        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                ball_flag = true;
            }
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && Input.GetTouch(0).phase == TouchPhase.Ended && ball_flag&&number_balls_l<a) {
                Instantiate(bally, transform.position + new Vector3(1, -1, 0), Quaternion.identity);
                number_balls_l++;
                ball_flag = false;
            }
        }
    }
}
