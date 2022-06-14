using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Trap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Pacman" && transform.position.y < 0)
        {
            transform.Translate(0, Time.deltaTime, 0, Space.World);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
