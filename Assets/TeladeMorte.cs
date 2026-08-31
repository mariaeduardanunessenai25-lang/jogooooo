using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para reiniciar cenas

public class PlayerDeathManager : MonoBehaviour
{
    [Header("Configurações de Vida")]
    public int maxHealth = 100;
    private int currentHealth;

    [Header("Interface")]
    public GameObject deathScreenPanel; // Arraste o painel da morte aqui pelo Inspector

    void Start()
    {
        currentHealth = maxHealth;

        // Garante que a tela de morte começa desativada e o tempo rodando normal
        if (deathScreenPanel != null)
        {
            deathScreenPanel.SetActive(false);
        }
        Time.timeScale = 1f;
    }

    // Método para receber dano (chame este método quando o player for atingido)
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Morrer();
        }
    }

    // Método que aciona a morte
    void Morrer()
    {
        // Lógica adicional de morte (tocar animações, desativar movimentação, etc.)
        
        if (deathScreenPanel != null)
        {
            deathScreenPanel.SetActive(true); // Mostra a tela de morte
        }

        Time.timeScale = 0f; // Congela o jogo
    }

    // Método ligado ao botão "Reiniciar" da UI
    public void RestartGame()
    {
        Time.timeScale = 1f; // Retorna o tempo ao normal antes de recarregar
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}