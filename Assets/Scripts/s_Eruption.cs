using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Eruption : MonoBehaviour
{
    public GameObject ghost;
    public float fireRate;
    public float init;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ThrowStone());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ThrowStone()
    {
        yield return new WaitForSeconds(init);
        while(true)
        {
            Instantiate(ghost, transform.position, transform.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
