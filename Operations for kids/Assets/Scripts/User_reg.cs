using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class User_reg : MonoBehaviour
{
    TouchScreenKeyboard nombre;
    public Text txt;
    public string b;
    string a;

    public void OpenKeyB()
    {
        nombre = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    public void Vibrar()
    {
        SceneManager.LoadScene("SampleScene");
        Handheld.Vibrate();
        
    }

    

    void Update()
    {



        if (TouchScreenKeyboard.visible == false && nombre!=null)
        {
            if (nombre.done)
            {
                a = nombre.text;
                txt.text = "Bienvenido " + a;
                nombre = null;
            }
        }
    }
}
