using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerLvl4 : MonoBehaviour
{
    public GameObject cesta;
    public int n1;
    public int n2;//como maximo 5
    public GameObject[] arr = new GameObject[5];
    void Start()
    {
        while (!(n1 > n2 && n1%n2 == 0)) {
            generarNumber();
        }

        for (int i = 0; i < n2; i++)
        {
            arr[i].transform.position = new Vector3(31f + (i + 1) * 14f / (n2), -3.5f, -1); 
        }
    }

    void generarNumber() {
        System.Random rnd = new System.Random();
        n1 = rnd.Next(5, 15);
        n2 = rnd.Next(2, 5);
    }
}

//new Vector3(31f + (i+1)*14f / (n2), -4.5f, -3)
