using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolosBehaviour : MonoBehaviour
{
    public float secondsToRestartGame = 3.0f;
    public GameObject go;
    public string miNombre;
    private void Start()
    {
      
        miNombre = transform.parent.parent.GetComponent<BolosManager>().miNombre; 
        go = GameObject.Find(miNombre);
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
