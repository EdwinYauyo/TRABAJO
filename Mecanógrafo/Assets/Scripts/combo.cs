using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class combo : MonoBehaviour
{
    public Text combox;
    private Animator anim;
    public bool space=false;
    public int a=0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public IEnumerator animat()
    {
        yield return new WaitForSeconds(0.2f);
        Debug.Log("space");
        space = false;

    }
        // Update is called once per frame
        void Update()
    {
        anim.SetBool("space", space);
        if (Input.GetKeyDown(KeyCode.Space) && space==false)
        {
            
            space = true;
            a++;
            combox.text = "COMBO X" + a;

        }
        if (space)
        {
            StartCoroutine(animat());
            
           
        }
    }
}
