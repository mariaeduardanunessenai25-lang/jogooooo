using UnityEngine;

public class Monstro : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth vida = collision.gameObject.GetComponent<PlayerHealth>();

            if (vida != null)
            {
                vida.TomarDano();
            }
        }
    }
}
