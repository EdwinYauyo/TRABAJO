using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragAndDrop : MonoBehaviour
{


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
        

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;
            GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwForce);
            moveFlag = false;
        }
    }
 //if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))

}