using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(0.3f, 1.0f);
        transform.position = pos;
    }
}
