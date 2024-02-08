using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GetImagePixels : MonoBehaviour
{
    // Set Renderer to a GameObject that has a Renderer component and a material that displays a texture
    public Renderer screenGrabRenderer;
    private Texture2D destinationTexture;
    private bool isPerformingScreenGrab;
    private Texture2D ImageFromDateset;
    public Texture2D[] Happy;
    public Texture2D[] Sad;
    public Texture2D[] Angry;
    public Texture2D[] Neutral;
    public Texture2D[] Surprised;

    private float dist;
    private float Reward;
    //private float[] dist2 = new float(3072);

   // public Sprite[] enemySprites;
    public bool start = false;
    public int ima = 0;

   // public ParentScript objectClayShader;
   public GameObject agent;
   private CollectAgents collectAgents;

    void Start()
    {
        // Create a new Texture2D with the width and height of the screen, and cache it for reuse
        destinationTexture = new Texture2D(Camera.main.pixelWidth, Camera.main.pixelHeight, TextureFormat.RGB24, false);
       // Debug.Log("Camera.main.pixelWidth"+Camera.main.pixelWidth);
        // Make screenGrabRenderer display the texture.
        screenGrabRenderer.material.mainTexture = destinationTexture;

        // Add the onPostRender callback
        Camera.onPostRender += OnPostRenderCallback;

    }

    void Update()
    {
        // When the user presses the Space key, perform the screen grab operation
        if (start == true)
       {
            isPerformingScreenGrab = true;
         //   Debug.Log("getpixcelstart");
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
              // Debug.Log("Screen.width"+Screen.width);
                int xPosToWriteTo = 0;
                int yPosToWriteTo = 0;
                bool updateMipMapsAutomatically = false;

                // Copy the pixels from the Camera's render target to the texture
                destinationTexture.ReadPixels(regionToReadFrom, xPosToWriteTo, yPosToWriteTo, updateMipMapsAutomatically);
               // Debug.Log("destinationTexture.width"+destinationTexture.width);
                // Upload texture data to the GPU, so the GPU renders the updated texture
                // Note: This method is costly, and you should call it only when you need to
                // If you do not intend to render the updated texture, there is no need to call this method at this point
                destinationTexture.Apply();
                 //Debug.Log("after Apply destinationTexture.width"+destinationTexture.width);

                //Pick one Image form dataset(ramdom)
                int selectNum = Random.Range(0,4);
               // Debug.Log(selectNum);
                switch(selectNum)
                {
                    case 0 :
                    ima = 0;
                    ImageFromDateset = Happy[Random.Range(0,Happy.Length-1)];
                    break;

                    case 1 :
                    ima = 1;
                    ImageFromDateset = Sad[Random.Range(0,Sad.Length-1)];
                    break;

                    case 2 :
                    ima = 2;
                    ImageFromDateset = Angry[Random.Range(0,Angry.Length-1)];
                    break;

                    case 3 :
                    ima = 3;
                    ImageFromDateset = Neutral[Random.Range(0,Neutral.Length-1)];
                    break;


                    default :
                    ImageFromDateset = Sad[Random.Range(0,Sad.Length-1)];
                    break;

                }

                Debug.Log(ImageFromDateset);
                var mip1Data = destinationTexture.GetPixelData<Color32>(0);
                var mip1Data2 = ImageFromDateset.GetPixelData<Color32>(0);

               Debug.Log("mip1Data.Length"+mip1Data.Length);
               Debug.Log("mip1Data2.Length"+mip1Data2.Length);
               

                //compareDistance
                for (int i = 0; i < mip1Data.Length; i++)
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
        dist = Vector3.Distance(c, b);
   
        if (dist < 0.25f)
        {
            Reward = 1.0f;
        }
        else if(dist <= 0.35f)
        {
            Reward = 0.5f;
        }
        else{
            Reward = 0f;
        }
        Debug.Log("dist"+dist);
       // Debug.Log("reward"+Reward);
        sentReward();      
        yield return true;
    }

    public void sentReward()
    {
        collectAgents = agent.GetComponent<CollectAgents>();
        collectAgents.reward = Reward;
        collectAgents.GetReward();
        //collectAgents.reward = 0.5f;
       // Debug.Log("reward"+collectAgents.reward);

    }

    // Remove the onPostRender callback
    void OnDestroy()
    {
        Camera.onPostRender -= OnPostRenderCallback;
        //Debug.Log("ondestroy");
    }
    
}