using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolosPuntos : MonoBehaviour
{
    bool activo = true;
    
    // Update is called once per frame
    void Update()
    {
        

        bool condi = Mathf.Abs(gameObject.transform.rotation.eulerAngles.x) >= 90f || Mathf.Abs(gameObject.transform.rotation.eulerAngles.y) >= 90f /*|| Mathf.Abs(gameObject.transform.rotation.eulerAngles.z) >= 90f*/;
        if (activo && condi)
        {

            GameObject.Find("BowlingLine").GetComponent<BolosManager>().points++;
            Debug.Log("AL SUELO");
            activo = false; 
            
        }
    }
}
