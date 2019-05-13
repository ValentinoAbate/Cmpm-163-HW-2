using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraZ : MonoBehaviour
{
    float value;
    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }


    public void SetValue(float val)
    {
        value = val;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(initPos.x, initPos.y, initPos.z + value);
    }
}
