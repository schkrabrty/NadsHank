using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamVR_Activator : MonoBehaviour {
    private GameObject pedestrian;
    public GameObject HMD, CameraRig;
    private Quaternion temp;
    private bool configuration_done;

	// Use this for initialization
	void Start () {
        configuration_done = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (pedestrian == null)
        {
            pedestrian = GameObject.Find("Sim3");
            Debug.Log("Pedetrian = " + pedestrian.name);
            Debug.Log("Pedestrian position = " + pedestrian.transform.position);
        }

        if (pedestrian != null && configuration_done == false)
        {
            CameraRig.transform.position = new Vector3 (pedestrian.transform.position.x, 0f, pedestrian.transform.position.z);
            Debug.Log("CameraRig new position = " + CameraRig.transform.position);
            configuration_done = true;
        }

        if (configuration_done == true)
        {
            pedestrian.transform.position = new Vector3(HMD.transform.position.x, 0f, HMD.transform.position.z);
            Debug.Log("New Pedestrian position = " + pedestrian.transform.position);
        }
    }
}
