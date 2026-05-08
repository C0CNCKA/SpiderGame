using System;
using System.Collections; // Это нужно для работы с паузами
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextSequenceController : MonoBehaviour
{
    [SerializeField] private GameObject firstText;
    [SerializeField] private GameObject firstText_1;
    [SerializeField] private GameObject firstText_2;
    [SerializeField] private GameObject secondText_top;
    [SerializeField] private GameObject secondText_bottom;
    [SerializeField] private GameObject holeText_Intro;
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject atticBack;
    [SerializeField] private GameObject franklinImage;
    [SerializeField] private GameObject franklinHole;
    [SerializeField] private GameObject continueHint;
    [SerializeField] private GameObject fallText_top;
    [SerializeField] private GameObject fallText_bottom;
    [SerializeField] private AudioSource fallingSound;
    [SerializeField] private AudioSource pipeFell;
    

    void Start()
    {
        StartCoroutine(PlaySequence());
        StartCoroutine(ShowButtonWithDelay());
    }

    IEnumerator PlaySequence()
    {
        firstText.GetComponent<Animator>().SetTrigger("FadeIn");

        atticBack.SetActive(true);

        yield return new WaitForSeconds(2.5f);

        blackScreen.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(1f);

        firstText_1.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(3f);

        firstText_2.GetComponent<Animator>().SetTrigger("FadeIn");

        // Проверяем нажатие пробела через новую систему
        yield return new WaitUntil(() =>
            Keyboard.current.spaceKey.wasPressedThisFrame ||
            Keyboard.current.enterKey.wasPressedThisFrame ||
            Mouse.current.leftButton.wasPressedThisFrame);

        continueHint.GetComponent<Animator>().SetTrigger("FadeOut");

        continueHint.SetActive(false);

        StopCoroutine(ShowButtonWithDelay());

        firstText.GetComponent<Animator>().SetTrigger("FadeOut");
        firstText_1.GetComponent<Animator>().SetTrigger("FadeOut");
        firstText_2.GetComponent<Animator>().SetTrigger("FadeOut");

        yield return new WaitForSeconds(0.5f);

        franklinImage.SetActive(true);

        yield return new WaitForSeconds(0.5f);
       
        secondText_top.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(1.5f);

        secondText_bottom.GetComponent<Animator>().SetTrigger("FadeIn");

        atticBack.SetActive(false);

        yield return new WaitForSeconds(3f);

        secondText_top.GetComponent<Animator>().SetTrigger("FadeOut");
        secondText_bottom.GetComponent<Animator>().SetTrigger("FadeOut");
        blackScreen.GetComponent<Animator>().SetTrigger("FadeOut");

        yield return new WaitForSeconds(2f);
        
        holeText_Intro.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(2.5f);

        holeText_Intro.GetComponent<Animator>().SetTrigger("FadeOut");

        yield return new WaitForSeconds(1.5f);

        franklinHole.SetActive(true);

        blackScreen.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(1f);

        fallText_top.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(4f);

        blackScreen.GetComponent<Animator>().Play("Idle");
        blackScreen.GetComponent<RawImage>().color = new Color(0, 0, 0, 255);

        fallingSound.Play();

        yield return new WaitForSeconds(1f);

        fallText_bottom.GetComponent<Animator>().SetTrigger("FadeIn");

        yield return new WaitForSeconds(1.5f);

        fallText_bottom.GetComponent<Animator>().SetTrigger("FadeOut");
        fallText_top.GetComponent<Animator>().SetTrigger("FadeOut");

        yield return new WaitForSeconds(1f);

        pipeFell.Play();

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("TheGallery");

    }
    IEnumerator ShowButtonWithDelay()
    {
        // Ждем 3 секунды, пока идет анимация или просто пауза
        yield return new WaitForSeconds(10f);

        continueHint.SetActive(true);

        continueHint.GetComponent<Animator>().SetTrigger("FadeIn");


    }
}