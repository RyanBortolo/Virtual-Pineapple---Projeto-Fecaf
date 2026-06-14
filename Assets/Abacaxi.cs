using UnityEngine;
using UnityEngine.SceneManagement;

public class Abacaxi : MonoBehaviour
{
    [Header("Configurações")]
    public AudioClip somColeta;
    
    // TEXTO MÁGICO: Agora podemos digitar o nome da próxima fase no Inspector!
    public string proximaFase = "Fase 2"; 
    
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            if (gameManager != null)
            {
                gameManager.AddFruit();
            }

            GetComponent<Collider2D>().enabled = false;

            Animator anim = GetComponent<Animator>();
            if (anim != null)
            {
                anim.SetTrigger("Coletou");
            }

            if (somColeta != null)
            {
                AudioSource.PlayClipAtPoint(somColeta, Camera.main.transform.position, 0.4f);
            }

            Destroy(gameObject, 0.4f);

            // RADAR DE FASE
            GameObject[] abacaxis = GameObject.FindGameObjectsWithTag("Abacaxi");
            if (abacaxis.Length <= 1)
            {
                // AGORA ELE É INTELIGENTE: Carrega o nome que você digitou na Unity!
                SceneManager.LoadScene(proximaFase);
            }

            Debug.Log("O sapo pegou um abacaxi!");
        }
    }
}