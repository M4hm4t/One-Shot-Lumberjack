using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    public int trees;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("new state");
            GameObject statePrefab = Resources.Load<GameObject>("States/State");// State prefab�n� resources tan �ektik

            GameObject state = Instantiate(statePrefab); // �ekti�imiz prefab� sahneye ekledik.

            state.name = "New State";

            state.transform.position = transform.position;

            Destroy(gameObject);

        }
    }
}
