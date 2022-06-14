using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class S_Fantasma : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent agent;
    private Vector3 initialPosition;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Pacman");
        initialPosition = transform.position;

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pacman")
        {
            transform.position = initialPosition;
        }
    }

    void Update()
    {
        //Update target location
        agent.destination = target.transform.position;
    }
}
