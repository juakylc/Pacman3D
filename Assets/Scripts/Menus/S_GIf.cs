using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_GIf : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animateImageObj;
    public float spd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animateImageObj.sprite = animatedImages[(int) ((Time.time) * spd % animatedImages.Length)];
    }
}
