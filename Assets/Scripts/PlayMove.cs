
using UnityEngine;

public class PlayMove : MonoBehaviour
{
    public Rigidbody rb;
    public int FForce = 10;
    public int SForce = 10;
    // Start is called before the first frame update

    // Update is called once per frame
    //FixedUpdate is used when we use physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, FForce*Time.deltaTime);//Deltatime is number of frame per second.
        if (Input.GetKey("d"))
        {
            rb.AddForce(SForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-SForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GManage>().EndGame();
        }
    }
}
