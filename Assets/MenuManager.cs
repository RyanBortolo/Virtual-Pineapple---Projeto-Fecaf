using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Função para o botão JOGAR
    public void IniciarJogo()
    {
    
        SceneManager.LoadScene("Fase 1"); 
    }

    // Função para o botão SAIR
    public void FecharJogo()
    {
        
        Debug.Log("O jogo foi fechado!"); 
        Application.Quit();
    }
}