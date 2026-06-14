using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    // A variável que vai guardar o seu Player lá no Inspector
    public Transform player; 
    
    // Controla a velocidade que a câmera alcança o personagem
    public float suavidade = 5f; 

    void LateUpdate()
    {
        if (player != null)
        {
            // Pega a posição X e Y do Player, mas mantém a câmera no fundo (Z = -10) para ela enxergar o jogo
            Vector3 posicaoAlvo = new Vector3(player.position.x, player.position.y, -10f);

            // A mágica do movimento suave
            transform.position = Vector3.Lerp(transform.position, posicaoAlvo, suavidade * Time.deltaTime);
        }
    }
}