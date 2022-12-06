using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLook : MonoBehaviour
{
public Transform eyeDest;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(eyeDest);
    }
}
