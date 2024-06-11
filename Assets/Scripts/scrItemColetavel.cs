using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrItemColetavel : MonoBehaviour
{
    public Sprite itemSprite; // Imagem do item para o inventário

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Adicionar o item ao inventário
            InventoryManager.instance.AddItem(itemSprite);

            // Destruir o objeto
            Destroy(gameObject);
        }
    }
}
