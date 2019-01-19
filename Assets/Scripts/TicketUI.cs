using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicketUI : MonoBehaviour
{
    public Button closeButton;

    // Use this for initialization
    private void Start()
    {
        closeButton.onClick.AddListener(CloseWindow);
    }

    private void CloseWindow()
    {
        transform.gameObject.SetActive(false);
        GameObject.Find("Master").GetComponent<Master>().stadiumController.TicketOffice.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}