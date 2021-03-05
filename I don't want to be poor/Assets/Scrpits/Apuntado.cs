using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntado : MonoBehaviour
{
    public float speed;
    public Transform apuntado;

    void Start()
    {
        var direccion = apuntado.position - this.transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        while (true)
        {
            transform.Translate(direccion.normalized * distanceThisFrame, Space.World);
        }
    }

}
