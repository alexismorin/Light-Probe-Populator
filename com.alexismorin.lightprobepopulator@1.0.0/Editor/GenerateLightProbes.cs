using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GenerateLightProbes : MonoBehaviour
{
    [MenuItem("Tools/Generate Light Probe Groups - Low Resolution")]
    static void generateLow()
    {

        GameObject lightProbes;
        List<Vector3> probeLocations = new List<Vector3>();

        if(GameObject.Find("Light Probe Group") != null){
            DestroyImmediate(GameObject.Find("Light Probe Group"));
        }

        lightProbes = new GameObject("Light Probe Group");
        lightProbes.AddComponent<LightProbeGroup>();
        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();

        GameObject[] objectsInScene = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject obj in objectsInScene)
            {
                if(obj.isStatic){

                    if(obj.GetComponent<Renderer>() != null){
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.max);
                    }


                
            }
        }

        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();
    }

    [MenuItem("Tools/Generate Light Probe Groups - Medium Resolution")]
    static void generateMedium()
    {

        GameObject lightProbes;
        List<Vector3> probeLocations = new List<Vector3>();

        if(GameObject.Find("Light Probe Group") != null){
            DestroyImmediate(GameObject.Find("Light Probe Group"));
        }

        lightProbes = new GameObject("Light Probe Group");
        lightProbes.AddComponent<LightProbeGroup>();
        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();

        GameObject[] objectsInScene = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject obj in objectsInScene)
            {
                if(obj.isStatic){

                    if(obj.GetComponent<Renderer>() != null){
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.max);
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.min);
                    }


                
            }
        }

        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();
    }

    [MenuItem("Tools/Generate Light Probe Groups - High Resolution")]
    static void generateHigh()
    {

        GameObject lightProbes;
        List<Vector3> probeLocations = new List<Vector3>();

        if(GameObject.Find("Light Probe Group") != null){
            DestroyImmediate(GameObject.Find("Light Probe Group"));
        }

        lightProbes = new GameObject("Light Probe Group");
        lightProbes.AddComponent<LightProbeGroup>();
        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();

        GameObject[] objectsInScene = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject obj in objectsInScene)
            {
                if(obj.isStatic){

                    if(obj.GetComponent<Renderer>() != null){
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.max);
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.min);
                    }

                
            }
        }

        int boundProbes = probeLocations.Count *2;
        for(int i = 0; i < boundProbes; i++)
        {
            probeLocations.Add(Vector3.Lerp(probeLocations[Random.Range(0,boundProbes/2)], probeLocations[Random.Range(0,boundProbes/2)], 0.5f));
            
        }

        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();
    }

    [MenuItem("Tools/Generate Light Probe Groups - Very High Resolution")]
    static void generateVeryHigh()
    {

        GameObject lightProbes;
        List<Vector3> probeLocations = new List<Vector3>();

        if(GameObject.Find("Light Probe Group") != null){
            DestroyImmediate(GameObject.Find("Light Probe Group"));
        }

        lightProbes = new GameObject("Light Probe Group");
        lightProbes.AddComponent<LightProbeGroup>();
        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();

        GameObject[] objectsInScene = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject obj in objectsInScene)
            {
                if(obj.isStatic){

                    if(obj.GetComponent<Renderer>() != null){
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.max);
                        probeLocations.Add( obj.GetComponent<Renderer>().bounds.min);
                    }

                
            }
        }

        int boundProbes = probeLocations.Count *4;
        for(int i = 0; i < boundProbes; i++)
        {
            probeLocations.Add(Vector3.Lerp(probeLocations[Random.Range(0,boundProbes/4)], probeLocations[Random.Range(0,boundProbes/4)], 0.5f));
            
        }

        lightProbes.GetComponent<LightProbeGroup>().probePositions = probeLocations.ToArray();
    }


}
