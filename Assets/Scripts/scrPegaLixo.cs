using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrPegaLixo : MonoBehaviour
{
    public Image imgLixo;
    public Sprite Lixo;

    public bool isCollected = false;
    public TipoLixo tipoLixo = TipoLixo.Nenhum;
    private scrPlayerLixo playerLixo;

    void Start()
    {
        // Buscar o script scrPlayerLixo no jogador
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerLixo = player.GetComponent<scrPlayerLixo>();
        }

        GameObject imgLixoGameObject = GameObject.FindGameObjectWithTag("Image"); // Substitua "NomeDoGameObjectDaImagem" pelo nome real do GameObject que contém a Image
        if (imgLixoGameObject != null)
        {
            imgLixo = imgLixoGameObject.GetComponent<Image>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !playerLixo.isCollected)
        {
            Debug.Log("Em contato");
            Collect(other.gameObject);
        }
    }

    void Collect(GameObject player)
    {
        isCollected = true;

        // Exibir a imagem do objeto na interface
        if (imgLixo != null && Lixo != null)
        {
            imgLixo.sprite = Lixo;
            imgLixo.enabled = true;
        }

        // Configurar o tipo de lixo no player
        scrPlayerLixo playerLixo = player.GetComponent<scrPlayerLixo>();
        if (playerLixo != null)
        {
            playerLixo.tipoLixo = tipoLixo;
            playerLixo.imgLixo = imgLixo;
            playerLixo.isCollected = true;
        }

        Destroy(gameObject);
    }
}
