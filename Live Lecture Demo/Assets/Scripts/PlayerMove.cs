using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f; // meters per sec
    private Vector3 moveDirection = Vector3.right; // same as Vector3(1.0f, 0.0f, 0.0f);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //every frame move player by the speed and direction values.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);
    }


    void OnTriggerEnter(Collider collider)
    {
        // change move direction to a different vector.
        moveDirection = Vector3.forward;
        Debug.Log("trigger event detected. New direction = " + moveDirection);
    }
}
