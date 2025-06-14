using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float laneDistance = 3f;
    public Animator animator;
    public float jumpPower;
    public Rigidbody playerRigidbody;
    Vector3 mousePosDown;
    public GameObject currentPath;
    void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.CompareTag("StraightPath"))
        // {
        //     Debug.Log("straightpath");
        // }
        // else if (collision.gameObject.CompareTag("LeftPath"))
        // {
        //     Debug.Log("LeftTurn");
        // }
        // else if(collision.gameObject.CompareTag("RightPath"))
        // {
        //     Debug.Log("RightTurn");
        // }
        if (collision.collider.CompareTag("Ground"))
        {
            currentPath = collision.transform.parent.parent.gameObject;
            Debug.Log(currentPath);
        }
        
        
 }
  void Start()
  {
        playerRigidbody = GetComponent<Rigidbody>();
  }

  void Update()
    {
        // Move forward continuously
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);


        //Player movement of left, right, up and down
        SwapMovement();

    }

    public void SwapMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosDown = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePosUp = Input.mousePosition;
            float deltaX = mousePosUp.x - mousePosDown.x;
            float deltaY = mousePosUp.y - mousePosDown.y;

            if (Mathf.Abs(deltaX) > Mathf.Abs(deltaY))
            {
                if (deltaX > 0)
                {
                    Debug.Log("Swap Right");
                    this.transform.Rotate(0, 90, 0);
                }
                else if (deltaX < 0)
                {
                    Debug.Log("Swap Left");
                    this.transform.Rotate(0, -90, 0);
                }
            }
            else
            {
                if (deltaY > 0)
                {
                    Debug.Log("Swap Up");
                    animator.SetTrigger("Jump");
                    Jump();
                }
                else if (deltaY < 0)
                {
                    Debug.Log("Swap Down");
                    animator.SetTrigger("Slide");
                }
            }
        }
    }
    private void Jump()
    {
        playerRigidbody.AddForce(0, jumpPower, 0, ForceMode.Impulse);
    }
}
