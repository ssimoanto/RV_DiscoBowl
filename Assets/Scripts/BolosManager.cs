using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolosManager : MonoBehaviour
{

    public GameObject go;
    
    public void instanciaBolos()
    {
        GameObject prefabInstance = Instantiate(go, this.gameObject.transform) as GameObject;
        prefabInstance.transform.parent = this.gameObject.transform;
    }
}
