using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int frutasMax;
    public int frutasActuales;
    public int platanos;
    public int uvas;
    public int durians;
    public int sandias;

    public void RecibirFruta(int fruta)
    {
        if (frutasMax > frutasActuales)
        {
            switch (fruta)
            {
                case 1:
                    platanos += 1;
                    break;
                case 2:
                    uvas += 1;
                    break;
                case 3:
                    sandias += 1;
                    break;
                case 4:
                    durians += 1;
                    break;

            }
        }
    }

    void UsarFruta(int frutaUsada)
    {
        switch (frutaUsada)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
    }
}
