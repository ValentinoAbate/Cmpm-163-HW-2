using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraX : MonoBehaviour
{
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetRotation(float rot)
    {
        rotation = rot;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(rotation, 0,0,transform.rotation.w);
    }
}
