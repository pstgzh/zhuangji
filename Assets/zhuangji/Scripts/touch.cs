using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wvr;

public class touch : MonoBehaviour {

    public GameObject BeamObject;
    public WVR_DeviceType device = WVR_DeviceType.WVR_DeviceType_HMD;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
        if (BeamObject.tag == "beam" && WaveVR_Controller.Input(device).GetPressDown(WVR_InputId.WVR_InputId_Alias1_Menu))
        {
            Debug3D.Instance.Debug("Beam1");
        }
        else if(BeamObject.tag == "beam2" && WaveVR_Controller.Input(device).GetPressDown(WVR_InputId.WVR_InputId_Alias1_Grip))
        {
            Debug3D.Instance.Debug("Beam2");
        }
        else if(BeamObject.tag == "beam3" && WaveVR_Controller.Input(device).GetPressDown(WVR_InputId.WVR_InputId_Alias1_Trigger))
        {
            Debug3D.Instance.Debug("Beam3");
        }
    }
}
