using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public StadiumController stadiumController;
    public Transform statsCanvas;
    public Transform ticketCanvas;
    public GameObject EnglandJersey;
    public GameObject TunisisaJersey;
    public GameObject CloseJerseys;

    // Use this for initialization
    private void Start()
    {
        statsCanvas.gameObject.SetActive(false);
        ticketCanvas.gameObject.SetActive(false);
        EnglandJersey.SetActive(false);
        TunisisaJersey.SetActive(false);
        CloseJerseys.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}