using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruteria : MonoBehaviour
{
    public int platanosDar;
    public int uvasDar;
    public int duriansDar;
    public int sandiasDar;

    public Inventory Inventory;
    void OnTriggerEnter()
    {
        Inventory.platanos = 0;
        Inventory.uvas = 0;
        Inventory.durians = 0;
        Inventory.sandias = 0;
        while (platanosDar > 0)
        {
            Inventory.RecibirFruta(1);
            platanosDar -= 1;
        }
        while (uvasDar > 0)
        {
            Inventory.RecibirFruta(2);
            uvasDar -= 1;
        }
        while (duriansDar > 0)
        {
            Inventory.RecibirFruta(3);
            duriansDar -= 1;
        }
        while (sandiasDar > 0)
        {
            Inventory.RecibirFruta(4);
            sandiasDar -= 1;
        }
    }
}
