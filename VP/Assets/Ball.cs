using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
   
    private Vector3 pocetnaPozicija;
    private Vector3 krajnapozicija;
    public GameObject TopkaPrefab;
    [SerializeField]
   
	// Update is called once per frame
	private void Update () {

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.back * -10;
        if (Input.GetMouseButtonDown(0))
        {
            Presmetaj(worldPos);
        }
        else if (Input.GetMouseButton(0))
        {
            Prodolzi(worldPos);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Zavrsi();
        }
    }
    void Presmetaj(Vector3 worldPos)
    {
        pocetnaPozicija = worldPos;
    }
    void Prodolzi(Vector3 worldPos)
    {
        krajnapozicija = worldPos;
    }
    void Zavrsi()
    {
        Vector3 nasoka = krajnapozicija - pocetnaPozicija;
        nasoka.Normalize();

        var topka = Instantiate(TopkaPrefab, transform.position, Quaternion.identity);
        topka.GetComponent<Rigidbody2D>().AddForce(-nasoka);
    }

}
