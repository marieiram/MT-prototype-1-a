using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getpixels : MonoBehaviour
{
    // Set Renderer to a GameObject that has a Renderer component and a material that displays a texture
    public Renderer screenGrabRenderer;
    private Texture2D destinationTexture;
    private bool isPerformingScreenGrab;
    public Texture2D test;

    void Start()
    {
        // Create a new Texture2D with the width and height of the screen, and cache it for reuse
        destinationTexture = new Texture2D(Camera.main.pixelWidth, Camera.main.pixelHeight, TextureFormat.RGB24, false);
        Debug.Log(Camera.main.pixelWidth);
        // Make screenGrabRenderer display the texture.
        screenGrabRenderer.material.mainTexture = destinationTexture;

        // Add the onPostRender callback
        Camera.onPostRender += OnPostRenderCallback;
    }

    void Update()
    {
        // When the user presses the Space key, perform the screen grab operation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPerformingScreenGrab = true;
        }
    }

    void OnPostRenderCallback(Camera cam)
    {
        if (isPerformingScreenGrab)
        {
            // Check whether the Camera that just finished rendering is the one you want to take a screen grab from
            if (cam == Camera.main)
            {
                // Define the parameters for the ReadPixels operation
                Rect regionToReadFrom = new Rect(0, 0, Screen.width, Screen.height);
                Debug.Log(Screen.width);
                int xPosToWriteTo = 0;
                int yPosToWriteTo = 0;
                bool updateMipMapsAutomatically = false;

                // Copy the pixels from the Camera's render target to the texture
                destinationTexture.ReadPixels(regionToReadFrom, xPosToWriteTo, yPosToWriteTo, updateMipMapsAutomatically);

                // Upload texture data to the GPU, so the GPU renders the updated texture
                // Note: This method is costly, and you should call it only when you need to
                // If you do not intend to render the updated texture, there is no need to call this method at this point
                destinationTexture.Apply();

                var mip1Data = destinationTexture.GetPixelData<Color32>(0);
                var mip1Data2 = test.GetPixelData<Color32>(0);

                Debug.Log(mip1Data.Length);
                Debug.Log(mip1Data2.Length);


                for (int i = 0; i < mip1Data2.Length; i++)
                {
                    Color cc = mip1Data[i];
                    Vector3 c = new Vector3(cc.r, cc.g, cc.b);
                    Color bb = mip1Data2[i];
                    Vector3 b = new Vector3(bb.r, bb.g, bb.b);
                    StartCoroutine(compareDistance(c, b));

                   

                }

                // Reset the isPerformingScreenGrab state
                isPerformingScreenGrab = false;

            }
        }
    }

    public IEnumerator compareDistance(Vector3 c, Vector3 b)
    {
        float dist = Vector3.Distance(c, b);
        Debug.Log(dist);
        yield return true;
    }

    // Remove the onPostRender callback
    void OnDestroy()
    {
        Camera.onPostRender -= OnPostRenderCallback;
    }
}