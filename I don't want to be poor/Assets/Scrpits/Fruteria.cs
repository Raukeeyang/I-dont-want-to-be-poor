using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruteria : MonoBehaviour
{
    public int platanosDar;
    public int uvasDar;
    public int duriansDar;
    public int sandiasDar;
    int recover;

    public Inventory Inventory;
    void OnTriggerEnter2D()
    {

        Debug.Log("entramos en el coplldier");
        Inventory.platanos = 0;
        Inventory.uvas = 0;
        Inventory.durians = 0;
        Inventory.sandias = 0;
        recover = platanosDar;
        while (platanosDar > 0)
        {
            Inventory.RecibirFruta(1);
            platanosDar -= 1;
            Debug.Log("fruteria platanos");
        }
        platanosDar = recover;
        recover = uvasDar;
        while (uvasDar > 0)
        {
            Inventory.RecibirFruta(2);
            uvasDar -= 1;
        }
        uvasDar = recover;
        recover = duriansDar;
        while (duriansDar > 0)
        {
            Inventory.RecibirFruta(3);
            duriansDar -= 1;
        }
        duriansDar = recover;
        recover = sandiasDar;
        while (sandiasDar > 0)
        {
            Inventory.RecibirFruta(4);
            sandiasDar -= 1;
        }
        sandiasDar = recover;
    }
}
