using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<string> items = new List<string>();
    private Dictionary<string, int> itemCounts = new Dictionary<string, int>();


    // Start is called before the first frame update
    void Start()
    {
        string[] itemsArray = { "piedra", "poción", "antorcha", "llave" };

        MostrarItemArray(itemsArray);

        AgregarItemalInventario("espada");
        AgregarItemalInventario("poción");
        AgregarItemalInventario("escudo");
        ShowInventory();

        AumentarContadorItem("Poción");
        AumentarContadorItem("Poción");
        AumentarContadorItem("Llave");
        MostrarContadoresdeItems();

    }

    private void MostrarItemArray(string[] Array)
    {
        Debug.Log("Elementos del array: " + string.Join(", ", Array));
    }

    #region Listas
    private void AgregarItemalInventario(string item)
    {
        items.Add(item);
        Debug.Log("Has obtenido un/a " + item + "!");
    }

    private void ShowInventory()
    {
        Debug.Log("Inventario del jugador: " + string.Join(", ", items));
    }
    #endregion

    #region Diccionarios

    private void AumentarContadorItem(string item)
    {
        if(itemCounts.ContainsKey(item))
        {
            itemCounts[item]++;
        }
        else
        {
            itemCounts[item] = 1;
        }
    }

    private void MostrarContadoresdeItems()
    {
        foreach(var kvp in itemCounts)
        {
            Debug.Log("Tienes " + kvp.Value + " " + kvp.Key + "(s).");
        }
    }

    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
