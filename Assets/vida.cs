using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int vida = 100;

    public void TomarDano()
    {
        vida = vida- 20;

        Debug.Log("Vida: " + vida);

        if (vida <= 0)
        {
            vida = 0;
            Morrer();
        }
    }

    void Morrer()
    {
        Debug.Log("O personagem morreu!");

        // Desativa o personagem
        gameObject.SetActive(false);
    }
}
