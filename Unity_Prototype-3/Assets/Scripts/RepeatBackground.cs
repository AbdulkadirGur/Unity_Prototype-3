using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 starpos;
    private float repeatWidth;
    void Start()
    {
        starpos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < starpos.x-repeatWidth)
        {
            transform.position=starpos;
        }
    }
}
