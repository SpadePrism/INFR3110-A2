using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPos;
    private float speed;
    private float dirX;
    private float jump = 15.0f;
    private float gravityM = 1.1f;
    private bool grounded = false;
    private bool muddy = false;

    public static event Action died;

    public static event Action jumped;

    // Start is called before the first frame update
    private void Start()
    {
        speed = 20.0f;

        rb = GetComponent<Rigidbody>();

        startPos = (gameObject.transform.position);
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal") * speed;

        if (muddy)
        {
            speed = 5.0f;
        }
        else
        {
            speed = 20.0f;
        }

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jump, ForceMode.VelocityChange);
            grounded = false;

            #region observer

            jumped?.Invoke();

            #endregion observer
        }
        else if (muddy && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * (jump - 10.0f), ForceMode.VelocityChange);
            muddy = false;

            #region observer

            jumped?.Invoke();

            #endregion observer
        }
    }

    private void FixedUpdate()
    {
        if (!grounded)
        {
            rb.AddForce(Physics.gravity * gravityM, ForceMode.Acceleration);
        }

        rb.velocity = new Vector3(dirX, rb.velocity.y, rb.velocity.z);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Ground ground = collision.gameObject.GetComponent<Ground>();
        if (ground)
        {
            grounded = true;
        }

        Mud mud = collision.gameObject.GetComponent<Mud>();
        if (mud)
        {
            muddy = true;
        }

        Death death = collision.gameObject.GetComponent<Death>();
        if (death)
        {
            gameObject.transform.position = startPos;
            DeathCount.Instance.Value++;

            #region observer

            died?.Invoke();

            #endregion observer
        }

        Goal goal = collision.gameObject.GetComponent<Goal>();
        if (goal)
        {
            SceneManager.LoadScene("End");
            DeathCount.Instance.Value = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Ground ground = collision.gameObject.GetComponent<Ground>();
        if (ground)
        {
            grounded = false;
        }

        Mud mud = collision.gameObject.GetComponent<Mud>();
        if (mud)
        {
            muddy = false;
        }
    }
}