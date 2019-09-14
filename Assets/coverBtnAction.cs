using UnityEngine;
using Vuforia;
using System.Collections;
using System.Collections.Generic;

public class coverBtnAction : MonoBehaviour, IVirtualButtonEventHandler {
    public GameObject vbBtnObj;

    // Start is called before the first frame update
    void Start() {
        vbBtnObj = GameObject.Find("coverBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log("Button pressed!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("Button released!");
    }

    // Update is called once per frame
    void Update() {
        
    }
}
