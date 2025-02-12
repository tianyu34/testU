using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject button;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    void Start()
    {
        // button = gameObject;
        // text1  = GameObject.Find("Text1");
        // text2 = GameObject.Find("Text2");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyButtonFun_1()
    {
        if (text1 || text2)
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }
    public void MyButtonFun_2()
    {
        if (text1 || text3)
        {
            text1.SetActive(false);
            text3.SetActive(true);
        }
    }
}
