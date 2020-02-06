using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerLvl4 : MonoBehaviour
{
    public GameObject ballie, cesta;
    public int n1 = 8;
    public int n2 = 6; //como maximo 5
    void Start()
    {
        for (int i = 0; i < n1; i++) {
            Instantiate(ballie, new Vector3(38f + (i + 1)*6/n1 , 4, -1), Quaternion.identity);
        }
        for (int i = 0; i < n2; i++)
        {
            Instantiate(cesta, new Vector3(31f + (i+1)*14f / (n2), -4.5f, -2), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
