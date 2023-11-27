using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRB;
    private float forcePower = 10.0f;
    private float gravityModifier= 1.0f;
    private bool isOnGround;
    public bool gameover;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(Vector3.up * forcePower,ForceMode.Impulse);
            isOnGround = false;
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground") )
        {
            isOnGround = true;
        }else if (collision.gameObject.CompareTag("obstacle"))
        {
            gameover = true;
            Debug.Log("GameOver");
        }
       
    }
}
