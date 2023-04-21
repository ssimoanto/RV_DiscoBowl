using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwitchActive : MonoBehaviour
{
    public float maxTime = 0.5f;
    float last = 0.0f;
    float current = 0.0f;
    bool switchy = true;
    //GameObject gO;
    private void Start()
    {
        current = Time.time;
        last = current;
    }

    // Update is called once per frame
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
    }
}
