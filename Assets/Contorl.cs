using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contorl : MonoBehaviour
{

    fade fade;

    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<fade>();

        fade.Fadeout();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
