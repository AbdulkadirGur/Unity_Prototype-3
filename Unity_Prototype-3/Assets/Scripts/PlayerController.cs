using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRB;
    public float forcePower = 0;
    public float gravityModifier;
    public bool isOnGround;

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
        isOnGround=true;
    }
}
