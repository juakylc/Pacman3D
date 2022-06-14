using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_rotation : MonoBehaviour
{
    //Estos parametros no inicializados se podran modificar desde el inspector
    public float angularSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotacion sobre si misma de la moneda
        transform.Rotate(0, 0, angularSpeed * Time.deltaTime, Space.Self);

    }
}
