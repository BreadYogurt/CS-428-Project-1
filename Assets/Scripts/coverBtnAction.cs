using UnityEngine;
using Vuforia;
using System.Collections;
using System.Collections.Generic;

public class coverBtnAction : MonoBehaviour, IVirtualButtonEventHandler {
    public GameObject vbBtnObj;
    public GameObject actor;

    // Start is called before the first frame update
    void Start() {
        vbBtnObj = GameObject.Find("coverBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        actor = GameObject.Find("Jimmy Jett");
        actor.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log("Button pressed!");
        actor.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("Button released!");
        actor.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
