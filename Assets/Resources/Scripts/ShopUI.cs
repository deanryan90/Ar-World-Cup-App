using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    private Button exit;

    private Transform home;

    // Use this for initialization
    private void Start()
    {
        home = transform.Find("Home");
    }

    // Update is called once per frame
    private void Update()
    {
    }
}