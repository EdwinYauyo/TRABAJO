using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBallLvl4 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ball")) {
            Debug.Log("xd");
            Destroy(col.gameObject, 0f);
        }
    }
}
