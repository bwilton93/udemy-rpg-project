using UnityEngine;

public class BallMover : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    Vector2 m_NewForce;
    int maxVelocity = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

        m_NewForce = new Vector2(-200.0f, 0.0f);
        m_Rigidbody.AddForce(m_NewForce, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.linearVelocity = Vector2.ClampMagnitude(m_Rigidbody.linearVelocity, maxVelocity);
        Debug.Log(m_Rigidbody.linearVelocity);
    }
}
