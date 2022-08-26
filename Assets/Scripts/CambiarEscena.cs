using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarEscenaClick(string sceneName){
        Debug.Log("Cambiando de escena " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void SalirJuego(){
        Debug.Log("Sailiendo del juego");
        Application.Quit();
    }


}
