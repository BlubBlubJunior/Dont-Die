using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [SerializeField] float ColorTime;
    
    void Update()
    {
        ColorTime -= Time.deltaTime;
        

        if(ColorTime < 0)
        {
            GameObject.Find("obstacle1").GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            GameObject.Find("obstacle2").GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            
        }

        
    }
}
