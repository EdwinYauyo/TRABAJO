using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragAndDrop : MonoBehaviour
{
    public BallOutCounter bc;
    public BallOutCounter b;
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    //    [Range(0.05f, 1f)]
    public float throwForce = 5f;
    private bool moveFlag = false;
    
    void Update()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)) moveFlag = true;
            if (Input.GetTouch(0).phase == TouchPhase.Began && moveFlag)
            {
                touchTimeStart = Time.time;
                startPos = Input.GetTouch(0).position;
            }
        }
        

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && moveFlag) {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;
            GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwForce);
            moveFlag = false;
        }
        if (transform.position.x < 10 || transform.position.x > 28 || transform.position.y > -7 || transform.position.y < -28 ) {
            Destroy(gameObject, 0f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("impulsor"))
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 20, 0), ForceMode2D.Impulse);
        }
    }
    //if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))

}