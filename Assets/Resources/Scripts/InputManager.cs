using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Use this for initialization
    private Vector3 touchPosWorld;

    private GameObject Master;

    private Touch touch;

    private void Start()
    {
        Master = GameObject.Find("Master");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.name == "Shop")
                        {
                            //hit.collider.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
                            Master.GetComponent<Master>().EnglandJersey.gameObject.SetActive(true);
                            Master.GetComponent<Master>().TunisisaJersey.gameObject.SetActive(true);
                            Master.GetComponent<Master>().CloseJerseys.SetActive(true);
                        }
                        else if (hit.collider.name == "TicketOffice")
                        {
                            print("object is " + hit.collider.name);
                            hit.collider.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
                            Master.GetComponent<Master>().ticketCanvas.gameObject.SetActive(true);
                        }
                        else if (hit.collider.name == "CloseJerseys")
                        {
                            hit.collider.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
                            Master.GetComponent<Master>().EnglandJersey.gameObject.SetActive(false);
                            Master.GetComponent<Master>().TunisisaJersey.gameObject.SetActive(false);
                            Master.GetComponent<Master>().CloseJerseys.SetActive(false);
                        }
                    }

                    break;
            }
        }
    }
}