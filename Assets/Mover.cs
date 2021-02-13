using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    private void ProcessMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("UpAndDown") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, yValue, zValue);
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use WASD or the Arrow Keys to move around");
        Debug.Log("Avoid the walls");
    }
}
