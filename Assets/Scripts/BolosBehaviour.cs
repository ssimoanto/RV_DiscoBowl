using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolosBehaviour : MonoBehaviour
{
    public float secondsToRestartGame = 3.0f;
    public GameObject go;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            //Debug.Log("Bola");
            //Destroy();
            go.GetComponent<BolosManager>().instanciaBolos();
        }
    }
}
