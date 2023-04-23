using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolosBehaviour : MonoBehaviour
{
    public float secondsToRestartGame = 3.0f;
    public GameObject go;
    private void Start()
    {
        go = GameObject.Find("BowlingLine");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            Debug.Log("Bola");
            //Destroy();
           Invoke("instanciaBolosAux", 3.0f);
        }
    }
    private void instanciaBolosAux()
    {
        go.GetComponent<BolosManager>().instanciaBolos();
    }
}
