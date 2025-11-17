using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;

    [Header("Movement variables")] 
    [SerializeField] private float playerSpeed = 5;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        CheckInput();
    }

    void CheckInput() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        Debug.Log(movement);
    }
    
}
