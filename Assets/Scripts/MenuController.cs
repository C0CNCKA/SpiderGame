using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour
{

    public GameObject blackScreen;

    // Функция для кнопки "Играть"
    public void StartGame()
    {
        StartCoroutine(StartGameSequence());
    }

    // Новая функция для кнопки "Выйти"
    public void ExitGame()
    {
        // Выводим сообщение в консоль, чтобы точно знать, что кнопка сработала
        Debug.Log("Выход из игры...");

        // Эта команда закрывает готовую скомпилированную игру (.exe)
        Application.Quit();

        // Макрос препроцессора (работает так же, как в C/C++)
        // Он остановит игру прямо внутри редактора Unity, иначе Application.Quit() там просто проигнорируется
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    IEnumerator StartGameSequence()
    {
        blackScreen.SetActive(true);

        blackScreen.GetComponent<Animator>().SetTrigger("FadeOut");

        yield return new WaitForSeconds(1.2f);

        SceneManager.LoadScene("VNScene");
    }
}