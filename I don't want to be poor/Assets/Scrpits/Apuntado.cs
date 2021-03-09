using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntado : MonoBehaviour
{
    public float speed;
    public Transform apuntado;
    public Transform banana;

    void Update()
    {
        Vector2 direccion = apuntado.position - banana.position;
        transform.Translate(direccion.normalized * speed * Time.deltaTime, Space.World);
    }

}
