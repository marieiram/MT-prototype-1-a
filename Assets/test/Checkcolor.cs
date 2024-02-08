using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkcolor : MonoBehaviour
{
    public Camera c1;
    public Camera c2;
    public float[] colordiference = new float[4089];
    


    WaitForEndOfFrame frameEnd = new WaitForEndOfFrame();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(c1.pixelWidth);
        Debug.Log(c1.pixelHeight);
        Debug.Log(c2.pixelWidth);
        Debug.Log(c2.pixelHeight);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(TakeSnapshot(c1, c2));

        }


    }

    public IEnumerator TakeSnapshot(Camera c1, Camera c2)
    {
        yield return frameEnd;
        Rect rect = new Rect(0, 0, c1.pixelWidth, c1.pixelHeight);
        RenderTexture renderTexture = new RenderTexture(c1.pixelWidth, c1.pixelHeight, 24);
        Texture2D screenShot = new Texture2D(c1.pixelWidth, c1.pixelHeight, TextureFormat.RGBA32, false);

        //c1.targetTexture = null;
        RenderTexture.active = null;

        Destroy(renderTexture);
        renderTexture = null;

        RenderTexture.active = c1.targetTexture;
        screenShot.ReadPixels(rect, 0, 0);

        Rect rect2 = new Rect(0, 0, c2.pixelWidth, c2.pixelHeight);
        RenderTexture renderTexture2 = new RenderTexture(c2.pixelWidth, c2.pixelHeight, 24);
        Texture2D screenShot2 = new Texture2D(c2.pixelWidth, c2.pixelHeight, TextureFormat.RGBA32, false);

        //c2.targetTexture = null;
        RenderTexture.active = null;

        Destroy(renderTexture2);
        renderTexture2 = null;

        RenderTexture.active = c2.targetTexture;
        screenShot2.ReadPixels(rect2, 0, 0);



        var mip1Data = screenShot.GetPixelData<Color32>(0);
        var mip1Data2 = screenShot2.GetPixelData<Color32>(0);

        Debug.Log(mip1Data.Length);
        Debug.Log(mip1Data2.Length);

        for (int i = 0; i < mip1Data.Length; i++)
        {
            Color cc = mip1Data[i];
            Vector3 c = new Vector3(cc.r, cc.g, cc.b);
            Color bb = mip1Data2[i];
            Vector3 b = new Vector3(bb.r, bb.g, bb.b);
            StartCoroutine(compareDistance(c, b));
        }

    }


    public IEnumerator compareDistance(Vector3 c, Vector3 b)
    {
        float dist = Vector3.Distance(c, b);
        Debug.Log(dist);
        yield return true;
    }

    public IEnumerator TakeSnapshot2(Camera c1, Camera c2)
    {
        yield return frameEnd;
        Rect rect = new Rect(0, 0, c1.pixelWidth, c1.pixelHeight);
        RenderTexture renderTexture = new RenderTexture(c1.pixelWidth, c1.pixelHeight, 24);
        Texture2D screenShot = new Texture2D(c1.pixelWidth, c1.pixelHeight, TextureFormat.RGBA32, false);

        RenderTexture.active = null;
        Destroy(renderTexture);
        renderTexture = null;
        RenderTexture.active = c1.targetTexture;
        screenShot.ReadPixels(rect, 0, 0);



    }


}