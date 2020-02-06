using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class cameraMov : MonoBehaviour
{
    public GameObject cam;
    public GameObject options;
    public GameObject canvas1;
    public Text nombre;
    public User_reg us;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        us.txt = nombre;
        
    }

    public void Return()
    {
        SceneManager.LoadScene("SampleScene");
        
        
    }
}
