using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cameraMov : MonoBehaviour
{
    public GameObject cam;
    public GameObject options;
    public GameObject canvas1;
    public GameObject returnB;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Return()
    {
        SceneManager.LoadScene("SampleScene");
        
        
    }
}
