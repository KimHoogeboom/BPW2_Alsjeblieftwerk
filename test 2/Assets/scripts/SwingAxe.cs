using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingAxe : MonoBehaviour
{
    public Vector3 swingMovement;
    Vector3 originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SWING!"))
            AddSwing();
        else if (Input.GetButtonUp("SWING!"))
            StopSwing();
    }

    private void AddSwing()
    {
        transform.localEulerAngles += swingMovement;
    }
    private void StopSwing()
    {
        transform.localEulerAngles = originalRotation;
    }
}
