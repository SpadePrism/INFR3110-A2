using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 startPos;
    private float speed;
    public float spdM;
    public float jump = 15.0f;
    public float gravityM = 1.1f;
    private float dirX;
    private bool grounded = false;
    private bool muddy = false;
    public static event Action died;

    // Start is called before the first frame update
    void Start()
    {
        spdM = 20.0f;
        speed = spdM;

        rb = GetComponent<Rigidbody>();

        startPos = (gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * speed;

        if(muddy)
        {
            speed = 5.0f;
        }
        else
        {
            speed = spdM;
        }

        if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jump, ForceMode.VelocityChange);
            grounded = false;
        }
        else if(muddy && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * (jump - 10.0f), ForceMode.VelocityChange);
            muddy = false;
        }
    }

    void FixedUpdate()
    {
        if(!grounded)
        {
            rb.AddForce(Physics.gravity * gravityM, ForceMode.Acceleration);
        }

        rb.velocity = new Vector3(dirX, rb.velocity.y, rb.velocity.z);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Ground ground = collision.gameObject.GetComponent<Ground>();
        if(ground)
        {
            grounded = true;
        }

        Mud mud = collision.gameObject.GetComponent<Mud>();
        if(mud)
        {
            muddy = true;
        }

        Death death = collision.gameObject.GetComponent<Death>();
        if(death)
        {
            gameObject.transform.position = startPos;
            DeathCount.Instance.Value++;

            #region observer
            died?.Invoke();
            #endregion
        }

        Goal goal = collision.gameObject.GetComponent<Goal>();
        if(goal)
        {
            SceneManager.LoadScene("End");
            DeathCount.Instance.Value = 0;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Ground ground = collision.gameObject.GetComponent<Ground>();
        if(ground)
        {
            grounded = false;
        }

        Mud mud = collision.gameObject.GetComponent<Mud>();
        if(mud)
        {
            muddy = false;
        }
    }
}
