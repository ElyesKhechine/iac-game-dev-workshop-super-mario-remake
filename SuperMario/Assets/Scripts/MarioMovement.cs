using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{   
    public float speed;
    public float jumpSpeed;
    public bool grounded;

    public Animator myAnimations;
    // Start is called before the first frame update
    void Start()
    {
        myAnimations.SetBool("isRunning", false);
    }

    // Update is called once per frame
    void Update()
    {
        //running right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                transform.eulerAngles=new Vector3(0,0,0);
                myAnimations.SetBool("isRunning", true);
            }

        //running left
        else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                transform.eulerAngles=new Vector3(0,-180,0);
                myAnimations.SetBool("isRunning", true);
            }

        else
            {
                myAnimations.SetBool("isRunning", false);
            }

        //jumping
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) && grounded==true)
            {
                transform.Translate(new Vector3(0,1,0) * jumpSpeed * Time.deltaTime);
                grounded=false;
                myAnimations.SetBool("isJumping", true);
            }
        else
            {
                myAnimations.SetBool("isJumping", false);
            }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

    }
}
