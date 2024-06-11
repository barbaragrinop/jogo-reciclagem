using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GerenciadorPontos : MonoBehaviour
{
   public TextMeshProUGUI pontosText;
    private int pontos = 0;

    // Método para adicionar pontos
    public void AdicionarPonto()
    {
        pontos++;
        AtualizarPontosText();
        Debug.Log("Ponto adicionado. Pontos atuais: " + pontos);
    }

    // Método para atualizar o texto dos pontos na tela
    void AtualizarPontosText()
    {
        if (pontosText != null)
        {
            pontosText.text = "" + pontos;
        }
        else
        {
            Debug.LogError("pontosText não está atribuído no Inspector");
        }
    }
}
