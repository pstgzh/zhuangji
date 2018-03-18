using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {

    public Transform same;

    void FixedUpdate()
    {
        transform.localEulerAngles = new Vector3(0, same.localEulerAngles.y, 0);
        transform.localPosition = new Vector3(same.localPosition.x, 0, same.localPosition.z);
    }
}
