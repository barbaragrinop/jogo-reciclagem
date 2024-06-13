using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GerenciadorPontos : MonoBehaviour
{
   public TextMeshProUGUI pontosText;
    private int pontos = 0;

    public GameObject victoryPanel; // Painel de vitória
    public TextMeshProUGUI victoryText; // Texto de vitória

     public TextMeshProUGUI timerText; // Texto do timer
    private float timeRemaining = 120f; 
    private bool timerIsRunning = false;

    public GameObject pausePanel; // Painel de pause

    private void Start()
    {
        AtualizarPontosText();
        victoryPanel.SetActive(false); // Certifique-se de que o painel esteja desativado no início
        pausePanel.SetActive(true); // Certifique-se de que o painel de pause esteja ativo no início
        timerIsRunning = false; // Não inicia o timer
        Time.timeScale = 0f; // Pausar o jogo no início
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 0f)
            {
                UnpauseGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                 timeRemaining -= Time.deltaTime;
                if (timeRemaining < 0)
                {
                    timeRemaining = 0;
                }
                AtualizarTimerText();
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                LoseGame(); // Tempo esgotado, chama a função de derrota
            }
        }
    }

    // Método para adicionar pontos
    public void AdicionarPonto()
    {
        pontos++;
        AtualizarPontosText();
        Debug.Log("Ponto adicionado. Pontos atuais: " + pontos);

        if (pontos >= 20)
        {
            WinGame();
        }
    }

    // Método para atualizar o texto dos pontos na tela
    void AtualizarPontosText()
    {
        if (pontosText != null)
        {
            pontosText.text = pontos.ToString();
        }
        else
        {
            Debug.LogError("pontosText não está atribuído no Inspector");
        }
    }

    // Método para atualizar o texto do timer na tela
    void AtualizarTimerText()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(timeRemaining / 60);
            int seconds = Mathf.FloorToInt(timeRemaining % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            Debug.LogError("timerText não está atribuído no Inspector");
        }
    }

    // Método para pausar o jogo e exibir o painel de vitória
    void WinGame()
    {
        Time.timeScale = 0f; // Pausar o jogo
        victoryText.text = "VOCÊ VENCEU";
        victoryPanel.SetActive(true);
    }

    // Método para pausar o jogo e exibir o painel de derrota
    void LoseGame()
    {
        Time.timeScale = 0f; // Pausar o jogo
        victoryText.text = "VOCÊ PERDEU";
        victoryText.color = Color.red;
        victoryPanel.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Retomar o jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f; // Pausar o jogo
        timerIsRunning = false;
        pausePanel.SetActive(true);
    }

    // Método para despausar o jogo e esconder o painel de pause
    public void UnpauseGame()
    {
        Time.timeScale = 1f; // Retomar o jogo
        timerIsRunning = true;
        pausePanel.SetActive(false);
    }

}
