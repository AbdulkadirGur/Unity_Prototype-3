using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRB;
    private Animator playerAnim;
    public float forcePower = 10.0f;
    public float gravityModifier= 1.0f;
    private bool isOnGround;
    public bool gameover;

    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameover)
        {
            playerRB.AddForce(Vector3.up * forcePower,ForceMode.Impulse);
            playerAnim.SetTrigger("Jump_trig");
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
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            Debug.Log("GameOver");
        }
       
    }
}
