using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C9 : MonoBehaviour
{
    public float speed;


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}