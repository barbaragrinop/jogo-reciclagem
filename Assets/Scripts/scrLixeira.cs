using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scrLixeira : MonoBehaviour
{
    public TipoLixo tipoLixeira = TipoLixo.Nenhum;
    public TextMeshProUGUI pontosText;

    public TextMeshProUGUI mensagemText;

     public GerenciadorPontos gerenciadorPontos;
    public bool isPlayerInside;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
        }
    }

    private void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.Space))
        {
            scrPlayerLixo playerLixo = GameObject.FindGameObjectWithTag("Player").GetComponent<scrPlayerLixo>();

            if (playerLixo == null)
            {
                Debug.LogError("O objeto 'Player' não possui o componente 'scrPlayerLixo'");
                return;
            }

            Debug.Log("Player entrou na lixeira com lixo do tipo: " + playerLixo.tipoLixo);
            Debug.Log("Tipo da lixeira: " + tipoLixeira);

            if (playerLixo.isCollected)
            {
                if (tipoLixeira == playerLixo.tipoLixo)
                {
                    gerenciadorPontos.AdicionarPonto();
                    Debug.Log("Lixo descartado corretamente!");
                    playerLixo.ResetLixo(); // Reset do estado de coleta
                    ExibirMensagem("Lixeira Correta", Color.green);
                }
                else
                {
                    Debug.Log("Lixo descartado incorretamente!");
                    ExibirMensagem("Lixeira Incorreta", Color.red);
                }
            }
        }
    }

   void ExibirMensagem(string mensagem, Color cor)
    {
        if (mensagemText != null)
        {
            mensagemText.text = mensagem;
            mensagemText.color = cor; // Definimos a cor passada como argumento para a mensagem
            StartCoroutine(FadeMensagem());
        }
        else
        {
            Debug.LogError("mensagemText não está atribuído no Inspector para exibir a mensagem");
        }
    }

    IEnumerator FadeMensagem()
    {
        Color originalColor = mensagemText.color;
        float duration = 0.1f; // Duração do fade-in e fade-out

        // Fade-in
        for (float t = 0.01f; t < duration; t += Time.deltaTime)
        {
            mensagemText.color = new Color(originalColor.r, originalColor.g, originalColor.b, Mathf.Lerp(0, 1, t / duration));
            yield return null;
        }
        mensagemText.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1);

        // Aguarda 3 segundos
        yield return new WaitForSeconds(2);

        // Fade-out
        for (float t = 0.01f; t < duration; t += Time.deltaTime)
        {
            mensagemText.color = new Color(originalColor.r, originalColor.g, originalColor.b, Mathf.Lerp(1, 0, t / duration));
            yield return null;
        }
        mensagemText.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0);
    }
}
