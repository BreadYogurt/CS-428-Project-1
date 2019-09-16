using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class toggleBtnAction : MonoBehaviour, IVirtualButtonEventHandler {
    // Start is called before the first frame update
    GameObject toggleBtn;
    GameObject info;
    GameObject reviews;
    TextMesh toggleBtnLbl;
    bool infoShowing;

    void Start() {
        toggleBtn = GameObject.Find("ToggleBtn");
        toggleBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        info = GameObject.Find("Book Info");
        reviews = GameObject.Find("Reviews");
        toggleBtnLbl = GameObject.Find("ToggleText").GetComponent<TextMesh>();
        
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
            info.SetActive(true);
            reviews.SetActive(false);
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
