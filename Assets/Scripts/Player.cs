using UnityEngine;

public class Player : MonoBehaviour
{
    public float xInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
    }

    void HorizontalMovement() {
        xInput = Input.GetAxisRaw("Horizontal");
        Vector3 playerMovement = new Vector3(xInput, 0, 0);
        transform.Translate(playerMovement * Time.deltaTime);
    }
}
