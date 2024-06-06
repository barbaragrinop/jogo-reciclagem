using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrPegaLixo : MonoBehaviour
{
    public Image imgLixo;
    // Imagem do objeto que será exibida na UI
    public Sprite Lixo;

    // Booleano para indicar se o objeto foi coletado
    public bool isCollected = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            Debug.Log("Em contato");
            Collect();
        }
    }

    void Collect()
    {
        isCollected = true;
        
        // Exibir a imagem do objeto na interface
        if (imgLixo != null && Lixo != null)
        {
            imgLixo.sprite = Lixo;
            imgLixo.enabled = true;
        }

        // Destruir o objeto no jogo
        Destroy(gameObject);
    }

    public bool IsCollected()
    {
        return isCollected;
    }
}
