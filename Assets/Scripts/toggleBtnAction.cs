using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class toggleBtnAction : MonoBehaviour, IVirtualButtonEventHandler {
    // Start is called before the first frame update
    GameObject toggleBtn;
    TextMesh toggleBtnLbl;
    GameObject info;
    GameObject reviews;
    bool infoShowing;

    void Start() {
        toggleBtn = GameObject.Find("ToggleBtn");
        toggleBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        toggleBtnLbl = GameObject.Find("ToggleText").GetComponent<TextMesh>();

        info = GameObject.Find("Book Info");
        reviews = GameObject.Find("Reviews");
        
        reviews.SetActive(false);
        infoShowing = true;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        if (infoShowing) {
            info.SetActive(false);
            reviews.SetActive(true);
            toggleBtnLbl.text = "Info";
            infoShowing = false;
        } else {
            reviews.SetActive(false);
            info.SetActive(true);
            toggleBtnLbl.text = "Reviews";
            infoShowing = true;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
