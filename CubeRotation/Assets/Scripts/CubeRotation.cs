using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private Vector3 verticalRotation = new Vector3(0, 0, 2);
    private Vector3 horizontalRotation = new Vector3(0, 2, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(verticalRotation * verticalInput);
        transform.Rotate(horizontalRotation * horizontalInput );

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
