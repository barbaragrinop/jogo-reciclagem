using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public Transform inventoryPanel; // Painel onde as imagens dos itens serão adicionadas
    public GameObject inventoryItemPrefab; // Prefab da imagem do item

    private void Awake()
    {
        // Assegurar que exista apenas uma instância do InventoryManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddItem(Sprite itemSprite)
    {
        // Criar uma nova imagem de item no inventário
        GameObject newItem = Instantiate(inventoryItemPrefab, inventoryPanel);
        newItem.GetComponent<Image>().sprite = itemSprite;
    }

}
