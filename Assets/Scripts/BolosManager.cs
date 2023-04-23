using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class BolosManager : MonoBehaviour
{
    public GameObject go;
    public GameObject bola;
    GameObject aux;

    // TIMER
    public float maxTime = 3.0f;
    float current = 0.0f;
    float last = 0.0f;
    bool switchy = false;
    public int points = 0;
    public string miNombre;
    public string nombreBola;
    public int xValue;
    public void instanciaBolos()
    {
        //BolosEmpty
        aux = GameObject.Find(miNombre+"/BolosEmpty");
        if (aux == null)
            aux = GameObject.Find(miNombre+"/BolosEmpty(Clone)");

        Debug.Log(aux);
        Destroy(aux);

        Invoke("recolocarBolos", 3.0f);
    }
    private void recolocarBolos()
    {
        GameObject prefabInstance = Instantiate(go, this.gameObject.transform) as GameObject;
        prefabInstance.transform.parent = this.gameObject.transform;

       
        GameObject.Find(nombreBola).transform.position = new Vector3(xValue, 2f, 13f);

    }
}
