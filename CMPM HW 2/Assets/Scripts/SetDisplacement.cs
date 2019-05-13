using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetDisplacement : MonoBehaviour
{
    public Material mat;
    public string parameterName;
    public float value;

    public void SetValue(float val)
    {
        value = val;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat(parameterName, value);
    }
}
