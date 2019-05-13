using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GeneratePerlinNoiseTexture : MonoBehaviour
{
    public Material mat;
    public string propertyName;

    public float scale;
    public int height;
    public int width;
    public float xOffset;
    public float yOffset;
    public bool dynamic = false;

    private void Update()
    {
        if(dynamic)
        {
            SetTexture();
        }
    }


    public void SetTexture()
    {
        mat.SetTexture(propertyName, GenerateTexture());
    }

    public void SetScale(float scale)
    {
        this.scale = scale * 50;
    }

    public void RandomizeValues()
    {
        xOffset = Random.Range(0, 99999);
        yOffset = Random.Range(0, 99999);
    }

    public Texture2D GenerateTexture ()
    {
        var tex = new Texture2D(width, height);
        for(int x = 0; x < width; ++x)
        {
            float perlX = (float)x / width * scale + xOffset;
            for(int y = 0; y < height; ++y)
            {
                float perlY = (float)y / height * scale + yOffset;
                float perlVal = Mathf.PerlinNoise(perlX, perlY);
                Color perlColor = new Color(perlVal, perlVal, perlVal);
                tex.SetPixel(x, y, perlColor);
            }
        }
        tex.Apply();
        return tex;
    }
}
