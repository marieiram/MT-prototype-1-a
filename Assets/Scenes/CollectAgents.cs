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


public class CollectAgents : Agent
{
 
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject empty;

    private Vector3 startPosition1;
    private Vector3 startPosition2;
    private Vector3 startPosition3;
    private Vector3 startPosition4;
    private Vector3 startPosition5;
    private Vector3 startPosition6;
    private Vector3 startPosition7;
    private Vector3 startPosition8;
    private Vector3 startPosition9;
    private Vector3 startPosition10;
    private Vector3 startPosition11;
    private Vector3 startPosition12;
    private Vector3 startPosition13;
    private Vector3 startPosition14;
    private Vector3 startPosition15;
    private Vector3 startPosition16;

    public GameObject imagepixel;
    private GetImagePixels getImagePixels;
    public float reward;

    private ClayObject clayobject1;
    private ClayObject clayobject2;
    private ClayObject clayobject3;
    private ClayObject clayobject4;
    private ClayObject clayobject5;
    private ClayObject clayobject6;
    private ClayObject clayobject7;
    private ClayObject clayobject8;
    private ClayObject clayobject9;
    private ClayObject clayobject10;
    private ClayObject clayobject11;
    private ClayObject clayobject12;
    private ClayObject clayobject13;
    private ClayObject clayobject14;
    private ClayObject clayobject15;
    private ClayObject clayobject16;


    private Color Objcolor1;
    private Color Objcolor2;
    private Color Objcolor3;
    private Color Objcolor4;
    private Color Objcolor5;
    private Color Objcolor6;
    private Color Objcolor7;
    private Color Objcolor8;
    private Color Objcolor9;
    private Color Objcolor10;
    private Color Objcolor11;
    private Color Objcolor12;
    private Color Objcolor13;
    private Color Objcolor14;
    private Color Objcolor15;
    private Color Objcolor16;


    private bool timeCount = true;
    private bool timeChecker = false;


    public override void Initialize()
    {
        startPosition1 = obj1.transform.position;
        startPosition2 = obj2.transform.position;
        startPosition3 = obj3.transform.position;
        startPosition4 = obj4.transform.position;
        startPosition5 = obj5.transform.position;
        startPosition6 = obj6.transform.position;
        startPosition7 = obj7.transform.position;
        startPosition8 = obj8.transform.position;       
        startPosition9 = obj9.transform.position;
        startPosition10 = obj10.transform.position;
        startPosition11 = obj11.transform.position;
        startPosition12 = obj12.transform.position;
        startPosition13 = obj13.transform.position;
        startPosition14 = obj14.transform.position;
        startPosition15 = obj15.transform.position;
        startPosition16 = obj16.transform.position;

        
    }


