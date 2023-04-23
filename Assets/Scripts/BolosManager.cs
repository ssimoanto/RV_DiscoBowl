using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class BolosManager : MonoBehaviour
{
    public GameObject go;
    GameObject aux;

    // TIMER
    public float maxTime = 3.0f;
    float current = 0.0f;
    float last = 0.0f;
    bool switchy = false;
    //GameObject gO;
    /*/ Update is called once per frame
    void Update()
    {
        current = Time.time;
        //Debug.Log(Time.time);
        if (current >= last + maxTime)
        {
            switchy = !switchy;
            this.transform.gameObject.GetComponent<Light>().enabled = switchy;
            last = current;
        }
    }*/
    public void instanciaBolos()
    {
        //BolosEmpty
        aux = GameObject.Find("BolosEmpty");
        if (aux == null)
            aux = GameObject.Find("BolosEmpty (Clone)");
        current = Time.time;
        last = current;
        while (current <= last + maxTime)
        {
            current = Time.time;
            //last = current;
            Debug.Log(current);
        }
        Destroy(aux);
        current = Time.time;
        last = current;
        while (current <= last + maxTime)
        {
            current = Time.time;
            //last = current;
            Debug.Log(current);
        }
        GameObject prefabInstance = Instantiate(go, this.gameObject.transform) as GameObject;
        prefabInstance.transform.parent = this.gameObject.transform;
    }
}
