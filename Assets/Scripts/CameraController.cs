using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform middleBackground, farBackground;
    public Transform target;

    private float lastXPos;


    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Moving Cam based on the target
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        // Getting the diffrence between the current and previose position
        float amountToMoveX = transform.position.x - lastXPos;

        // farbackground matching the cams position
        farBackground.position = farBackground.position + new Vector3(amountToMoveX, 0f, 0f);

        // midbackground moving half of the cams position
        middleBackground.position += new Vector3(amountToMoveX * .5f, 0f, 0f);

        // storing the current cam position in variable for next execution
        lastXPos = transform.position.x;

    }
}
