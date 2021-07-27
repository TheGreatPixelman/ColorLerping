using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Color start;
    public Color end;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLerpingColor()
    {
        StartCoroutine(LerpToColor(start, end, 1));
    }

    IEnumerator LerpToColor(Color start, Color end, float timeToLerp)
    {
        float t = 0;
        while (t < timeToLerp)
        {
            image.color = Color.Lerp(start, end, t);

            t += Time.deltaTime / timeToLerp;
            yield return null;
        }
    }
}
