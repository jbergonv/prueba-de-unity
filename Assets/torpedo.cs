using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torpedo : MonoBehaviour
{
    // Start is called before the first frame update

    int contador = 0;

    void Start()
    {

        Debug.Log("Hola mundo");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f,0);
        
    }
}
