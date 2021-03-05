using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntado : MonoBehaviour
{
    public float speed;
    public Transform apuntado;
    public Transform banana;

    void Start()
    {
        var direccion = apuntado.position - banana.position;
        while (1 > 0)
        {
            transform.Translate(direccion.normalized * speed * Time.deltaTime, Space.World);
        }
    }

}
