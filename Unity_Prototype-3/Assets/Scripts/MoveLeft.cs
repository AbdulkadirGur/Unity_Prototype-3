using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speeed =10;
    private PlayerController playerControllerScript;
    private float leftBound=-10;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameover == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speeed);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
