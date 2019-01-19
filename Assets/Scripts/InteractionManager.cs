using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class InteractionManager : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vrPitchButton;

    // Use this for initialization
    private void Start()
    {
        vrPitchButton = GameObject.Find("VRPitchButton");
        vrPitchButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        GameObject.Find("Master").GetComponent<Master>().statsCanvas.gameObject.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        GameObject.Find("Master").GetComponent<Master>().statsCanvas.gameObject.SetActive(false);
    }
}