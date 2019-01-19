using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TicketInteractionManager : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vrTicketButton;

    // Use this for initialization
    private void Start()
    {
        vrTicketButton = GameObject.Find("VRTicketButton");
        vrTicketButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        GameObject.Find("Master").GetComponent<Master>().ticketCanvas.gameObject.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        GameObject.Find("Master").GetComponent<Master>().ticketCanvas.gameObject.SetActive(false);
    }
}