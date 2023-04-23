using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public BolosManager bM;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshPro>().text = Time.time.ToString();
    }
}
