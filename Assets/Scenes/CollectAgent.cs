using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using UnityEngine;
using Random = UnityEngine.Random;


using Clayxels;

public class CollectAgent : Agent
{
    //public GameObject objectManager;
    //private ObjectClayShader objectClayShader;

    public Transform obj1;
    public Transform obj2;
    public Transform obj3;
    public Transform obj4;
    
    private Vector3 startPosition;
    private int[] emotion;
    private int label;

    public GameObject imagepixel;
    private GetImagePixels getImagePixels;

    public float reward;

    public override void Initialize()
    {    
     emotion = new int[5]{0,1,2,3,4};
    }

    public override void OnEpisodeBegin(){
 // Random position set
    obj1.localPosition = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),Random.Range(-1f,1f));
    obj1.localRotation = Quaternion.Euler(Random.Range(0f,360f),Random.Range(0f,360f),Random.Range(0f,360f));
 
 // Random label set
    label = emotion[Random.Range(0,4)];
 // label = emotion[0];

    }

   public override void CollectObservations(VectorSensor sensor)
    {
      sensor.AddObservation(obj1.localPosition);
      sensor.AddObservation(obj1.localRotation);
      sensor.AddObservation(obj1.localScale);
      
      sensor.AddObservation(label);

      Debug.Log(obj1.localPosition);
      Debug.Log(obj1.localRotation);
      Debug.Log(obj1.localScale);
      Debug.Log(label);

    }

    public override void OnActionReceived(ActionBuffers actionBuffers)
    {


   //actions
   Vector3 test = Vector3.zero;
   test.x = actionBuffers.ContinuousActions[0];
   Debug.Log(test.x);

    //to start GetImagePixels.cs
   getImagePixels = imagepixel.GetComponent<GetImagePixels>();
   getImagePixels.start = true;


   //reward (compare label)
   if(label == 0){
Debug.Log("onaction");
AddReward(1f);
   }
   // reward (compare pixels)

   
  
   
   AddReward(reward);
   Debug.Log(reward);

  

    }
       // EndEpisode();
    }

    