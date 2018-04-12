using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipViewer : MonoBehaviour {

    public GameObject outside;
    public GameObject inside;
    public GameObject Eoutside;
    public GameObject Einside;

    void Update () {
        if (Camera.main.orthographicSize <= 3)
        {
            outside.SetActive(false);
            inside.SetActive(true);
            Eoutside.SetActive(false);
            Einside.SetActive(true);
        }
        else
        {
            outside.SetActive(true);
            inside.SetActive(false);
            Eoutside.SetActive(true);
            Einside.SetActive(false);
        }
    }
}
