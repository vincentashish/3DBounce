
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Rigidbody rb;     
    public float forwardForce = 2000f;
    public float sidewayForce = 30f;
    public float upForce = 1000f;
    public bool isKeyD = false;
    public bool isKeyA = false;
    public bool isKeyW = false;
    public bool isKeyS = false;
    public bool isKeySpace = false;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isKeyD = false;
        isKeyA = false;
        isKeyS = false;
        isKeyW = false;
        isKeySpace = false;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            isKeyD = true;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            isKeyA = true;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            isKeyW = true;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            isKeyS = true;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isKeySpace = true;
        }
        

    }

    void FixedUpdate()
    {
       // rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (isKeyA)
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        if (isKeyD)
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        if (isKeyW)
            rb.AddForce(0, 0, sidewayForce * Time.deltaTime, ForceMode.VelocityChange);
        if (isKeyS)
            rb.AddForce(0, 0, -sidewayForce * Time.deltaTime, ForceMode.VelocityChange);
        
        if (isKeySpace)
        {
            counter++;
            if(counter <= 2)
            {
                rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }

        }
            
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Ground")
        {
            counter = 0;
        }
    }
}
