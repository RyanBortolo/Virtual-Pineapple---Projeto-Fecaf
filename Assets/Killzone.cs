using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para mexer com reiniciar fases

public class Killzone : MonoBehaviour
{
    // Esta função roda sozinha quando algo entra no sensor fantasma
    private void OnTriggerEnter2D(Collider2D colisao)
    {
        // Verifica se quem caiu aqui tem a etiqueta (Tag) de "Player"
        if (colisao.CompareTag("Player"))
        {
            // Descobre o nome da fase atual e recarrega ela do zero
            string faseAtual = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(faseAtual);
        }
    }
}