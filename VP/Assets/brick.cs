using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brick : MonoBehaviour {
    public Text tekst;
    int broj;
    // Use this for initialization
    void Start () {
        
        broj = System.Convert.ToInt32(tekst.text);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (broj==1)
        {
            Destroy(this.gameObject);
            tekst.text = "";
        }
        else
        {
            broj--;
            print(broj);
            tekst.text = broj.ToString();
        }
        
    }


}