    public override void OnEpisodeBegin()
    {
         //Debug.Log("OnEpisodeBegin");
        // Reset agent position, rotation
        obj1.transform.position = startPosition1;
        obj2.transform.position = startPosition2;
        obj3.transform.position = startPosition3;
        obj4.transform.position = startPosition4;
        obj5.transform.position = startPosition5;
        obj6.transform.position = startPosition6;
        obj7.transform.position = startPosition7;
        obj8.transform.position = startPosition8;
        obj9.transform.position = startPosition9;
        obj10.transform.position = startPosition10;
        obj11.transform.position = startPosition11;
        obj12.transform.position = startPosition12;
        obj13.transform.position = startPosition13;
        obj14.transform.position = startPosition14;
        obj15.transform.position = startPosition15;
        obj16.transform.position = startPosition16;
        obj1.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj2.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj3.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj4.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj5.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj6.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj7.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj8.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj9.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj10.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj11.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj12.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj13.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj14.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj15.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
        obj16.transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 0f));
       
    }



    public override void CollectObservations(VectorSensor sensor)
    {
   /// Debug.Log("enter CollectObservation");        
    //getImagePixels = imagepixel.GetComponent<GetImagePixels>();
    //sensor.AddObservation(getImagePixels.ima);
    
    //classifier observation
    
    //obj1
    sensor.AddObservation(obj1.transform.position.x);
    sensor.AddObservation(obj1.transform.position.y);
    sensor.AddObservation(obj1.transform.position.z);
   
    sensor.AddObservation(obj1.transform.rotation.x);
    sensor.AddObservation(obj1.transform.rotation.y);
    sensor.AddObservation(obj1.transform.rotation.z);

    sensor.AddObservation(obj1.transform.lossyScale.x);
    sensor.AddObservation(obj1.transform.lossyScale.y);
    sensor.AddObservation(obj1.transform.lossyScale.z);

    //obj2
    sensor.AddObservation(obj2.transform.position.x);
    sensor.AddObservation(obj2.transform.position.y);
    sensor.AddObservation(obj2.transform.position.z);
   
    sensor.AddObservation(obj2.transform.rotation.x);
    sensor.AddObservation(obj2.transform.rotation.y);
    sensor.AddObservation(obj2.transform.rotation.z);

    sensor.AddObservation(obj2.transform.lossyScale.x);
    sensor.AddObservation(obj2.transform.lossyScale.y);
    sensor.AddObservation(obj2.transform.lossyScale.z);

    //obj3
    sensor.AddObservation(obj3.transform.position.x);
    sensor.AddObservation(obj3.transform.position.y);
    sensor.AddObservation(obj3.transform.position.z);
   
    sensor.AddObservation(obj3.transform.rotation.x);
    sensor.AddObservation(obj3.transform.rotation.y);
    sensor.AddObservation(obj3.transform.rotation.z);

    sensor.AddObservation(obj3.transform.lossyScale.x);
    sensor.AddObservation(obj3.transform.lossyScale.y);
    sensor.AddObservation(obj3.transform.lossyScale.z);

    //obj4
    sensor.AddObservation(obj4.transform.position.x);
    sensor.AddObservation(obj4.transform.position.y);
    sensor.AddObservation(obj4.transform.position.z);
   
    sensor.AddObservation(obj4.transform.rotation.x);
    sensor.AddObservation(obj4.transform.rotation.y);
    sensor.AddObservation(obj4.transform.rotation.z);

    sensor.AddObservation(obj4.transform.lossyScale.x);
    sensor.AddObservation(obj4.transform.lossyScale.y);
    sensor.AddObservation(obj4.transform.lossyScale.z);

    //obj5
    sensor.AddObservation(obj5.transform.position.x);
    sensor.AddObservation(obj5.transform.position.y);
    sensor.AddObservation(obj5.transform.position.z);
   
    sensor.AddObservation(obj5.transform.rotation.x);
    sensor.AddObservation(obj5.transform.rotation.y);
    sensor.AddObservation(obj5.transform.rotation.z);

    sensor.AddObservation(obj5.transform.lossyScale.x);
    sensor.AddObservation(obj5.transform.lossyScale.y);
    sensor.AddObservation(obj5.transform.lossyScale.z);

    //obj6
    sensor.AddObservation(obj6.transform.position.x);
    sensor.AddObservation(obj6.transform.position.y);
    sensor.AddObservation(obj6.transform.position.z);
   
    sensor.AddObservation(obj6.transform.rotation.x);
    sensor.AddObservation(obj6.transform.rotation.y);
    sensor.AddObservation(obj6.transform.rotation.z);

    sensor.AddObservation(obj6.transform.lossyScale.x);
    sensor.AddObservation(obj6.transform.lossyScale.y);
    sensor.AddObservation(obj6.transform.lossyScale.z);
    //obj7
    sensor.AddObservation(obj7.transform.position.x);
    sensor.AddObservation(obj7.transform.position.y);
    sensor.AddObservation(obj7.transform.position.z);

    sensor.AddObservation(obj7.transform.rotation.x);
    sensor.AddObservation(obj7.transform.rotation.y);
    sensor.AddObservation(obj7.transform.rotation.z);

    sensor.AddObservation(obj7.transform.lossyScale.x);
    sensor.AddObservation(obj7.transform.lossyScale.y);
    sensor.AddObservation(obj7.transform.lossyScale.z);
    //obj8
    sensor.AddObservation(obj8.transform.position.x);
    sensor.AddObservation(obj8.transform.position.y);
    sensor.AddObservation(obj8.transform.position.z);
   
    sensor.AddObservation(obj8.transform.rotation.x);
    sensor.AddObservation(obj8.transform.rotation.y);
    sensor.AddObservation(obj8.transform.rotation.z);

    sensor.AddObservation(obj8.transform.lossyScale.x);
    sensor.AddObservation(obj8.transform.lossyScale.y);
    sensor.AddObservation(obj8.transform.lossyScale.z);

    //obj9
    sensor.AddObservation(obj9.transform.position.x);
    sensor.AddObservation(obj9.transform.position.y);
    sensor.AddObservation(obj9.transform.position.z);
   
    sensor.AddObservation(obj9.transform.rotation.x);
    sensor.AddObservation(obj9.transform.rotation.y);
    sensor.AddObservation(obj9.transform.rotation.z);

    sensor.AddObservation(obj9.transform.lossyScale.x);
    sensor.AddObservation(obj9.transform.lossyScale.y);
    sensor.AddObservation(obj9.transform.lossyScale.z);

    //obj10
    sensor.AddObservation(obj10.transform.position.x);
    sensor.AddObservation(obj10.transform.position.y);
    sensor.AddObservation(obj10.transform.position.z);
   
    sensor.AddObservation(obj10.transform.rotation.x);
    sensor.AddObservation(obj10.transform.rotation.y);
    sensor.AddObservation(obj10.transform.rotation.z);

    sensor.AddObservation(obj10.transform.lossyScale.x);
    sensor.AddObservation(obj10.transform.lossyScale.y);
    sensor.AddObservation(obj10.transform.lossyScale.z);
    //obj11
    sensor.AddObservation(obj11.transform.position.x);
    sensor.AddObservation(obj11.transform.position.y);
    sensor.AddObservation(obj11.transform.position.z);
   
    sensor.AddObservation(obj11.transform.rotation.x);
    sensor.AddObservation(obj11.transform.rotation.y);
    sensor.AddObservation(obj11.transform.rotation.z);

    sensor.AddObservation(obj11.transform.lossyScale.x);
    sensor.AddObservation(obj11.transform.lossyScale.y);
    sensor.AddObservation(obj11.transform.lossyScale.z);
    //obj12
    sensor.AddObservation(obj12.transform.position.x);
    sensor.AddObservation(obj12.transform.position.y);
    sensor.AddObservation(obj12.transform.position.z);
   
    sensor.AddObservation(obj12.transform.rotation.x);
    sensor.AddObservation(obj12.transform.rotation.y);
    sensor.AddObservation(obj12.transform.rotation.z);

    sensor.AddObservation(obj12.transform.lossyScale.x);
    sensor.AddObservation(obj12.transform.lossyScale.y);
    sensor.AddObservation(obj12.transform.lossyScale.z);
    //obj13
    sensor.AddObservation(obj13.transform.position.x);
    sensor.AddObservation(obj13.transform.position.y);
    sensor.AddObservation(obj13.transform.position.z);
   
    sensor.AddObservation(obj13.transform.rotation.x);
    sensor.AddObservation(obj13.transform.rotation.y);
    sensor.AddObservation(obj13.transform.rotation.z);

    sensor.AddObservation(obj13.transform.lossyScale.x);
    sensor.AddObservation(obj13.transform.lossyScale.y);
    sensor.AddObservation(obj13.transform.lossyScale.z);
    //obj14
    sensor.AddObservation(obj14.transform.position.x);
    sensor.AddObservation(obj14.transform.position.y);
    sensor.AddObservation(obj14.transform.position.z);
   
    sensor.AddObservation(obj14.transform.rotation.x);
    sensor.AddObservation(obj14.transform.rotation.y);
    sensor.AddObservation(obj14.transform.rotation.z);

    sensor.AddObservation(obj14.transform.lossyScale.x);
    sensor.AddObservation(obj14.transform.lossyScale.y);
    sensor.AddObservation(obj14.transform.lossyScale.z);
    //obj15

    sensor.AddObservation(obj15.transform.position.x);
    sensor.AddObservation(obj15.transform.position.y);
    sensor.AddObservation(obj15.transform.position.z);
   
    sensor.AddObservation(obj15.transform.rotation.x);
    sensor.AddObservation(obj15.transform.rotation.y);
    sensor.AddObservation(obj15.transform.rotation.z);

    sensor.AddObservation(obj15.transform.lossyScale.x);
    sensor.AddObservation(obj15.transform.lossyScale.y);
    sensor.AddObservation(obj15.transform.lossyScale.z);
    //obj16
    sensor.AddObservation(obj16.transform.position.x);
    sensor.AddObservation(obj16.transform.position.y);
    sensor.AddObservation(obj16.transform.position.z);
   
    sensor.AddObservation(obj16.transform.rotation.x);
    sensor.AddObservation(obj16.transform.rotation.y);
    sensor.AddObservation(obj16.transform.rotation.z);

    sensor.AddObservation(obj16.transform.lossyScale.x);
    sensor.AddObservation(obj16.transform.lossyScale.y);
    sensor.AddObservation(obj16.transform.lossyScale.z);


    //ref clayobject1.color
    clayobject1 = obj1.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject1.color.r);
    sensor.AddObservation(clayobject1.color.g);
    sensor.AddObservation(clayobject1.color.b);
    //ref clayobject2.color
    clayobject2 = obj2.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject2.color.r);
    sensor.AddObservation(clayobject2.color.g);
    sensor.AddObservation(clayobject2.color.b);
    //ref clayobject3.color
    clayobject3 = obj3.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject3.color.r);
    sensor.AddObservation(clayobject3.color.g);
    sensor.AddObservation(clayobject3.color.b);
    //ref clayobject4.color
    clayobject4 = obj4.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject4.color.r);
    sensor.AddObservation(clayobject4.color.g);
    sensor.AddObservation(clayobject4.color.b);
    //ref clayobject5.color
    clayobject5 = obj5.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject5.color.r);
    sensor.AddObservation(clayobject5.color.g);
    sensor.AddObservation(clayobject5.color.b);
    //ref clayobject6.color
    clayobject6 = obj6.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject6.color.r);
    sensor.AddObservation(clayobject6.color.g);
    sensor.AddObservation(clayobject6.color.b);
    //ref clayobject7.color
    clayobject7 = obj7.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject7.color.r);
    sensor.AddObservation(clayobject7.color.g);
    sensor.AddObservation(clayobject7.color.b);
    //ref clayobject8.color
    clayobject8 = obj8.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject8.color.r);
    sensor.AddObservation(clayobject8.color.g);
    sensor.AddObservation(clayobject8.color.b);
    //ref clayobject9.color
    clayobject9 = obj9.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject9.color.r);
    sensor.AddObservation(clayobject9.color.g);
    sensor.AddObservation(clayobject9.color.b);
    //ref clayobject10.color
    clayobject10 = obj10.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject10.color.r);
    sensor.AddObservation(clayobject10.color.g);
    sensor.AddObservation(clayobject10.color.b);
    //ref clayobject11.color
    clayobject11= obj11.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject11.color.r);
    sensor.AddObservation(clayobject11.color.g);
    sensor.AddObservation(clayobject11.color.b);
    //ref clayobject12.color
    clayobject12 = obj12.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject12.color.r);
    sensor.AddObservation(clayobject12.color.g);
    sensor.AddObservation(clayobject12.color.b);
    //ref clayobject13.color
    clayobject13 = obj13.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject13.color.r);
    sensor.AddObservation(clayobject13.color.g);
    sensor.AddObservation(clayobject13.color.b);
    //ref clayobject14.color
    clayobject14 = obj14.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject14.color.r);
    sensor.AddObservation(clayobject14.color.g);
    sensor.AddObservation(clayobject14.color.b);
    //ref clayobject15.color
    clayobject15 = obj15.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject15.color.r);
    sensor.AddObservation(clayobject15.color.g);
    sensor.AddObservation(clayobject15.color.b);
    //ref clayobject16.color
    clayobject16 = obj16.GetComponent<ClayObject>();
    sensor.AddObservation(clayobject16.color.r);
    sensor.AddObservation(clayobject16.color.g);
    sensor.AddObservation(clayobject16.color.b);
    


    }

    public override void OnActionReceived(ActionBuffers actionBuffers)
    {// Debug.Log("enter OnActionReceived");
     
       timeCount = true;
      // Debug.Log("timeCount"+ timeCount);
      //obj1
        Vector3 controlPosition1 = Vector3.zero;
       // Debug.Log(controlPosition);
        controlPosition1.x = actionBuffers.ContinuousActions[0];
        controlPosition1.y = actionBuffers.ContinuousActions[1];
        controlPosition1.z = actionBuffers.ContinuousActions[2];

        Vector3 controlRotaion1= Vector3.zero;
        controlRotaion1.x = actionBuffers.ContinuousActions[3];
        controlRotaion1.y = actionBuffers.ContinuousActions[4];
        controlRotaion1.z = actionBuffers.ContinuousActions[5];

        Vector3 controlScale1 = Vector3.zero;
        controlScale1.x = actionBuffers.ContinuousActions[6];
        controlScale1.y = actionBuffers.ContinuousActions[7];
        controlScale1.z = actionBuffers.ContinuousActions[8];

        float rowR1 = actionBuffers.ContinuousActions[9];
        float rowG1 = actionBuffers.ContinuousActions[10];
        float rowB1 = actionBuffers.ContinuousActions[11];
        Objcolor1.r = Mathf.Abs(rowR1);
        Objcolor1.g = Mathf.Abs(rowG1);
        Objcolor1.b = Mathf.Abs(rowB1);

         //obj2
        Vector3 controlPosition2 = Vector3.zero;
        controlPosition2.x = actionBuffers.ContinuousActions[12];
        controlPosition2.y = actionBuffers.ContinuousActions[13];
        controlPosition2.z = actionBuffers.ContinuousActions[14];

        Vector3 controlRotaion2= Vector3.zero;
        controlRotaion2.x = actionBuffers.ContinuousActions[15];
        controlRotaion2.y = actionBuffers.ContinuousActions[16];
        controlRotaion2.z = actionBuffers.ContinuousActions[17];

        Vector3 controlScale2 = Vector3.zero;
        controlScale2.x = actionBuffers.ContinuousActions[18];
        controlScale2.y = actionBuffers.ContinuousActions[19];
        controlScale2.z = actionBuffers.ContinuousActions[20];

        float rowR2 = actionBuffers.ContinuousActions[21];
        float rowG2 = actionBuffers.ContinuousActions[22];
        float rowB2 = actionBuffers.ContinuousActions[23];
        Objcolor2.r = Mathf.Abs(rowR2);
        Objcolor2.g = Mathf.Abs(rowG2);
        Objcolor2.b = Mathf.Abs(rowB2);

         //obj3
        Vector3 controlPosition3 = Vector3.zero;
        controlPosition3.x = actionBuffers.ContinuousActions[24];
        controlPosition3.y = actionBuffers.ContinuousActions[25];
        controlPosition3.z = actionBuffers.ContinuousActions[26];

        Vector3 controlRotaion3= Vector3.zero;
        controlRotaion3.x = actionBuffers.ContinuousActions[27];
        controlRotaion3.y = actionBuffers.ContinuousActions[28];
        controlRotaion3.z = actionBuffers.ContinuousActions[29];

        Vector3 controlScale3 = Vector3.zero;
        controlScale3.x = actionBuffers.ContinuousActions[30];
        controlScale3.y = actionBuffers.ContinuousActions[31];
        controlScale3.z = actionBuffers.ContinuousActions[32];

        float rowR3 = actionBuffers.ContinuousActions[33];
        float rowG3 = actionBuffers.ContinuousActions[34];
        float rowB3 = actionBuffers.ContinuousActions[35];
        Objcolor3.r = Mathf.Abs(rowR3);
        Objcolor3.g = Mathf.Abs(rowG3);
        Objcolor3.b = Mathf.Abs(rowB3);

        //obj4
        Vector3 controlPosition4 = Vector3.zero;
        controlPosition4.x = actionBuffers.ContinuousActions[36];
        controlPosition4.y = actionBuffers.ContinuousActions[37];
        controlPosition4.z = actionBuffers.ContinuousActions[38];

        Vector3 controlRotaion4= Vector3.zero;
        controlRotaion4.x = actionBuffers.ContinuousActions[39];
        controlRotaion4.y = actionBuffers.ContinuousActions[40];
        controlRotaion4.z = actionBuffers.ContinuousActions[41];

        Vector3 controlScale4 = Vector3.zero;
        controlScale4.x = actionBuffers.ContinuousActions[42];
        controlScale4.y = actionBuffers.ContinuousActions[43];
        controlScale4.z = actionBuffers.ContinuousActions[44];

        float rowR4 = actionBuffers.ContinuousActions[45];
        float rowG4 = actionBuffers.ContinuousActions[46];
        float rowB4 = actionBuffers.ContinuousActions[47];
        Objcolor4.r = Mathf.Abs(rowR4);
        Objcolor4.g = Mathf.Abs(rowG4);
        Objcolor4.b = Mathf.Abs(rowB4);

        //obj5
        Vector3 controlPosition5 = Vector3.zero;
        controlPosition5.x = actionBuffers.ContinuousActions[48];
        controlPosition5.y = actionBuffers.ContinuousActions[49];
        controlPosition5.z = actionBuffers.ContinuousActions[50];

        Vector3 controlRotaion5= Vector3.zero;
        controlRotaion5.x = actionBuffers.ContinuousActions[51];
        controlRotaion5.y = actionBuffers.ContinuousActions[52];
        controlRotaion5.z = actionBuffers.ContinuousActions[53];

        Vector3 controlScale5 = Vector3.zero;
        controlScale5.x = actionBuffers.ContinuousActions[54];
        controlScale5.y = actionBuffers.ContinuousActions[55];
        controlScale5.z = actionBuffers.ContinuousActions[56];

        float rowR5 = actionBuffers.ContinuousActions[57];
        float rowG5 = actionBuffers.ContinuousActions[58];
        float rowB5 = actionBuffers.ContinuousActions[59];
        Objcolor5.r = Mathf.Abs(rowR5);
        Objcolor5.g = Mathf.Abs(rowG5);
        Objcolor5.b = Mathf.Abs(rowB5);

        //obj6
        Vector3 controlPosition6 = Vector3.zero;
        controlPosition6.x = actionBuffers.ContinuousActions[60];
        controlPosition6.y = actionBuffers.ContinuousActions[61];
        controlPosition6.z = actionBuffers.ContinuousActions[62];

        Vector3 controlRotaion6= Vector3.zero;
        controlRotaion6.x = actionBuffers.ContinuousActions[63];
        controlRotaion6.y = actionBuffers.ContinuousActions[64];
        controlRotaion6.z = actionBuffers.ContinuousActions[65];

        Vector3 controlScale6 = Vector3.zero;
        controlScale6.x = actionBuffers.ContinuousActions[66];
        controlScale6.y = actionBuffers.ContinuousActions[67];
        controlScale6.z = actionBuffers.ContinuousActions[68];

        float rowR6 = actionBuffers.ContinuousActions[69];
        float rowG6 = actionBuffers.ContinuousActions[70];
        float rowB6 = actionBuffers.ContinuousActions[71];
        Objcolor6.r = Mathf.Abs(rowR6);
        Objcolor6.g = Mathf.Abs(rowG6);
        Objcolor6.b = Mathf.Abs(rowB6);

        //obj7
        Vector3 controlPosition7 = Vector3.zero;
        controlPosition7.x = actionBuffers.ContinuousActions[72];
        controlPosition7.y = actionBuffers.ContinuousActions[73];
        controlPosition7.z = actionBuffers.ContinuousActions[74];

        Vector3 controlRotaion7= Vector3.zero;
        controlRotaion7.x = actionBuffers.ContinuousActions[75];
        controlRotaion7.y = actionBuffers.ContinuousActions[76];
        controlRotaion7.z = actionBuffers.ContinuousActions[77];

        Vector3 controlScale7 = Vector3.zero;
        controlScale7.x = actionBuffers.ContinuousActions[78];
        controlScale7.y = actionBuffers.ContinuousActions[79];
        controlScale7.z = actionBuffers.ContinuousActions[80];

        float rowR7 = actionBuffers.ContinuousActions[81];
        float rowG7 = actionBuffers.ContinuousActions[82];
        float rowB7 = actionBuffers.ContinuousActions[83];
        Objcolor7.r = Mathf.Abs(rowR7);
        Objcolor7.g = Mathf.Abs(rowG7);
        Objcolor7.b = Mathf.Abs(rowB7);

         //obj8
        Vector3 controlPosition8 = Vector3.zero;
        controlPosition8.x = actionBuffers.ContinuousActions[84];
        controlPosition8.y = actionBuffers.ContinuousActions[85];
        controlPosition8.z = actionBuffers.ContinuousActions[86];

        Vector3 controlRotaion8= Vector3.zero;
        controlRotaion8.x = actionBuffers.ContinuousActions[87];
        controlRotaion8.y = actionBuffers.ContinuousActions[88];
        controlRotaion8.z = actionBuffers.ContinuousActions[89];

        Vector3 controlScale8 = Vector3.zero;
        controlScale8.x = actionBuffers.ContinuousActions[90];
        controlScale8.y = actionBuffers.ContinuousActions[91];
        controlScale8.z = actionBuffers.ContinuousActions[92];

        float rowR8 = actionBuffers.ContinuousActions[93];
        float rowG8 = actionBuffers.ContinuousActions[94];
        float rowB8 = actionBuffers.ContinuousActions[95];
        Objcolor8.r = Mathf.Abs(rowR8);
        Objcolor8.g = Mathf.Abs(rowG8);
        Objcolor8.b = Mathf.Abs(rowB8);

        //obj9
        Vector3 controlPosition9 = Vector3.zero;
        controlPosition9.x = actionBuffers.ContinuousActions[96];
        controlPosition9.y = actionBuffers.ContinuousActions[97];
        controlPosition9.z = actionBuffers.ContinuousActions[98];

        Vector3 controlRotaion9= Vector3.zero;
        controlRotaion9.x = actionBuffers.ContinuousActions[99];
        controlRotaion9.y = actionBuffers.ContinuousActions[100];
        controlRotaion9.z = actionBuffers.ContinuousActions[101];

        Vector3 controlScale9 = Vector3.zero;
        controlScale9.x = actionBuffers.ContinuousActions[102];
        controlScale9.y = actionBuffers.ContinuousActions[103];
        controlScale9.z = actionBuffers.ContinuousActions[104];

        float rowR9 = actionBuffers.ContinuousActions[105];
        float rowG9 = actionBuffers.ContinuousActions[106];
        float rowB9 = actionBuffers.ContinuousActions[107];
        Objcolor9.r = Mathf.Abs(rowR9);
        Objcolor9.g = Mathf.Abs(rowG9);
        Objcolor9.b = Mathf.Abs(rowB9);


         //obj10
        Vector3 controlPosition10 = Vector3.zero;
        controlPosition10.x = actionBuffers.ContinuousActions[108];
        controlPosition10.y = actionBuffers.ContinuousActions[109];
        controlPosition10.z = actionBuffers.ContinuousActions[110];

        Vector3 controlRotaion10= Vector3.zero;
        controlRotaion10.x = actionBuffers.ContinuousActions[111];
        controlRotaion10.y = actionBuffers.ContinuousActions[112];
        controlRotaion10.z = actionBuffers.ContinuousActions[113];

        Vector3 controlScale10 = Vector3.zero;
        controlScale10.x = actionBuffers.ContinuousActions[114];
        controlScale10.y = actionBuffers.ContinuousActions[115];
        controlScale10.z = actionBuffers.ContinuousActions[116];

        float rowR10 = actionBuffers.ContinuousActions[117];
        float rowG10 = actionBuffers.ContinuousActions[118];
        float rowB10 = actionBuffers.ContinuousActions[119];
        Objcolor10.r = Mathf.Abs(rowR10);
        Objcolor10.g = Mathf.Abs(rowG10);
        Objcolor10.b = Mathf.Abs(rowB10);

        //obj11
        Vector3 controlPosition11 = Vector3.zero;
        controlPosition11.x = actionBuffers.ContinuousActions[120];
        controlPosition11.y = actionBuffers.ContinuousActions[121];
        controlPosition11.z = actionBuffers.ContinuousActions[122];

        Vector3 controlRotaion11= Vector3.zero;
        controlRotaion11.x = actionBuffers.ContinuousActions[123];
        controlRotaion11.y = actionBuffers.ContinuousActions[124];
        controlRotaion11.z = actionBuffers.ContinuousActions[125];

        Vector3 controlScale11 = Vector3.zero;
        controlScale11.x = actionBuffers.ContinuousActions[126];
        controlScale11.y = actionBuffers.ContinuousActions[127];
        controlScale11.z = actionBuffers.ContinuousActions[128];

        float rowR11 = actionBuffers.ContinuousActions[129];
        float rowG11 = actionBuffers.ContinuousActions[130];
        float rowB11 = actionBuffers.ContinuousActions[131];
        Objcolor11.r = Mathf.Abs(rowR11);
        Objcolor11.g = Mathf.Abs(rowG11);
        Objcolor11.b = Mathf.Abs(rowB11);

        //obj12
        Vector3 controlPosition12 = Vector3.zero;
        controlPosition12.x = actionBuffers.ContinuousActions[132];
        controlPosition12.y = actionBuffers.ContinuousActions[133];
        controlPosition12.z = actionBuffers.ContinuousActions[134];

        Vector3 controlRotaion12= Vector3.zero;
        controlRotaion12.x = actionBuffers.ContinuousActions[135];
        controlRotaion12.y = actionBuffers.ContinuousActions[136];
        controlRotaion12.z = actionBuffers.ContinuousActions[137];

        Vector3 controlScale12 = Vector3.zero;
        controlScale12.x = actionBuffers.ContinuousActions[138];
        controlScale12.y = actionBuffers.ContinuousActions[139];
        controlScale12.z = actionBuffers.ContinuousActions[140];

        float rowR12 = actionBuffers.ContinuousActions[141];
        float rowG12 = actionBuffers.ContinuousActions[142];
        float rowB12 = actionBuffers.ContinuousActions[143];
        Objcolor12.r = Mathf.Abs(rowR12);
        Objcolor12.g = Mathf.Abs(rowG12);
        Objcolor12.b = Mathf.Abs(rowB12);

        //obj13
        Vector3 controlPosition13 = Vector3.zero;
        controlPosition13.x = actionBuffers.ContinuousActions[144];
        controlPosition13.y = actionBuffers.ContinuousActions[145];
        controlPosition13.z = actionBuffers.ContinuousActions[146];

        Vector3 controlRotaion13= Vector3.zero;
        controlRotaion13.x = actionBuffers.ContinuousActions[147];
        controlRotaion13.y = actionBuffers.ContinuousActions[148];
        controlRotaion13.z = actionBuffers.ContinuousActions[149];

        Vector3 controlScale13 = Vector3.zero;
        controlScale13.x = actionBuffers.ContinuousActions[150];
        controlScale13.y = actionBuffers.ContinuousActions[151];
        controlScale13.z = actionBuffers.ContinuousActions[152];

        float rowR13 = actionBuffers.ContinuousActions[153];
        float rowG13 = actionBuffers.ContinuousActions[154];
        float rowB13 = actionBuffers.ContinuousActions[155];
        Objcolor13.r = Mathf.Abs(rowR13);
        Objcolor13.g = Mathf.Abs(rowG13);
        Objcolor13.b = Mathf.Abs(rowB13);

        //obj14
        Vector3 controlPosition14 = Vector3.zero;
        controlPosition14.x = actionBuffers.ContinuousActions[156];
        controlPosition14.y = actionBuffers.ContinuousActions[157];
        controlPosition14.z = actionBuffers.ContinuousActions[158];

        Vector3 controlRotaion14= Vector3.zero;
        controlRotaion14.x = actionBuffers.ContinuousActions[159];
        controlRotaion14.y = actionBuffers.ContinuousActions[160];
        controlRotaion14.z = actionBuffers.ContinuousActions[161];

        Vector3 controlScale14 = Vector3.zero;
        controlScale14.x = actionBuffers.ContinuousActions[162];
        controlScale14.y = actionBuffers.ContinuousActions[163];
        controlScale14.z = actionBuffers.ContinuousActions[164];

        float rowR14 = actionBuffers.ContinuousActions[165];
        float rowG14 = actionBuffers.ContinuousActions[166];
        float rowB14 = actionBuffers.ContinuousActions[167];
        Objcolor14.r = Mathf.Abs(rowR14);
        Objcolor14.g = Mathf.Abs(rowG14);
        Objcolor14.b = Mathf.Abs(rowB14);

         //obj15
        Vector3 controlPosition15 = Vector3.zero;
        controlPosition15.x = actionBuffers.ContinuousActions[168];
        controlPosition15.y = actionBuffers.ContinuousActions[169];
        controlPosition15.z = actionBuffers.ContinuousActions[170];

        Vector3 controlRotaion15= Vector3.zero;
        controlRotaion15.x = actionBuffers.ContinuousActions[171];
        controlRotaion15.y = actionBuffers.ContinuousActions[172];
        controlRotaion15.z = actionBuffers.ContinuousActions[173];

        Vector3 controlScale15 = Vector3.zero;
        controlScale15.x = actionBuffers.ContinuousActions[174];
        controlScale15.y = actionBuffers.ContinuousActions[175];
        controlScale15.z = actionBuffers.ContinuousActions[176];

        float rowR15 = actionBuffers.ContinuousActions[177];
        float rowG15 = actionBuffers.ContinuousActions[178];
        float rowB15 = actionBuffers.ContinuousActions[179];
        Objcolor15.r = Mathf.Abs(rowR15);
        Objcolor15.g = Mathf.Abs(rowG15);
        Objcolor15.b = Mathf.Abs(rowB15);

        //obj16
        Vector3 controlPosition16 = Vector3.zero;
        controlPosition16.x = actionBuffers.ContinuousActions[180];
        controlPosition16.y = actionBuffers.ContinuousActions[181];
        controlPosition16.z = actionBuffers.ContinuousActions[182];

        Vector3 controlRotaion16= Vector3.zero;
        controlRotaion16.x = actionBuffers.ContinuousActions[183];
        controlRotaion16.y = actionBuffers.ContinuousActions[184];
        controlRotaion16.z = actionBuffers.ContinuousActions[185];

        Vector3 controlScale16 = Vector3.zero;
        controlScale16.x = actionBuffers.ContinuousActions[186];
        controlScale16.y = actionBuffers.ContinuousActions[187];
        controlScale16.z = actionBuffers.ContinuousActions[188];

        float rowR16 = actionBuffers.ContinuousActions[189];
        float rowG16 = actionBuffers.ContinuousActions[190];
        float rowB16 = actionBuffers.ContinuousActions[191];
        Objcolor16.r = Mathf.Abs(rowR16);
        Objcolor16.g = Mathf.Abs(rowG16);
        Objcolor16.b = Mathf.Abs(rowB16);


        //ClayObject sent Objcolor1
        clayobject1 = obj1.GetComponent<ClayObject>();
        clayobject1.color = Objcolor1;
        //ClayObject sent Objcolor2
        clayobject2 = obj2.GetComponent<ClayObject>();
        clayobject2.color = Objcolor2;
        //ClayObject sent Objcolor3
        clayobject3 = obj3.GetComponent<ClayObject>();
        clayobject3.color = Objcolor3;
        //ClayObject sent Objcolor4
        clayobject4 = obj4.GetComponent<ClayObject>();
        clayobject4.color = Objcolor4;
        //ClayObject sent Objcolor5
        clayobject5 = obj5.GetComponent<ClayObject>();
        clayobject5.color = Objcolor5;
        //ClayObject sent Objcolor6
        clayobject6 = obj6.GetComponent<ClayObject>();
        clayobject6.color = Objcolor6;
        //ClayObject sent Objcolor7
        clayobject7 = obj7.GetComponent<ClayObject>();
        clayobject7.color = Objcolor7;
        //ClayObject sent Objcolor8
        clayobject8 = obj8.GetComponent<ClayObject>();
        clayobject8.color = Objcolor8;
        //ClayObject sent Objcolor9
        clayobject9 = obj9.GetComponent<ClayObject>();
        clayobject9.color = Objcolor9;
        //ClayObject sent Objcolor10
        clayobject10 = obj10.GetComponent<ClayObject>();
        clayobject10.color = Objcolor10;
        //ClayObject sent Objcolor11
        clayobject11 = obj11.GetComponent<ClayObject>();
        clayobject11.color = Objcolor11;
        //ClayObject sent Objcolor12
        clayobject12 = obj12.GetComponent<ClayObject>();
        clayobject12.color = Objcolor12;
        //ClayObject sent Objcolor13
        clayobject13 = obj13.GetComponent<ClayObject>();
        clayobject13.color = Objcolor13;
        //ClayObject sent Objcolor14
        clayobject14 = obj14.GetComponent<ClayObject>();
        clayobject14.color = Objcolor14;
        //ClayObject sent Objcolor15
        clayobject15 = obj15.GetComponent<ClayObject>();
        clayobject15.color = Objcolor15;
        //ClayObject sent Objcolor16
        clayobject16 = obj16.GetComponent<ClayObject>();
        clayobject16.color = Objcolor16;

        //TRANSFORM////////////////////////////////////////////////////////////////////////////////

        //transform obj1
        obj1.transform.localPosition = controlPosition1;
        obj1.transform.rotation= Quaternion.Euler(controlRotaion1);
        obj1.transform.localScale = controlScale1*5;
         //transform obj2
        obj2.transform.localPosition = controlPosition2;
        obj2.transform.rotation= Quaternion.Euler(controlRotaion2);
        obj2.transform.localScale = controlScale2*5;
         //transform obj3
        obj3.transform.localPosition = controlPosition3;
        obj3.transform.rotation= Quaternion.Euler(controlRotaion3);
        obj3.transform.localScale = controlScale3*5;
         //transform obj4
        obj4.transform.localPosition = controlPosition4;
        obj4.transform.rotation= Quaternion.Euler(controlRotaion4);
        obj4.transform.localScale = controlScale4*5;
        //transform obj5
        obj5.transform.localPosition = controlPosition5;
        obj5.transform.rotation= Quaternion.Euler(controlRotaion5);
        obj5.transform.localScale = controlScale5*5;
         //transform obj6
        obj6.transform.localPosition = controlPosition6;
        obj6.transform.rotation= Quaternion.Euler(controlRotaion6);
        obj6.transform.localScale = controlScale6*5;
         //transform obj7
        obj7.transform.localPosition = controlPosition7;
        obj7.transform.rotation= Quaternion.Euler(controlRotaion7);
        obj7.transform.localScale = controlScale7*5;
         //transform obj8
        obj8.transform.localPosition = controlPosition8;
        obj8.transform.rotation= Quaternion.Euler(controlRotaion8);
        obj8.transform.localScale = controlScale8*5;
        //transform obj9
        obj9.transform.localPosition = controlPosition9;
        obj9.transform.rotation= Quaternion.Euler(controlRotaion9);
        obj9.transform.localScale = controlScale9*5;
         //transform obj10
        obj10.transform.localPosition = controlPosition10;
        obj10.transform.rotation= Quaternion.Euler(controlRotaion10);
        obj10.transform.localScale = controlScale10*5;
         //transform obj11
        obj11.transform.localPosition = controlPosition11;
        obj11.transform.rotation= Quaternion.Euler(controlRotaion11);
        obj11.transform.localScale = controlScale11*5;
         //transform obj12
        obj12.transform.localPosition = controlPosition12;
        obj12.transform.rotation= Quaternion.Euler(controlRotaion12);
        obj12.transform.localScale = controlScale12*5;
        //transform obj13
        obj13.transform.localPosition = controlPosition13;
        obj13.transform.rotation= Quaternion.Euler(controlRotaion13);
        obj13.transform.localScale = controlScale13*5;
         //transform obj14
        obj14.transform.localPosition = controlPosition14;
        obj14.transform.rotation= Quaternion.Euler(controlRotaion14);
        obj14.transform.localScale = controlScale14*5;
         //transform obj15
        obj15.transform.localPosition = controlPosition15;
        obj15.transform.rotation= Quaternion.Euler(controlRotaion15);
        obj15.transform.localScale = controlScale15*5;
         //transform obj16
        obj16.transform.localPosition = controlPosition16;
        obj16.transform.rotation= Quaternion.Euler(controlRotaion16);
        obj16.transform.localScale = controlScale16*5;
     

        // too far
      float distanceBetweenObject1 = Vector3.Distance(obj1.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject2 = Vector3.Distance(obj2.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject3 = Vector3.Distance(obj3.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject4 = Vector3.Distance(obj4.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject5 = Vector3.Distance(obj5.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject6 = Vector3.Distance(obj6.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject7 = Vector3.Distance(obj7.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject8 = Vector3.Distance(obj8.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject9 = Vector3.Distance(obj9.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject10 = Vector3.Distance(obj10.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject11 = Vector3.Distance(obj11.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject12 = Vector3.Distance(obj12.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject13 = Vector3.Distance(obj13.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject14 = Vector3.Distance(obj14.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject15 = Vector3.Distance(obj15.transform.localPosition,empty.transform.localPosition);
      float distanceBetweenObject16 = Vector3.Distance(obj16.transform.localPosition,empty.transform.localPosition);
          
      Debug.Log(distanceBetweenObject1);
      Debug.Log(distanceBetweenObject2);
      Debug.Log(distanceBetweenObject3);
      Debug.Log(distanceBetweenObject4);
      Debug.Log(distanceBetweenObject5);
      Debug.Log(distanceBetweenObject6);
      Debug.Log(distanceBetweenObject7);
      Debug.Log(distanceBetweenObject8);
      Debug.Log(distanceBetweenObject9);
      Debug.Log(distanceBetweenObject10);
      Debug.Log(distanceBetweenObject11);
      Debug.Log(distanceBetweenObject12);
      Debug.Log(distanceBetweenObject13);
      Debug.Log(distanceBetweenObject14);
      Debug.Log(distanceBetweenObject15);
      Debug.Log(distanceBetweenObject16);

      if(Mathf.Abs(distanceBetweenObject1) > 3f || Mathf.Abs(distanceBetweenObject2) > 3f ||Mathf.Abs(distanceBetweenObject3) > 3f || Mathf.Abs(distanceBetweenObject4) > 3f
     || Mathf.Abs(distanceBetweenObject5) > 3f || Mathf.Abs(distanceBetweenObject6) > 3f ||Mathf.Abs(distanceBetweenObject7) > 3f || Mathf.Abs(distanceBetweenObject8) > 3f
     || Mathf.Abs(distanceBetweenObject9) > 3f || Mathf.Abs(distanceBetweenObject10) > 3f ||Mathf.Abs(distanceBetweenObject11) > 3f || Mathf.Abs(distanceBetweenObject12) > 3f
     || Mathf.Abs(distanceBetweenObject13) > 3f || Mathf.Abs(distanceBetweenObject14) > 3f ||Mathf.Abs(distanceBetweenObject15) > 3f || Mathf.Abs(distanceBetweenObject16) > 3f)
        {  

            Debug.Log("too far EndEpisode");
            EndEpisode();
        }
     
       //to start GetImagePixels.cs
         getImagePixels = imagepixel.GetComponent<GetImagePixels>();
         getImagePixels.start = true;
       // Debug.Log("true");
   
     

        // time over
     if(timeChecker == true)
     {   
         timeChecker = false;
      //   Debug.Log("time over EndEpisode");
         EndEpisode();
     }
    } 

    public void GetReward()
    {
      Debug.Log(reward);
      AddReward(reward);
      EndEpisode();
  
    }
    
    //count time
     private void Update()
     {
         if(timeCount == true)
         {
         //    Debug.Log("counting");
             float timeCounter = 0f;
             timeCounter += Time.deltaTime;
          //   Debug.Log("timeCounter"+timeCounter);

             if(timeCounter > 1f){
                 Debug.Log("10s past");
                 timeChecker = true;
                 timeCount = false;
                 timeCounter = 0f;
             }

         }
    }

}