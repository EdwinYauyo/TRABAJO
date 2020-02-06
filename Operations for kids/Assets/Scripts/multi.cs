using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multi : MonoBehaviour
{
    public GameObject dispensador;
    public GameObject text;
    public Text add;
    public ContainerLvl4 disp;
    public DeleteBallLvl4[] cesta = new DeleteBallLvl4[5];
    
    bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        add.text = "Reparte " + disp.n1 + " pelotas entre las " + disp.n2 + " canastas, de manera que cada canasta tenga la misma cantidad de pelotas.";
        int sum = 0;
        for (int i = 0; i < 5; i++)
            {
                    
                    sum = sum + cesta[i].cont;
            }
            flag = false;
        if (sum == disp.n1)
        {
            
            text.SetActive(true);
            dispensador.SetActive(false);
            add.text = "";
        }
    }
}
