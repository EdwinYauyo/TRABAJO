using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBallLvl4 : MonoBehaviour
{
    public ContainerLvl4 dispensador;
    private int cont = 0;
    public bool flag = false;
    private void Update()
    {
        if (cont >= dispensador.n1 / dispensador.n2) {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            flag = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball")) {
            if (flag)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 1000f, 0f));
                Destroy(collision.gameObject, .5f);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ball")) {
            cont++;
            Destroy(col.gameObject, 0f);
        }
    }
}
